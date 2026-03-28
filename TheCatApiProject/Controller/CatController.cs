using System.Threading.Tasks;
using TheCatApiProject.Models;
using TheCatApiProject.Service;
using TheCatApiProject.Data;

namespace TheCatApiProject.Controllers
{
    public class CatController
    {
        private readonly CatService _service = new CatService();
        private readonly CatRepository _repository = new CatRepository();

        public async Task<Cat> BuscarGato()
        {
            var cat = await _service.GetRandomCat();

            _repository.Salvar(cat); 

            return cat;
        }
    }
}