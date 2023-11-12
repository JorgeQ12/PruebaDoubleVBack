using Microsoft.AspNetCore.Mvc;
using PruebaDoubleV.Application.Services.Interfaces;
using PruebaDoubleV.Domain.Entities;
using PruebaDoubleV.DTOs;
using PruebaDoubleV.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDoubleV.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoubleVController : Controller
    {
        private readonly IDoubleVAppService _DoubleVAppService;
        public DoubleVController(IDoubleVAppService doubleVAppService)
        {
            _DoubleVAppService = doubleVAppService;
        }

        [HttpPost]
        [Route(nameof(DoubleVController.GetLoginUser))]
        public ResultResponse<Usuario> GetLoginUser(UsuarioDTO usuario) => _DoubleVAppService.GetLoginUser(usuario);

        [HttpGet]
        [Route(nameof(DoubleVController.GetTypeDocument))]
        public ResultResponse<List<TipoIdentificacion>> GetTypeDocument() => _DoubleVAppService.GetTypeDocument();

        [HttpPost]
        [Route(nameof(DoubleVController.InsertPerson))]
        public ResultResponse<Persona> InsertPerson(PersonaDTO persona) => _DoubleVAppService.InsertPerson(persona);

        [HttpPost]
        [Route(nameof(DoubleVController.InsertUser))]
        public ResultResponse<Usuario> InsertUser(UsuarioDTO usuario) => _DoubleVAppService.InsertUser(usuario);
    }
}
