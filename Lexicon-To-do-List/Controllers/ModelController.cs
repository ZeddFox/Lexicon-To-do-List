using Lexicon_To_do_List.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lexicon_To_do_List.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ModelController(CatalogueContext catalogueContext) : ControllerBase
    {
        private readonly CatalogueContext _catalogueContext = catalogueContext;
    }
}