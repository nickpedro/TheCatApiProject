using System.Threading.Tasks;
using TheCatApiProject.Models;
using TheCatApiProject.Service;

namespace TheCatApiProject.Controllers
{
    public class CatController
    {
        private readonly CatService _service = new CatService();

        public async Task<Cat> BuscarGato()
        {
            return await _service.GetRandomCat();
        }
    }
}