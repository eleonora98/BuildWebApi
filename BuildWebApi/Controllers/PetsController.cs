﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BuildWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly PetsRepository _repository;

        public PetsController(PetsRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Pet>>> GetAllAsync()
        {
            return await _repository.GetPetsAsync();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(404)]
        public async Task<ActionResult<Pet>> GetByIdAsync(int id)
        {
            var pet = await _repository.Pets.GetPetAsync(id);

            if (pet == null)
            {
                return NotFound();
            }

            return pet;
        }

        [HttpPost]
        [ProducesResponseType(400)]
        public async Task<ActionResult<Pet>> CreateAsync(Pet pet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _repository.AddPetAsync(pet);

            return CreatedAtAction(nameof(GetByIdAsync),
                new { id = pet.Id }, pet);
        }
    }
}