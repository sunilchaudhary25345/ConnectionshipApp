using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudinaryDotNet.Actions;

namespace Situationships.API.Interfaces
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddPhotosAsync(IFormFile file);
        Task<DeletionResult> DeletePhotoAsync(string publicId);
    }
}