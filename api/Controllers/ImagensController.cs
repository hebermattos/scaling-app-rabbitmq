using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImagensController : ControllerBase
    {
        private ServicoImagem _servicoImagem;

        public ImagensController()
        {
            _servicoImagem = new ServicoImagem();
        }

        [HttpGet]
        [Route("{id}")]
        public Imagem Get(string id)
        {
            return _servicoImagem.BuscarImagem(id);
        }
    }
}
