using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using IO.Swagger.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SwaggerApiExample.Attributes;

namespace SwaggerApiExample.Controllers
{
    [Route("api/[controller]")]
    public class InventoryController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        [ValidateModelState]
        public IActionResult SearchInventory([FromQuery]string searchString, [FromQuery]int? skip, [FromQuery][Range(0, 50)]int? limit)
        {
            string exampleJson = null;
            exampleJson = "[ {\n  \"releaseDate\" : \"2016-08-29T09:12:33.001Z\",\n  \"name\" : \"Widget Adapter\",\n  \"id\" : \"d290f1ee-6c54-4b01-90e6-d701748f0851\",\n  \"manufacturer\" : {\n    \"phone\" : \"408-867-5309\",\n    \"name\" : \"ACME Corporation\",\n    \"homePage\" : \"https://www.acme-corp.com\"\n  }\n}, {\n  \"releaseDate\" : \"2016-08-29T09:12:33.001Z\",\n  \"name\" : \"Widget Adapter\",\n  \"id\" : \"d290f1ee-6c54-4b01-90e6-d701748f0851\",\n  \"manufacturer\" : {\n    \"phone\" : \"408-867-5309\",\n    \"name\" : \"ACME Corporation\",\n    \"homePage\" : \"https://www.acme-corp.com\"\n  }\n} ]";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<InventoryItem>>(exampleJson)
            : default(List<InventoryItem>);

            return StatusCode(200, example);
        }

        [HttpPost]
        [ValidateModelState]
        public virtual IActionResult AddInventory([FromBody]InventoryItem inventoryItem)
        {
            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            return StatusCode(201);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 409 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(409);
        }
    }
}
