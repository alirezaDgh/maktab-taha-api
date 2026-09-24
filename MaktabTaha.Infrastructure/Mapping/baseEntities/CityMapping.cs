using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Infrastructure.Mapping.baseEntities
{
    public class CityMapping : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.ProvinceId);
            builder.HasOne(x => x.province)
                .WithMany(x => x.cities)
                .HasForeignKey(x => x.ProvinceId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
