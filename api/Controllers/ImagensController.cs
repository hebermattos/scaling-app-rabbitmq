using System.Threading.Tasks;
using core;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImagensController : ControllerBase
    {
        private ServicoBuscarImagem _servicoImagem;

        public ImagensController(ServicoBuscarImagem ServicoImagem)
        {
            _servicoImagem = ServicoImagem;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Imagem> GetAsync(string id)
        {
            return await _servicoImagem.BuscarImagemAsync(id);
        }
    }
}