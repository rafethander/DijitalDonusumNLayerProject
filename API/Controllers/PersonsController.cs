using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using API.Filters;
using AutoMapper;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _personService;
        private IMapper _mapper;

        public PersonsController(IPersonService personService,IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var persons = await _personService.GetAllAsync();

            return Ok(_mapper.Map<PersonDto>(persons));
        }

        [ValidationFilter]
        [HttpPost]
        public async Task<IActionResult> Save(PersonDto personDto)
        {
          var person= await _personService.AddAsync(_mapper.Map<Person>(personDto));

            return Created(string.Empty, _mapper.Map<PersonDto>(person));
        }
    }
}
