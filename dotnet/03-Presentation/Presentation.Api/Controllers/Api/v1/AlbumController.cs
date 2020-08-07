using System.Collections.Generic;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Presentation.Api.Controllers.Api.v1
{
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly ILogger<AlbumController> _logger;

        public AlbumController(ILogger<AlbumController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Album>> Index()
        {
            var albums = new List<Album>
            {
                new Album
                {
                    Name      = "test",
                    CatalogId = "abc-1234"
                }
            };

            return Ok(albums);
        }
    }
}
