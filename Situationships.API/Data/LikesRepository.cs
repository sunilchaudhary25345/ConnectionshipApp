using Microsoft.EntityFrameworkCore;
using Situationships.API.DTOs;
using Situationships.API.Entities;
using Situationships.API.Extensions;
using Situationships.API.Helpers;
using Situationships.API.Interfaces;

namespace Situationships.API.Data
{
    public class LikesRepository : ILikesRepository
    {
        private readonly DataContext _context;

        public LikesRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<UserLike> GetUserLike(int sourceUserId, int TargetUserId)
        {
            return await _context.Likes.FindAsync(sourceUserId, TargetUserId);
        }

        public async Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams)
        {
           var users = _context.Users.OrderBy(u => u.UserName).AsQueryable();
           var likes = _context.Likes.AsQueryable();

           if(likesParams.Predicate == "liked")
           {
                likes = likes.Where(like => like.SourceUserId == likesParams.UserId);
                users = likes.Select(like => like.TargetUser);
           }

            if(likesParams.Predicate == "likedBy")
           {
                likes = likes.Where(like => like.TargetUserId == likesParams.UserId);
                users = likes.Select(like => like.SourceUser);
           }
            var likedUsers = users.Select(user => new LikeDto
           {
                UserName = user.UserName,
                KnownAs = user.KnownAs,
                Age = user.DateOfBirth.CalculateAge(),
                PhotoUrl = user.Photos.FirstOrDefault(x => x.IsMain).Url,
                City = user.City,
                Id = user.Id
           });

           return await PagedList<LikeDto>.CreateAsync(likedUsers, likesParams.PageNumber, likesParams.PageSize);
        }

        public async Task<AppUser> GetUserWithLikes(int userId)
        {
           return await _context.Users
                .Include(x => x.LikedUsers)
                .FirstOrDefaultAsync(x => x.Id == userId);
        }
    }
}