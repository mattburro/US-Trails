using USTrails.API.Models.Domain;
using USTrails.API.Models.DTO;

namespace USTrails.API.Repositories
{
    public interface IImageRepository
    {
        Task<Image> Upload(CreateImageRequestDto createImageRequestDto);
    }
}
