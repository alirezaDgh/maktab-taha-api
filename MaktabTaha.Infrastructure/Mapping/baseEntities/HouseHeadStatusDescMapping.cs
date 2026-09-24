using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Infrastructure.Mapping.baseEntities
{
    public class HouseHeadStatusDescMapping : IEntityTypeConfiguration<HouseHeadStatusDesc>
    {
        public void Configure(EntityTypeBuilder<HouseHeadStatusDesc> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.HouseHeadStatusId);
            builder.HasOne(x => x.houseHeadStatus)
                .WithMany(x => x.houseHeadStatusDescs)
                .HasForeignKey(x => x.HouseHeadStatusId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
