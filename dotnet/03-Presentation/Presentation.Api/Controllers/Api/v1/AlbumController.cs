using System.Collections.Generic;
using AndcultureCode.CSharp.Core.Extensions;
using AutoMapper;
using Core.Interfaces.Conductors;
using Core.Models;
using Core.Models.Entities.Albums;
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

        private readonly ICreateConductor<Album>  _createConductor;
        private readonly IReadConductor<Album>    _readConductor;

        public AlbumController(
            ICreateConductor<Album>  createConductor,
            ILogger<AlbumController> logger,
            IMapper                  mapper,
            IReadConductor<Album>    readConductor
        )
        {
            _createConductor = createConductor;
            _logger          = logger;
            _readConductor   = readConductor;
            _mapper          = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AlbumDto>> Index()
        {
            var albumSearchResult = _readConductor.FindAll();

            if (albumSearchResult.HasErrorsOrResultIsNull())
            {
                return BadRequest(albumSearchResult);
            }

            return Ok(_mapper.Map<IEnumerable<AlbumDto>>(albumSearchResult.ResultObject));
        }

        [HttpPost]
        public ActionResult<AlbumDto> Create(AlbumDto album)
        {
            var createResult = _createConductor.Create(_mapper.Map<Album>(album));

            if (createResult.HasErrorsOrResultIsNull())
            {
                return BadRequest(createResult);
            }

            return Ok(_mapper.Map<AlbumDto>(createResult.ResultObject));
        }
    }
}
