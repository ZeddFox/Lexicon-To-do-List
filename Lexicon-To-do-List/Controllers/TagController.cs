using Lexicon_To_do_List.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lexicon_To_do_List.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TagController(CatalogueContext catalogueContext) : ModelController(catalogueContext)
    {
        private readonly CatalogueContext _catalogueContext = catalogueContext;

        // Read
        [Route("Read")]
        [HttpGet]
        public List<Tag> Index()
        {
            return _catalogueContext.Tags.ToList();
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
                    _catalogueContext.Tags.Add(new Tag(name));
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
                foreach (Tag item in _catalogueContext.Tags)
                {
                    if (item.Id == id)
                    {
                        _catalogueContext.Tags.Remove(item);
                        _catalogueContext.SaveChanges();
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}