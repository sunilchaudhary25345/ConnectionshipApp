using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Situationships.API.DTOs;
using Situationships.API.Entities;
using Situationships.API.Helpers;

namespace Situationships.API.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);
        Task<PagedList<MemberDto>> GetMembersAsync(UserParams userParams);
        Task<MemberDto> GetMemberAsync(string username);
    }
}