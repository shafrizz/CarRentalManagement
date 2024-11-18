﻿using CarRentalManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagement.Configurations.Entities
{
    public class ModelSeed : IEntityTypeConfiguration<Model>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model
                {
                    id = 1,
                    Name = "i4",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Model
                {
                    id = 2,
                    Name = "X5",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Model
                {
                    id = 3,
                    Name = "Prius",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Model
                {
                    id = 4,
                    Name = "C-HR",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }

            );
        }
    }
}

