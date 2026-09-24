using MaktabTaha.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Infrastructure.Mapping.initialRequest
{
    public class InitialRequestMapping : IEntityTypeConfiguration<InitialRequest>
    {
        public void Configure(EntityTypeBuilder<InitialRequest> builder)
        {
            builder.HasKey(x => x.RequestNumber);

            builder.Property(x => x.RequestDate);

            builder.Property(x => x.RequestDescription);

            builder.Property(x => x.ClientFirstName);

            builder.Property(x => x.ClientLastName);

            builder.Property(x => x.Gender);

            builder.Property(x => x.Address);

            builder.Property(x => x.MobileNumber);

            builder.Property(x => x.HomeNumber);

            builder.Property(x => x.Status);

            builder.Property(x => x.StatusReason);

            builder.Property(x => x.ApproveDate);

            builder.Property(x => x.OfficerDescription);

            builder.Property(x => x.Attachment);

            // RequestType
            builder.HasOne(x => x.requestType)
                   .WithMany()
                   .HasForeignKey(x => x.RequestTypeId)
                   .OnDelete(DeleteBehavior.Cascade);

            // HouseHeadStatus
            builder.HasOne(x => x.houseHeadStatus)
                   .WithMany()
                   .HasForeignKey(x => x.HouseHeadStatusId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Donor / Referer
            builder.HasOne(x => x.Referer)
                   .WithMany()
                   .HasForeignKey(x => x.RefererId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Nationalty
            builder.HasOne(x => x.nationalty)
                   .WithMany()
                   .HasForeignKey(x => x.NationaltyId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Province
            builder.HasOne(x => x.province)
                   .WithMany()
                   .HasForeignKey(x => x.ProvinceId)
                   .OnDelete(DeleteBehavior.Cascade);

            // City
            builder.HasOne(x => x.city)
                   .WithMany()
                   .HasForeignKey(x => x.CityId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Area
            builder.HasOne(x => x.area)
                   .WithMany()
                   .HasForeignKey(x => x.AreaId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Religon
            builder.HasOne(x => x.religon)
                   .WithMany()
                   .HasForeignKey(x => x.ReligonId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
