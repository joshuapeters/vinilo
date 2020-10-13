using System.Collections.Generic;
using AutoMapper;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Presentation.Api.Dtos.Albums;

namespace Presentation.Api.Controllers.Api.v1
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlbumController : ControllerBase
    {
        private readonly ILogger<AlbumController> _logger;
        private readonly IMapper                  _mapper;

        public AlbumController(
            ILogger<AlbumController> logger,
            IMapper                  mapper
        )
        {
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AlbumDto>> Index()
        {
            var albums = new List<AlbumDto>
            {
                new AlbumDto
                {
                    Name      = "test",
                    CatalogId = "abc-1234"
                }
            };

            return Ok(albums);
        }

        [HttpPost]
        public ActionResult<AlbumDto> Create(AlbumDto album)
        {
            return Ok(album);
        }
    }
}
