﻿using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Seed
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        private readonly Guid[] _ids;
        public CategorySeed(Guid[] id)
        {
            _ids = id;
        }
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id=_ids[0],Name="Elektronik"},
                new Category { Id=_ids[1],Name="Kırtasiye"}
            );
        }
    }
}
