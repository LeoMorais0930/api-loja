using Lojinha_Jorges.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace Lojinha_Jorges.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly OracleRepository _oracleRepository;

        public ProdutoController(OracleRepository oracleRepository)
        {
           _oracleRepository = oracleRepository;    
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> GetProdutos()
        {
            var dataTable = _oracleRepository.ExecuteQuery("SELECT * FROM \"PRODUTOS\"");
            return Ok(dataTable);

        }
    }
}
