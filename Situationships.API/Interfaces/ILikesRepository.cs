using System.ComponentModel.Design;
using Situationships.API.DTOs;
using Situationships.API.Entities;
using Situationships.API.Helpers;

namespace Situationships.API.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int TargetUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);
    }
}