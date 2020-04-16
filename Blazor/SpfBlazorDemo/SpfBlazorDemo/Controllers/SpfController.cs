using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SpfBlazorDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpfController : ControllerBase
    {
        [HttpGet("/base")]
        public async Task<IActionResult> GetBasePageAsync(long id)
        {
            var f = new Fragment();
            f.Body = new List<string>()
            {
                "<spfa-root></spfa-root>",
                "<script src='runtime.js' type='module'></script>",
                "<script src='polyfills.js' type='module'></script>",
                "<script src='styles.js' type='module'></script>",
                "<script src='vendor.js' type='module'></script>",
                "<script src='main.js' type='module'></script>"
            };
            f.Head = "<meta charset='utf-8'>" +
                     "";
            return NoContent();
        }

        [HttpGet("/angular")]
        public async Task<IActionResult> GetAngularPageAsync(long id)
        {

            return NoContent();
        }

        [HttpGet("/blazor")]
        public async Task<IActionResult> GetBlazorPageAsync(long id)
        {

            return NoContent();
        }
    }
}