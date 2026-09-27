using MaktabTaha.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Infrastructure.Mapping.donor
{
    public class DonorMapping : IEntityTypeConfiguration<Donor>

    {
        public void Configure(EntityTypeBuilder<Donor> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Firstname);
            builder.Property(x => x.Lastname);
            builder.Property(x => x.Firstname);
            builder.Property(x => x.Address);
            builder.Property(x => x.NationalCode);
        }
    }
}
