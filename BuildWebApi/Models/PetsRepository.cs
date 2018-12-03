using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildWebApi.Models
{
    public class PetsRepository : DbContext
    {
        public PetsRepository(DbContextOptions<PetsRepository> options)
            : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; }

        internal Task<ActionResult<List<Pet>>> GetPetsAsync()
        {
            throw new NotImplementedException();
        }

        internal Task GetPetAsync(int id)
        {
            throw new NotImplementedException();
        }

        internal Task AddPetAsync(Pet pet)
        {
            throw new NotImplementedException();
        }
    }
}
