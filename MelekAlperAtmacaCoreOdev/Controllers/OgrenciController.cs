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
    public class OgrenciController : ControllerBase
    {
        private readonly IOgrenciService _ogrenciService;
        private readonly IMapper _mapper;
        public OgrenciController(IOgrenciService ogrenciService,IMapper mapper)
        {
            _ogrenciService = ogrenciService;
            _mapper = mapper;
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAllOgrenci()
        {
            var ogrenciler = await _ogrenciService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<OgrenciDto>>(ogrenciler));
        }

        [Authorize]
        [HttpGet("{ogrenciId}")]
        public async Task<IActionResult> GetOgrenciById(int ogrenciId)
        {
            var ogrenci = await _ogrenciService.GetByIdAsync(ogrenciId);
            return Ok(_mapper.Map<OgrenciDto>(ogrenci));
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SaveOgrenci(OgrenciDto ogrenciDto)
        {
            var ogrenciEntity= await _ogrenciService.AddAsync(_mapper.Map<Ogrenci>(ogrenciDto));
            return Ok(_mapper.Map<OgrenciDto>(ogrenciEntity));
        }

        [Authorize]
        [HttpPut]
        public IActionResult UpdateOgrenci(OgrenciDto ogrenciDto)
        {
            var ogrenciEntity =  _ogrenciService.Update(_mapper.Map<Ogrenci>(ogrenciDto));
            return NoContent();
        }

        [Authorize]
        [HttpDelete("{ogrenciId}")]
        public IActionResult DeleteOgrenci(int ogrenciId)
        {
            var ogrenci = _ogrenciService.GetByIdAsync(ogrenciId).Result;
            _ogrenciService.Remove(ogrenci);
            return NoContent();
        }

        [Authorize]
        [HttpGet("{ogrenciId}/products")]
        public async Task<IActionResult> GetOgrenciWithOgrenciDersByID(int ogrenciId)
        {
            var ogrenci = await _ogrenciService.GetOgrenciWithOgrenciDersByIDAsync(ogrenciId);
            return Ok(_mapper.Map<OgrenciAndOgrenciDersDto>(ogrenci));
        }
    }
}