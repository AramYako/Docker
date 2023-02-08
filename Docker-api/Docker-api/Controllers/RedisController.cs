
using Docker_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace Docker_api.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class RedisController : ControllerBase
    {
        private readonly IDistributedCache _cache;

        public RedisController(IDistributedCache cache)
        {
            _cache = cache;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<string>> CreateProduct(ProductUpsert product)
        {
            string productId = Guid.NewGuid().ToString();

            string jsonString = JsonSerializer.Serialize(product);


            await _cache.SetStringAsync(productId, jsonString);

            return CreatedAtRoute(nameof(GetProduct), new { productId }, jsonString);
        }

        [HttpGet("{productId}", Name = "GetProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<string>> GetProduct(string productId)
        {
            var result = await _cache.GetStringAsync(productId);

            return Ok(result);
        }

    }
}
