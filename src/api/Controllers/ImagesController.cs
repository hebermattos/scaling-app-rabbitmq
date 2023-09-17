using System.Threading.Tasks;
using core;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImagesController : ControllerBase
    {
        private ImageService _imageService;

        public ImagesController(ImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Image> GetAsync(string id)
        {
            return await _imageService.GetImage(id);
        }
    }
}