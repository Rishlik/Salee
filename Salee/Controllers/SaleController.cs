using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Salee.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    public class SaleController : Controller
    {
        private readonly SaleComponentsContext _saleContext;
        public SaleController(SaleComponentsContext saleContext)
        {
            _saleContext = saleContext;

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSale(int id)
        {
            var sale = await _saleContext.Sales.FindAsync(id);
            if(sale == null)
            {
                return BadRequest();

            }
            return Ok(sale);

        }
        [HttpPost]
        public async Task<IActionResult> AddSale(Sale sale)
        {
            if (sale == null)
            {
                return BadRequest();
            }
            await _saleContext.Sales.AddAsync(sale);
            await _saleContext.SaveChangesAsync();
            return Ok(sale);

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sale>>> List()
        {
            return await _saleContext.Sales.ToListAsync();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var sale = await _saleContext.Sales.FindAsync(id);
            if(sale == null)
            {
                return BadRequest();
            }
            _saleContext.Sales.Remove(sale);
            await _saleContext.SaveChangesAsync();
            return Ok(sale);
        }
            
    }
}
