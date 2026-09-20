using MaktabTaha.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaktabTaha.Infrastructure.Mapping.user
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName);
            builder.Property(x => x.LastName);
            builder.Property(x => x.UserName);
            builder.Property(x => x.PasswordHash);
            builder.Property(x => x.Mobile);
        }
    }
}
