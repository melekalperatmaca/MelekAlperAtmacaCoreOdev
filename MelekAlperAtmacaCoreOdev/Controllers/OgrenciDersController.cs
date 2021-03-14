using AutoMapper;
using MelekAlperAtmacaCoreOdev.Core.Models;
using MelekAlperAtmacaCoreOdev.Core.Services;
using MelekAlperAtmacaCoreOdev.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MelekAlperAtmacaCoreOdev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OgrenciDersController : ControllerBase
    {
        private readonly IOgrenciDersService _ogrenciDersService;
        private readonly IMapper _mapper;
        public OgrenciDersController(IOgrenciDersService ogrenciDersService, IMapper mapper)
        {
            _ogrenciDersService = ogrenciDersService;
            _mapper = mapper;
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAllOgrenciDers()
        {
            var ogrenciDersler = await _ogrenciDersService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<OgrenciDersDto>>(ogrenciDersler));
        }

        [Authorize]
        [HttpGet("{ogrenciDersId}")]
        public async Task<IActionResult> GetOgrenciDersById(int ogrenciDersId)
        {
            var ogrenciDers = await _ogrenciDersService.GetByIdAsync(ogrenciDersId);
            return Ok(_mapper.Map<OgrenciDersDto>(ogrenciDers));
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SaveOgrenciDers(OgrenciDersDto ogrenciDersDto)
        {
            var ogrenciDersEntity = await _ogrenciDersService.AddAsync(_mapper.Map<OgrenciDers>(ogrenciDersDto));
            return Ok(_mapper.Map<OgrenciDersDto>(ogrenciDersEntity));
        }

        [Authorize]
        [HttpPut]
        public IActionResult UpdateOgrenciDers(OgrenciDersDto ogrenciDersDto)
        {
            var ogrenciDersEntity = _ogrenciDersService.Update(_mapper.Map<OgrenciDers>(ogrenciDersDto));
            return NoContent();
        }

        [Authorize]
        [HttpDelete("{ogrenciDersId}")]
        public IActionResult DeleteOgrenciDers(int ogrenciDersId)
        {
            var ogrenciDers = _ogrenciDersService.GetByIdAsync(ogrenciDersId).Result;
            _ogrenciDersService.Remove(ogrenciDers);
            return NoContent();
        }
    }
}