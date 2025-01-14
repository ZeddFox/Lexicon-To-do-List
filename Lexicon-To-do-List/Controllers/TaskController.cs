using Lexicon_To_do_List.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lexicon_To_do_List.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController(CatalogueContext catalogueContext) : ModelController(catalogueContext)
    {
        private readonly CatalogueContext _catalogueContext = catalogueContext;

        // Read
        [Route("Read")]
        [HttpGet]
        public List<Models.Task> Index()
        {
            return _catalogueContext.Tasks.ToList();
        }

        // Create & Update
        [Route("Create")]
        [HttpPost]
        public bool Create(string name)
        {
            try
            {
                if (!string.IsNullOrEmpty(name))
                {
                    _catalogueContext.Tasks.Add(new Models.Task(name));
                    _catalogueContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        //Delete & Update
        [Route("Delete")]
        [HttpPost]
        public bool Remove(int id)
        {
            try
            {
                foreach (Models.Task item in _catalogueContext.Tasks)
                {
                    if (item.Id == id)
                    {
                        _catalogueContext.Tasks.Remove(item);
                    }
                }
                _catalogueContext.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}