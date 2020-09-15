using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Seed
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly Guid[] _ids; //Fksı id siz oluşması hata vericeğinden bu şekilde yaptık.
        public ProductSeed(Guid[] id)
        {
            _ids = id;
        }
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product {Id=Guid.NewGuid(),Name="Monitor",Price=2000.50m,CategoryId=_ids[0] },
                new Product {Id=Guid.NewGuid(),Name="Klavye",Price=100.50m,CategoryId=_ids[0] },
                new Product {Id=Guid.NewGuid(),Name="Laptop",Price=4000.50m,CategoryId=_ids[0] },
                new Product {Id=Guid.NewGuid(),Name="Masaüstü",Price=5000.50m,CategoryId=_ids[0] },
                new Product {Id=Guid.NewGuid(),Name="Kalem",Price=2000.50m,CategoryId=_ids[1] },
                new Product {Id=Guid.NewGuid(),Name="Kitap",Price=2000.50m,CategoryId=_ids[1] }
                );
        }
    }
}
