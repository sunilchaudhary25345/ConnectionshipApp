using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Situationships.API.Entities;

namespace Situationships.API.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}