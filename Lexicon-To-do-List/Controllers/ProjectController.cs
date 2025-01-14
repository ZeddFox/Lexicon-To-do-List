using Lexicon_To_do_List.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace Lexicon_To_do_List.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController(CatalogueContext catalogueContext) : ModelController(catalogueContext)
    {
        private readonly CatalogueContext _catalogueContext = catalogueContext;

        // Read
        [Route("Read")]
        [HttpGet]
        public List<Project> Index()
        {
            return _catalogueContext.Projects.ToList();
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
                    _catalogueContext.Projects.Add(new Project(name));
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
                foreach (Project item in _catalogueContext.Projects)
                {
                    if (item.Id == id)
                    {
                        _catalogueContext.Projects.Remove(item);
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