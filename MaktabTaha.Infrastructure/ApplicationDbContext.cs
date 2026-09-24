using MaktabTaha.Domain.Entites;
using MaktabTaha.Domain.Entites.BaseEntities;
using MaktabTaha.Infrastructure.Mapping.baseEntities;
using MaktabTaha.Infrastructure.Mapping.initialRequest;
using MaktabTaha.Infrastructure.Mapping.permission;
using MaktabTaha.Infrastructure.Mapping.user;
using MaktabTaha.Infrastructure.Mapping.user_permission;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }
        public DbSet<InitialRequest> InitialRequests { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<CaseType> CaseTypes { get; set; }
        public DbSet<CharityMainRole> CharityMainRoles { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<EducationLevel> EducationLevel { get; set; }
        public DbSet<EducationStatus> EducationStatus { get; set; }
        public DbSet<EmploymentStatus> EmploymantStatus { get; set; }
        public DbSet<GoodWorkType> GoodWorkTypes { get; set; }
        public DbSet<HouseHeadStatusDesc> HouseHeadStatusDescs { get; set; }
        public DbSet<HouseHeadStatus> HouseHeadStatus { get; set; }
        public DbSet<HousingStatus> HousingStatus { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Nationalty> Nationalties { get; set; }
        public DbSet<OrphanStatus> OrphanStatus { get; set; }
        public DbSet<PhysicalStatus> PhysicalStatus { get; set; }
        public DbSet<PrivatenessStatus> PrivatenessStatus { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Religon> Religons { get; set; }
        public DbSet<Relation> Relations { get; set; }
        public DbSet<RequestType> RequestTypes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UnemploymentReason> UnemploymentReasons { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new PermissionMapping());
            modelBuilder.ApplyConfiguration(new UserPermissionMapping());
            modelBuilder.ApplyConfiguration(new InitialRequestMapping());
            modelBuilder.ApplyConfiguration(new AreaMapping());
            modelBuilder.ApplyConfiguration(new BankMapping());
            modelBuilder.ApplyConfiguration(new CaseTypeMapping()); 
            modelBuilder.ApplyConfiguration(new CharityMainRoleMapping());
            modelBuilder.ApplyConfiguration(new CityMapping());
            modelBuilder.ApplyConfiguration(new EducationalLevelMapping());
            modelBuilder.ApplyConfiguration(new EducationalStatusMapping());
            modelBuilder.ApplyConfiguration(new EmploymantStatusMapping());
            modelBuilder.ApplyConfiguration(new GoodWorkTypeMapping());
            modelBuilder.ApplyConfiguration(new HouseHeadStatusDescMapping());
            modelBuilder.ApplyConfiguration(new HouseHeadStatusMapping());
            modelBuilder.ApplyConfiguration(new HousingStatusMapping()); 
            modelBuilder.ApplyConfiguration(new JobMapping()); 
            modelBuilder.ApplyConfiguration(new NationaltyMapping()); 
            modelBuilder.ApplyConfiguration(new OrphanStatusMapping());
            modelBuilder.ApplyConfiguration(new PhysicalStatusMapping());
            modelBuilder.ApplyConfiguration(new PrivatenessStatusMapping());
            modelBuilder.ApplyConfiguration(new ProvinceMapping());
            modelBuilder.ApplyConfiguration(new ReligonMapping());
            modelBuilder.ApplyConfiguration(new RelationMapping()); 
            modelBuilder.ApplyConfiguration(new RequestTypeMapping());
            modelBuilder.ApplyConfiguration(new SkillMapping());
            modelBuilder.ApplyConfiguration(new UnemploymentReasonMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
