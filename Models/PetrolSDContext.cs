using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiAppPetrol.Models
{
    public partial class PetrolSDContext : DbContext
    {
        public PetrolSDContext()
        {
        }

        public PetrolSDContext(DbContextOptions<PetrolSDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Mconfig> Mconfig { get; set; }
        public virtual DbSet<Mmachine> Mmachine { get; set; }
        public virtual DbSet<MmachineAssent> MmachineAssent { get; set; }
        public virtual DbSet<MmachineAttachment> MmachineAttachment { get; set; }
        public virtual DbSet<Mprofile> Mprofile { get; set; }
        public virtual DbSet<MprofileAttachment> MprofileAttachment { get; set; }
        public virtual DbSet<MprofileFacility> MprofileFacility { get; set; }
        public virtual DbSet<MprofileFacilityAssent> MprofileFacilityAssent { get; set; }
        public virtual DbSet<MprofileFacilityAttachment> MprofileFacilityAttachment { get; set; }
        public virtual DbSet<Mvehicle> Mvehicle { get; set; }
        public virtual DbSet<MvehicleAssent> MvehicleAssent { get; set; }
        public virtual DbSet<MvehicleAttachment> MvehicleAttachment { get; set; }
        public virtual DbSet<MvehicleCard> MvehicleCard { get; set; }
        public virtual DbSet<MvehicleTripAssent> MvehicleTripAssent { get; set; }
        public virtual DbSet<Ncompany> Ncompany { get; set; }
        public virtual DbSet<Nfacility> Nfacility { get; set; }
        public virtual DbSet<NfacilityAgent> NfacilityAgent { get; set; }
        public virtual DbSet<Nfuel> Nfuel { get; set; }
        public virtual DbSet<Nsection> Nsection { get; set; }
        public virtual DbSet<NsiteSurvey> NsiteSurvey { get; set; }
        public virtual DbSet<Nstate> Nstate { get; set; }
        public virtual DbSet<NtripConfig> NtripConfig { get; set; }
        public virtual DbSet<NwareHouse> NwareHouse { get; set; }
        public virtual DbSet<SactionType> SactionType { get; set; }
        public virtual DbSet<ScarLetter> ScarLetter { get; set; }
        public virtual DbSet<Sconsumption> Sconsumption { get; set; }
        public virtual DbSet<Scountry> Scountry { get; set; }
        public virtual DbSet<SfuelType> SfuelType { get; set; }
        public virtual DbSet<Sidtype> Sidtype { get; set; }
        public virtual DbSet<Sjob> Sjob { get; set; }
        public virtual DbSet<Slocality> Slocality { get; set; }
        public virtual DbSet<SmachineAttachmentType> SmachineAttachmentType { get; set; }
        public virtual DbSet<SmachineMark> SmachineMark { get; set; }
        public virtual DbSet<SmachineModel> SmachineModel { get; set; }
        public virtual DbSet<SmachineType> SmachineType { get; set; }
        public virtual DbSet<Soffice> Soffice { get; set; }
        public virtual DbSet<SprofileAttachmentType> SprofileAttachmentType { get; set; }
        public virtual DbSet<SprofileFacilityAttachmentTypes> SprofileFacilityAttachmentTypes { get; set; }
        public virtual DbSet<SprofileType> SprofileType { get; set; }
        public virtual DbSet<Sreject> Sreject { get; set; }
        public virtual DbSet<SroadType> SroadType { get; set; }
        public virtual DbSet<Sstation> Sstation { get; set; }
        public virtual DbSet<SstationType> SstationType { get; set; }
        public virtual DbSet<Sstatus> Sstatus { get; set; }
        public virtual DbSet<SstatusAssent> SstatusAssent { get; set; }
        public virtual DbSet<StripAuth> StripAuth { get; set; }
        public virtual DbSet<StripAuthProvider> StripAuthProvider { get; set; }
        public virtual DbSet<SuserLocality> SuserLocality { get; set; }
        public virtual DbSet<SvehicleAttachmentType> SvehicleAttachmentType { get; set; }
        public virtual DbSet<SvehicleMark> SvehicleMark { get; set; }
        public virtual DbSet<SvehicleModel> SvehicleModel { get; set; }
        public virtual DbSet<SvehicleType> SvehicleType { get; set; }
        public virtual DbSet<TfacilityMachineUse> TfacilityMachineUse { get; set; }
        public virtual DbSet<TfacilityVehicleUse> TfacilityVehicleUse { get; set; }
        public virtual DbSet<TfuelTypeStation> TfuelTypeStation { get; set; }
        public virtual DbSet<TfuelTypeWareHouse> TfuelTypeWareHouse { get; set; }
        public virtual DbSet<TonRoadQuota> TonRoadQuota { get; set; }
        public virtual DbSet<Tquota> Tquota { get; set; }
        public virtual DbSet<TquotaCompany> TquotaCompany { get; set; }
        public virtual DbSet<TquotaState> TquotaState { get; set; }
        public virtual DbSet<TquotaStation> TquotaStation { get; set; }
        public virtual DbSet<TquotaWareHouse> TquotaWareHouse { get; set; }
        public virtual DbSet<TstationQuota> TstationQuota { get; set; }
        public virtual DbSet<TstationType> TstationType { get; set; }
        public virtual DbSet<ZandroidSettings> ZandroidSettings { get; set; }
        public virtual DbSet<ZappUser> ZappUser { get; set; }
        public virtual DbSet<ZcheckPoint> ZcheckPoint { get; set; }

        // Unable to generate entity type for table 'dbo.MAction'. Please see the warning messages.

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=PetrolSD;Integrated Security=True");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Mconfig>(entity =>
            {
                entity.HasKey(e => e.ConfigId);

                entity.ToTable("MConfig");

                entity.HasIndex(e => new { e.StateId, e.SectionId, e.FacilityId, e.ProfileTypeId, e.FuelId, e.FuelTypeId })
                    .HasName("IX_MConfig_Unique")
                    .IsUnique();

                entity.Property(e => e.ConfigId).HasColumnName("ConfigID");

                entity.Property(e => e.FacilityId).HasColumnName("FacilityID");

                entity.Property(e => e.FuelId).HasColumnName("FuelID");

                entity.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");

                entity.Property(e => e.ProfileTypeId).HasColumnName("ProfileTypeID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.Mconfig)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MConfig_NFacility");

                entity.HasOne(d => d.Fuel)
                    .WithMany(p => p.Mconfig)
                    .HasForeignKey(d => d.FuelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MConfig_NFuel");

                entity.HasOne(d => d.FuelType)
                    .WithMany(p => p.Mconfig)
                    .HasForeignKey(d => d.FuelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MConfig_SFuelType");

                entity.HasOne(d => d.ProfileType)
                    .WithMany(p => p.Mconfig)
                    .HasForeignKey(d => d.ProfileTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MConfig_SProfileType");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Mconfig)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MConfig_NSection");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Mconfig)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MConfig_NState");
            });

            modelBuilder.Entity<Mmachine>(entity =>
            {
                entity.HasKey(e => e.MachineId);

                entity.ToTable("MMachine");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ChassisNum).HasMaxLength(20);

                entity.Property(e => e.ConsumptionId).HasColumnName("ConsumptionID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.DateModified).HasColumnType("smalldatetime");

                entity.Property(e => e.EngineCc)
                    .HasColumnName("EngineCC")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EngineNum).HasMaxLength(20);

                entity.Property(e => e.FuelId).HasColumnName("FuelID");

                entity.Property(e => e.MachineTypeId).HasColumnName("MachineTypeID");

                entity.Property(e => e.ManufaDate)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.MarkId).HasColumnName("MarkID");

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.ProfileFacilityId).HasColumnName("ProfileFacilityID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TankCapacity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserAdded)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserModified).HasMaxLength(50);

                entity.HasOne(d => d.Consumption)
                    .WithMany(p => p.Mmachine)
                    .HasForeignKey(d => d.ConsumptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MMachine_SConsumption");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Mmachine)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MMachine_SCountry");

                entity.HasOne(d => d.Fuel)
                    .WithMany(p => p.Mmachine)
                    .HasForeignKey(d => d.FuelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MMachine_NFuel");

                entity.HasOne(d => d.MachineType)
                    .WithMany(p => p.Mmachine)
                    .HasForeignKey(d => d.MachineTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MMachine_SMachineType");

                entity.HasOne(d => d.Mark)
                    .WithMany(p => p.Mmachine)
                    .HasForeignKey(d => d.MarkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MMachine_SMark");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.Mmachine)
                    .HasForeignKey(d => d.ModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MMachine_SModel");

                entity.HasOne(d => d.ProfileFacility)
                    .WithMany(p => p.Mmachine)
                    .HasForeignKey(d => d.ProfileFacilityId)
                    .HasConstraintName("FK_MMachine_MProfileFacility");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Mmachine)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MMachine_MProfile");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Mmachine)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MMachine_SStatus");
            });

            modelBuilder.Entity<MmachineAssent>(entity =>
            {
                entity.HasKey(e => new { e.ProfileFacilityAssentId, e.MachineId })
                    .HasName("PK_MAssent");

                entity.ToTable("MMachineAssent");

                entity.Property(e => e.ProfileFacilityAssentId).HasColumnName("ProfileFacilityAssentID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ConsumptionId).HasColumnName("ConsumptionID");

                entity.Property(e => e.MonthlyUse).HasDefaultValueSql("((30))");

                entity.Property(e => e.TotalLiter).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.MmachineAssent)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MAssent_MMachine");
            });

            modelBuilder.Entity<MmachineAttachment>(entity =>
            {
                entity.HasKey(e => e.AttachmentId)
                    .HasName("PK_NMachineAttachment");

                entity.ToTable("MMachineAttachment");

                entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

                entity.Property(e => e.AttachmentPath)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.AttachmentTypeId).HasColumnName("AttachmentTypeID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.HasOne(d => d.AttachmentType)
                    .WithMany(p => p.MmachineAttachment)
                    .HasForeignKey(d => d.AttachmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MMachineAttachment_SMachineAttachmentType");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.MmachineAttachment)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NMachineAttachment_MMachine");
            });

            modelBuilder.Entity<Mprofile>(entity =>
            {
                entity.HasKey(e => e.ProfileId);

                entity.ToTable("MProfile");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.DateModified).HasColumnType("smalldatetime");

                entity.Property(e => e.IdissueDate)
                    .HasColumnName("IDIssueDate")
                    .HasColumnType("date");

                entity.Property(e => e.Idnumber)
                    .HasColumnName("IDNumber")
                    .HasMaxLength(30);

                entity.Property(e => e.IdtypeId).HasColumnName("IDTypeID");

                entity.Property(e => e.JobAddress).HasMaxLength(200);

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.LocalityId).HasColumnName("LocalityID");

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.Phone1)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Phone2)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.ProfileName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ProfileStatusId).HasColumnName("ProfileStatusID");

                entity.Property(e => e.ProfileTypeId).HasColumnName("ProfileTypeID");

                entity.Property(e => e.RejectId).HasColumnName("RejectID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.TransportMember).HasMaxLength(20);

                entity.Property(e => e.UserAdded)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserModified).HasMaxLength(50);

                entity.HasOne(d => d.Idtype)
                    .WithMany(p => p.Mprofile)
                    .HasForeignKey(d => d.IdtypeId)
                    .HasConstraintName("FK_MProfile_SIDType");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Mprofile)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfile_SJob");

                entity.HasOne(d => d.Locality)
                    .WithMany(p => p.Mprofile)
                    .HasForeignKey(d => d.LocalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfile_SLocality");

                entity.HasOne(d => d.ProfileStatus)
                    .WithMany(p => p.Mprofile)
                    .HasForeignKey(d => d.ProfileStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfile_SStatus");

                entity.HasOne(d => d.ProfileType)
                    .WithMany(p => p.Mprofile)
                    .HasForeignKey(d => d.ProfileTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfile_SProfileType");

                entity.HasOne(d => d.Reject)
                    .WithMany(p => p.Mprofile)
                    .HasForeignKey(d => d.RejectId)
                    .HasConstraintName("FK_MProfile_SReject");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Mprofile)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfile_NState");
            });

            modelBuilder.Entity<MprofileAttachment>(entity =>
            {
                entity.HasKey(e => e.AttachmentId);

                entity.ToTable("MProfileAttachment");

                entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

                entity.Property(e => e.AttachmentPath)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.AttachmentTypeId).HasColumnName("AttachmentTypeID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.HasOne(d => d.AttachmentType)
                    .WithMany(p => p.MprofileAttachment)
                    .HasForeignKey(d => d.AttachmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileAttachment_SAttachmentType");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.MprofileAttachment)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileAttachment_MProfile");
            });

            modelBuilder.Entity<MprofileFacility>(entity =>
            {
                entity.HasKey(e => e.ProfileFacilityId);

                entity.ToTable("MProfileFacility");

                entity.Property(e => e.ProfileFacilityId).HasColumnName("ProfileFacilityID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.DateModified).HasColumnType("smalldatetime");

                entity.Property(e => e.ElectricityNumber).HasMaxLength(15);

                entity.Property(e => e.FacilityAgentId).HasColumnName("FacilityAgentID");

                entity.Property(e => e.FacilityId).HasColumnName("FacilityID");

                entity.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");

                entity.Property(e => e.GeoCode)
                    .IsRequired()
                    .HasColumnName("geoCode")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.Lat).HasColumnType("decimal(18, 18)");

                entity.Property(e => e.LocalityId).HasColumnName("LocalityID");

                entity.Property(e => e.Long).HasColumnType("decimal(18, 18)");

                entity.Property(e => e.ProfileFacilityName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TotalArea)
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserAdded)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserModified).HasMaxLength(50);

                entity.HasOne(d => d.FacilityAgent)
                    .WithMany(p => p.MprofileFacility)
                    .HasForeignKey(d => d.FacilityAgentId)
                    .HasConstraintName("FK_MProfileFacility_NFacilityAgent");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.MprofileFacility)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileFacility_NFacility");

                entity.HasOne(d => d.FuelType)
                    .WithMany(p => p.MprofileFacility)
                    .HasForeignKey(d => d.FuelTypeId)
                    .HasConstraintName("FK_MProfileFacility_SFuelType");

                entity.HasOne(d => d.Locality)
                    .WithMany(p => p.MprofileFacility)
                    .HasForeignKey(d => d.LocalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileFacility_SLocality");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.MprofileFacility)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileFacility_MProfile");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.MprofileFacility)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileFacility_NSection");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.MprofileFacility)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileFacility_NState");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MprofileFacility)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileFacility_SStatus");
            });

            modelBuilder.Entity<MprofileFacilityAssent>(entity =>
            {
                entity.HasKey(e => e.AssentId);

                entity.ToTable("MProfileFacilityAssent");

                entity.Property(e => e.AssentId).HasColumnName("AssentID");

                entity.Property(e => e.ApprovedLiter).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateDispose).HasColumnType("datetime");

                entity.Property(e => e.ExpDate).HasColumnType("date");

                entity.Property(e => e.FacilityAgentId).HasColumnName("FacilityAgentID");

                entity.Property(e => e.FacilityId).HasColumnName("FacilityID");

                entity.Property(e => e.FuelId).HasColumnName("FuelID");

                entity.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");

                entity.Property(e => e.LocalityId).HasColumnName("LocalityID");

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.ProfileFacilityId).HasColumnName("ProfileFacilityID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.ProfileTypeId).HasColumnName("ProfileTypeID");

                entity.Property(e => e.Qrcode).HasColumnName("QRCode");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StationId).HasColumnName("StationID");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TotalLiter).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserAdded)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserDispose).HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MprofileFacilityAssent)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileFacilityAssent_NCompany");

                entity.HasOne(d => d.FacilityAgent)
                    .WithMany(p => p.MprofileFacilityAssent)
                    .HasForeignKey(d => d.FacilityAgentId)
                    .HasConstraintName("FK_MProfileFacilityAssent_NFacilityAgent");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.MprofileFacilityAssent)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileFacilityAssent_NFacility");

                entity.HasOne(d => d.Fuel)
                    .WithMany(p => p.MprofileFacilityAssent)
                    .HasForeignKey(d => d.FuelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileFacilityAssent_NFuel");

                entity.HasOne(d => d.FuelType)
                    .WithMany(p => p.MprofileFacilityAssent)
                    .HasForeignKey(d => d.FuelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileFacilityAssent_SFuelType");

                entity.HasOne(d => d.Locality)
                    .WithMany(p => p.MprofileFacilityAssent)
                    .HasForeignKey(d => d.LocalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileFacilityAssent_SLocality");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.MprofileFacilityAssent)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileFacilityAssent_SOffice");

                entity.HasOne(d => d.ProfileFacility)
                    .WithMany(p => p.MprofileFacilityAssent)
                    .HasForeignKey(d => d.ProfileFacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileFacilityAssent_MProfileFacility");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.MprofileFacilityAssent)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileFacilityAssent_MProfile");

                entity.HasOne(d => d.ProfileType)
                    .WithMany(p => p.MprofileFacilityAssent)
                    .HasForeignKey(d => d.ProfileTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileFacilityAssent_SProfileType");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.MprofileFacilityAssent)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileFacilityAssent_NSection");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.MprofileFacilityAssent)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileFacilityAssent_NState");

                entity.HasOne(d => d.Station)
                    .WithMany(p => p.MprofileFacilityAssent)
                    .HasForeignKey(d => d.StationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileFacilityAssent_SStation");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MprofileFacilityAssent)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileFacilityAssent_SStatus");
            });

            modelBuilder.Entity<MprofileFacilityAttachment>(entity =>
            {
                entity.HasKey(e => e.AttachmentId);

                entity.ToTable("MProfileFacilityAttachment");

                entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

                entity.Property(e => e.AttachmentPath)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.AttachmentTypeId).HasColumnName("AttachmentTypeID");

                entity.Property(e => e.ProfileFacilityId).HasColumnName("ProfileFacilityID");

                entity.HasOne(d => d.AttachmentType)
                    .WithMany(p => p.MprofileFacilityAttachment)
                    .HasForeignKey(d => d.AttachmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileFacilityAttachment_SProfileFacilityAttachmentTypes");

                entity.HasOne(d => d.ProfileFacility)
                    .WithMany(p => p.MprofileFacilityAttachment)
                    .HasForeignKey(d => d.ProfileFacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MProfileFacilityAttachment_MProfileFacility");
            });

            modelBuilder.Entity<Mvehicle>(entity =>
            {
                entity.HasKey(e => e.VehicleId);

                entity.ToTable("MVehicle");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.ChassisNum).HasMaxLength(20);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.DateModified).HasColumnType("smalldatetime");

                entity.Property(e => e.EngineCc)
                    .HasColumnName("EngineCC")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EngineNum).HasMaxLength(20);

                entity.Property(e => e.ExtraTankCapacity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FuelId).HasColumnName("FuelID");

                entity.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");

                entity.Property(e => e.ManufaDate)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.MarkId).HasColumnName("MarkID");

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.PlateChar)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.QrCode).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Rfid)
                    .HasColumnName("RFID")
                    .HasMaxLength(100);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TankCapacity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserAdded)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserModified).HasMaxLength(50);

                entity.Property(e => e.VehicleTypeId).HasColumnName("VehicleTypeID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Mvehicle)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicle_SCountry");

                entity.HasOne(d => d.Fuel)
                    .WithMany(p => p.Mvehicle)
                    .HasForeignKey(d => d.FuelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicle_NFuel");

                entity.HasOne(d => d.FuelType)
                    .WithMany(p => p.Mvehicle)
                    .HasForeignKey(d => d.FuelTypeId)
                    .HasConstraintName("FK_MVehicle_SFuelType");

                entity.HasOne(d => d.Mark)
                    .WithMany(p => p.Mvehicle)
                    .HasForeignKey(d => d.MarkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicle_SVehicleMark");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.Mvehicle)
                    .HasForeignKey(d => d.ModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicle_SVehicleModel");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Mvehicle)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicle_MProfile");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Mvehicle)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicle_SStatus");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.Mvehicle)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicle_SVehicleType");
            });

            modelBuilder.Entity<MvehicleAssent>(entity =>
            {
                entity.HasKey(e => new { e.ProfileFacilityAssentId, e.VehicleId });

                entity.ToTable("MVehicleAssent");

                entity.Property(e => e.ProfileFacilityAssentId).HasColumnName("ProfileFacilityAssentID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.ConsumptionId).HasColumnName("ConsumptionID");

                entity.Property(e => e.MonthlyUse).HasDefaultValueSql("((30))");

                entity.Property(e => e.TotalLiter).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.MvehicleAssent)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicleAssent_MVehicle");
            });

            modelBuilder.Entity<MvehicleAttachment>(entity =>
            {
                entity.HasKey(e => e.AttachmentId);

                entity.ToTable("MVehicleAttachment");

                entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

                entity.Property(e => e.AttachmentPath)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.AttachmentTypeId).HasColumnName("AttachmentTypeID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.AttachmentType)
                    .WithMany(p => p.MvehicleAttachment)
                    .HasForeignKey(d => d.AttachmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicleAttachment_SVehicleAttachmentType");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.MvehicleAttachment)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicleAttachment_MVehicle");
            });

            modelBuilder.Entity<MvehicleCard>(entity =>
            {
                entity.HasKey(e => e.VehicleCardId)
                    .HasName("PK_MVehicleCard_1");

                entity.ToTable("MVehicleCard");

                entity.Property(e => e.VehicleCardId)
                    .HasColumnName("VehicleCardID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExpDate).HasColumnType("date");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.UserAdded)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.VehicleCard)
                    .WithOne(p => p.MvehicleCard)
                    .HasForeignKey<MvehicleCard>(d => d.VehicleCardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicleCard_MProfile");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.MvehicleCard)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicleCard_MVehicle");
            });

            modelBuilder.Entity<MvehicleTripAssent>(entity =>
            {
                entity.HasKey(e => e.AssentId);

                entity.ToTable("MVehicleTripAssent");

                entity.Property(e => e.AssentId).HasColumnName("AssentID");

                entity.Property(e => e.ApprovedLiter).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateDispose).HasColumnType("datetime");

                entity.Property(e => e.ExpDate).HasColumnType("date");

                entity.Property(e => e.FuelId).HasColumnName("FuelID");

                entity.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");

                entity.Property(e => e.LocalityId).HasColumnName("LocalityID");

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.ProfileTypeId).HasColumnName("ProfileTypeID");

                entity.Property(e => e.Qrcode).HasColumnName("QRCode");

                entity.Property(e => e.RemLiter).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StationId).HasColumnName("StationID");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TripAuthId).HasColumnName("TripAuthID");

                entity.Property(e => e.TripAuthNumber).HasMaxLength(50);

                entity.Property(e => e.TripAuthProviderId).HasColumnName("TripAuthProviderID");

                entity.Property(e => e.TripId).HasColumnName("TripID");

                entity.Property(e => e.TripType).HasDefaultValueSql("((1))");

                entity.Property(e => e.UserAdded)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserDispose).HasMaxLength(50);

                entity.Property(e => e.VehicleAgentId).HasColumnName("VehicleAgentID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MvehicleTripAssent)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicleTripAssent_NCompany");

                entity.HasOne(d => d.Fuel)
                    .WithMany(p => p.MvehicleTripAssent)
                    .HasForeignKey(d => d.FuelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicleTripAssent_NFuel");

                entity.HasOne(d => d.FuelType)
                    .WithMany(p => p.MvehicleTripAssent)
                    .HasForeignKey(d => d.FuelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicleTripAssent_SFuelType");

                entity.HasOne(d => d.Locality)
                    .WithMany(p => p.MvehicleTripAssent)
                    .HasForeignKey(d => d.LocalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicleTripAssent_SLocality");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.MvehicleTripAssent)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicleTripAssent_SOffice");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.MvehicleTripAssent)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicleTripAssent_MProfile");

                entity.HasOne(d => d.ProfileType)
                    .WithMany(p => p.MvehicleTripAssent)
                    .HasForeignKey(d => d.ProfileTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicleTripAssent_SProfileType");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.MvehicleTripAssent)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicleTripAssent_NState");

                entity.HasOne(d => d.Station)
                    .WithMany(p => p.MvehicleTripAssent)
                    .HasForeignKey(d => d.StationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicleTripAssent_SStation");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MvehicleTripAssent)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicleTripAssent_SStatus");

                entity.HasOne(d => d.VehicleAgent)
                    .WithMany(p => p.MvehicleTripAssent)
                    .HasForeignKey(d => d.VehicleAgentId)
                    .HasConstraintName("FK_MVehicleTripAssent_NFacilityAgent");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.MvehicleTripAssent)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MVehicleTripAssent_MVehicle");
            });

            modelBuilder.Entity<Ncompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("PK_SCompany");

                entity.ToTable("NCompany");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Nfacility>(entity =>
            {
                entity.HasKey(e => e.FacilityId)
                    .HasName("PK_Facility");

                entity.ToTable("NFacility");

                entity.Property(e => e.FacilityId).HasColumnName("FacilityID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ActivityWeighte).HasDefaultValueSql("((1))");

                entity.Property(e => e.FacilityName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Nfacility)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Facility_NSection");
            });

            modelBuilder.Entity<NfacilityAgent>(entity =>
            {
                entity.HasKey(e => e.FacilityAgentId);

                entity.ToTable("NFacilityAgent");

                entity.Property(e => e.FacilityAgentId).HasColumnName("FacilityAgentID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(50);

                entity.Property(e => e.FacilityAgentName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdissueDate)
                    .HasColumnName("IDIssueDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Idnumber)
                    .IsRequired()
                    .HasColumnName("IDNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.IdtypeId).HasColumnName("IDTypeID");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Idtype)
                    .WithMany(p => p.NfacilityAgent)
                    .HasForeignKey(d => d.IdtypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFacilityAgent_SIDType");
            });

            modelBuilder.Entity<Nfuel>(entity =>
            {
                entity.HasKey(e => e.FuelId)
                    .HasName("PK_SFuelType");

                entity.ToTable("NFuel");

                entity.Property(e => e.FuelId).HasColumnName("FuelID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FuelName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Nsection>(entity =>
            {
                entity.HasKey(e => e.SectionId)
                    .HasName("PK_SSection");

                entity.ToTable("NSection");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<NsiteSurvey>(entity =>
            {
                entity.HasKey(e => new { e.UserName, e.MachineId, e.SurveyDate });

                entity.ToTable("NSiteSurvey");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.SurveyDate).HasColumnType("date");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Note).HasMaxLength(50);

                entity.Property(e => e.ProfileFacilityId).HasColumnName("ProfileFacilityID");

                entity.Property(e => e.RejectId).HasColumnName("RejectID");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.NsiteSurvey)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("FK_NSiteSurvey_MMachine");

                entity.HasOne(d => d.Reject)
                    .WithMany(p => p.NsiteSurvey)
                    .HasForeignKey(d => d.RejectId)
                    .HasConstraintName("FK_NSiteSurvey_SReject");
            });

            modelBuilder.Entity<Nstate>(entity =>
            {
                entity.HasKey(e => e.StateId)
                    .HasName("PK_SState");

                entity.ToTable("NState");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<NtripConfig>(entity =>
            {
                entity.HasKey(e => e.TripId)
                    .HasName("PK_NTrip");

                entity.ToTable("NTripConfig");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ApprovedFuel).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RoadTypeId).HasColumnName("RoadTypeID");

                entity.Property(e => e.TripLfrom).HasColumnName("TripLFrom");

                entity.Property(e => e.TripLto).HasColumnName("TripLTo");

                entity.Property(e => e.VehicleTypeId).HasColumnName("VehicleTypeID");

                entity.HasOne(d => d.RoadType)
                    .WithMany(p => p.NtripConfig)
                    .HasForeignKey(d => d.RoadTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NTripConfig_SRoadType");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.NtripConfig)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NTripConfig_SVehicleType");
            });

            modelBuilder.Entity<NwareHouse>(entity =>
            {
                entity.HasKey(e => e.WareHouseId)
                    .HasName("PK_SWareHouse");

                entity.ToTable("NWareHouse");

                entity.Property(e => e.WareHouseId).HasColumnName("WareHouseID");

                entity.Property(e => e.LocalityId).HasColumnName("LocalityID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.WareHouseName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Locality)
                    .WithMany(p => p.NwareHouse)
                    .HasForeignKey(d => d.LocalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SWareHouse_SLocality");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.NwareHouse)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SWareHouse_SState");
            });

            modelBuilder.Entity<SactionType>(entity =>
            {
                entity.HasKey(e => e.ActionTypeId)
                    .HasName("PK_SAction");

                entity.ToTable("SActionType");

                entity.Property(e => e.ActionTypeId)
                    .HasColumnName("ActionTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActionTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ScarLetter>(entity =>
            {
                entity.HasKey(e => e.LetterId)
                    .HasName("PK_carLetters");

                entity.ToTable("SCarLetter");

                entity.Property(e => e.LetterId).HasColumnName("LetterID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.LetterChar)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StateId)
                    .HasColumnName("StateID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.ScarLetter)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SCarLetter_NState");
            });

            modelBuilder.Entity<Sconsumption>(entity =>
            {
                entity.HasKey(e => e.ConsumptionId);

                entity.ToTable("SConsumption");

                entity.Property(e => e.ConsumptionId).HasColumnName("ConsumptionID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ConsumptionGh)
                    .HasColumnName("ConsumptionGH")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ConsumptionHp)
                    .HasColumnName("ConsumptionHP")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ConsumptionKva)
                    .HasColumnName("ConsumptionKVA")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ConsumptionKw)
                    .HasColumnName("ConsumptionKW")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ConsumptionLh)
                    .HasColumnName("ConsumptionLH")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Scountry>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("SCountry");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SfuelType>(entity =>
            {
                entity.HasKey(e => e.FuelTypeId)
                    .HasName("PK_SFuelType_1");

                entity.ToTable("SFuelType");

                entity.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FuelTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Sidtype>(entity =>
            {
                entity.HasKey(e => e.IdtypeId);

                entity.ToTable("SIDType");

                entity.Property(e => e.IdtypeId).HasColumnName("IDTypeID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Idmask)
                    .IsRequired()
                    .HasColumnName("IDMask")
                    .HasMaxLength(30);

                entity.Property(e => e.IdtypeName)
                    .IsRequired()
                    .HasColumnName("IDTypeName")
                    .HasMaxLength(100);

                entity.Property(e => e.ProfileTypeId).HasColumnName("ProfileTypeID");

                entity.HasOne(d => d.ProfileType)
                    .WithMany(p => p.Sidtype)
                    .HasForeignKey(d => d.ProfileTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIDType_SProfileType");
            });

            modelBuilder.Entity<Sjob>(entity =>
            {
                entity.HasKey(e => e.JobId);

                entity.ToTable("SJob");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProfileTypeId).HasColumnName("ProfileTypeID");

                entity.HasOne(d => d.ProfileType)
                    .WithMany(p => p.Sjob)
                    .HasForeignKey(d => d.ProfileTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SJob_SProfileType");
            });

            modelBuilder.Entity<Slocality>(entity =>
            {
                entity.HasKey(e => e.LocalityId);

                entity.ToTable("SLocality");

                entity.Property(e => e.LocalityId).HasColumnName("LocalityID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LocalityName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Slocality)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SLocality_SState");
            });

            modelBuilder.Entity<SmachineAttachmentType>(entity =>
            {
                entity.HasKey(e => e.AttachmentTypeId);

                entity.ToTable("SMachineAttachmentType");

                entity.Property(e => e.AttachmentTypeId).HasColumnName("AttachmentTypeID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AttachmentTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FacilityId).HasColumnName("FacilityID");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.SmachineAttachmentType)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SMachineAttachmentType_NFacility");
            });

            modelBuilder.Entity<SmachineMark>(entity =>
            {
                entity.HasKey(e => e.MarkId)
                    .HasName("PK_SMark");

                entity.ToTable("SMachineMark");

                entity.Property(e => e.MarkId).HasColumnName("MarkID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MarkName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MarkNameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SmachineModel>(entity =>
            {
                entity.HasKey(e => e.ModelId)
                    .HasName("PK_SModel");

                entity.ToTable("SMachineModel");

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MarkId).HasColumnName("MarkID");

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Mark)
                    .WithMany(p => p.SmachineModel)
                    .HasForeignKey(d => d.MarkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SModel_SMark");
            });

            modelBuilder.Entity<SmachineType>(entity =>
            {
                entity.HasKey(e => e.MachineTypeId);

                entity.ToTable("SMachineType");

                entity.Property(e => e.MachineTypeId).HasColumnName("MachineTypeID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MachineTypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.SmachineType)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SMachineType_SSection");
            });

            modelBuilder.Entity<Soffice>(entity =>
            {
                entity.HasKey(e => e.OfficeId);

                entity.ToTable("SOffice");

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LocalityId).HasColumnName("LocalityID");

                entity.Property(e => e.OfficeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.Locality)
                    .WithMany(p => p.Soffice)
                    .HasForeignKey(d => d.LocalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SOffice_SLocality");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Soffice)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SOffice_NState");
            });

            modelBuilder.Entity<SprofileAttachmentType>(entity =>
            {
                entity.HasKey(e => e.AttachmentTypeId)
                    .HasName("PK_SAttachmentType");

                entity.ToTable("SProfileAttachmentType");

                entity.Property(e => e.AttachmentTypeId).HasColumnName("AttachmentTypeID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AttachmentTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProfileTypeId).HasColumnName("ProfileTypeID");

                entity.HasOne(d => d.ProfileType)
                    .WithMany(p => p.SprofileAttachmentType)
                    .HasForeignKey(d => d.ProfileTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SAttachmentType_SProfileType");
            });

            modelBuilder.Entity<SprofileFacilityAttachmentTypes>(entity =>
            {
                entity.HasKey(e => e.AttachmentTypeId);

                entity.ToTable("SProfileFacilityAttachmentTypes");

                entity.Property(e => e.AttachmentTypeId).HasColumnName("AttachmentTypeID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AttachmentTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.SprofileFacilityAttachmentTypes)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SProfileFacilityAttachmentTypes_NFacility");
            });

            modelBuilder.Entity<SprofileType>(entity =>
            {
                entity.HasKey(e => e.ProfileTypeId);

                entity.ToTable("SProfileType");

                entity.Property(e => e.ProfileTypeId).HasColumnName("ProfileTypeID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProfileTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Sreject>(entity =>
            {
                entity.HasKey(e => e.RejectId);

                entity.ToTable("SReject");

                entity.Property(e => e.RejectId).HasColumnName("RejectID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RejectName).IsRequired();
            });

            modelBuilder.Entity<SroadType>(entity =>
            {
                entity.HasKey(e => e.RoadTypeId);

                entity.ToTable("SRoadType");

                entity.Property(e => e.RoadTypeId)
                    .HasColumnName("RoadTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RoadTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Sstation>(entity =>
            {
                entity.HasKey(e => e.StationId);

                entity.ToTable("SStation");

                entity.Property(e => e.StationId).HasColumnName("StationID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.LocalityId).HasColumnName("LocalityID");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.StationName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserAdded)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserUpdate).HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Sstation)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SStation_SCompany");

                entity.HasOne(d => d.Locality)
                    .WithMany(p => p.Sstation)
                    .HasForeignKey(d => d.LocalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SStation_SLocality");
            });

            modelBuilder.Entity<SstationType>(entity =>
            {
                entity.HasKey(e => e.StationTypeId);

                entity.ToTable("SStationType");

                entity.Property(e => e.StationTypeId).HasColumnName("StationTypeID");

                entity.Property(e => e.StationTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Sstatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("SStatus");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StatusDescription)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SstatusAssent>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("SStatusAssent");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StatusDescription)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<StripAuth>(entity =>
            {
                entity.HasKey(e => e.TripAuthId);

                entity.ToTable("STripAuth");

                entity.Property(e => e.TripAuthId).HasColumnName("TripAuthID");

                entity.Property(e => e.TripAuthName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<StripAuthProvider>(entity =>
            {
                entity.HasKey(e => e.TripAuthProviderId)
                    .HasName("PK_TripAuthProvider");

                entity.ToTable("STripAuthProvider");

                entity.Property(e => e.TripAuthProviderId).HasColumnName("TripAuthProviderID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.TripAuthProviderName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SuserLocality>(entity =>
            {
                entity.HasKey(e => new { e.UserName, e.LocalityId });

                entity.ToTable("SUserLocality");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.LocalityId).HasColumnName("LocalityID");

                entity.HasOne(d => d.Locality)
                    .WithMany(p => p.SuserLocality)
                    .HasForeignKey(d => d.LocalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SUserLocality_SLocality");
            });

            modelBuilder.Entity<SvehicleAttachmentType>(entity =>
            {
                entity.HasKey(e => e.AttachmentTypeId);

                entity.ToTable("SVehicleAttachmentType");

                entity.Property(e => e.AttachmentTypeId).HasColumnName("AttachmentTypeID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AttachmentTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProfileTypeId).HasColumnName("ProfileTypeID");

                entity.HasOne(d => d.ProfileType)
                    .WithMany(p => p.SvehicleAttachmentType)
                    .HasForeignKey(d => d.ProfileTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SVehicleAttachmentType_SProfileType");
            });

            modelBuilder.Entity<SvehicleMark>(entity =>
            {
                entity.HasKey(e => e.MarkId);

                entity.ToTable("SVehicleMark");

                entity.Property(e => e.MarkId).HasColumnName("MarkID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MarkName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MarkNameEn)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SvehicleModel>(entity =>
            {
                entity.HasKey(e => e.ModelId);

                entity.ToTable("SVehicleModel");

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MarkId).HasColumnName("MarkID");

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Mark)
                    .WithMany(p => p.SvehicleModel)
                    .HasForeignKey(d => d.MarkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SVehicleModel_SVehicleMark");
            });

            modelBuilder.Entity<SvehicleType>(entity =>
            {
                entity.HasKey(e => e.VehicleTypeId)
                    .HasName("PK_SVechileType");

                entity.ToTable("SVehicleType");

                entity.Property(e => e.VehicleTypeId).HasColumnName("VehicleTypeID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.VehicleTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TfacilityMachineUse>(entity =>
            {
                entity.HasKey(e => new { e.FacilityId, e.MachineTypeId });

                entity.ToTable("TFacilityMachineUse");

                entity.Property(e => e.FacilityId).HasColumnName("FacilityID");

                entity.Property(e => e.MachineTypeId).HasColumnName("MachineTypeID");

                entity.Property(e => e.MonthlyUse)
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.TfacilityMachineUse)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TFacilityMachineUse_NFacility");

                entity.HasOne(d => d.MachineType)
                    .WithMany(p => p.TfacilityMachineUse)
                    .HasForeignKey(d => d.MachineTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TFacilityMachineUse_SMachineType");
            });

            modelBuilder.Entity<TfacilityVehicleUse>(entity =>
            {
                entity.HasKey(e => new { e.FacilityId, e.VehicleTypeId });

                entity.ToTable("TFacilityVehicleUse");

                entity.Property(e => e.FacilityId).HasColumnName("FacilityID");

                entity.Property(e => e.VehicleTypeId).HasColumnName("VehicleTypeID");

                entity.Property(e => e.MonthlyUse)
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.TfacilityVehicleUse)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TFacilityVehicleUse_NFacility");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.TfacilityVehicleUse)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TFacilityVehicleUse_SVehicleType");
            });

            modelBuilder.Entity<TfuelTypeStation>(entity =>
            {
                entity.HasKey(e => new { e.StationId, e.FuelId, e.FuelTypeId });

                entity.ToTable("TFuelTypeStation");

                entity.Property(e => e.StationId).HasColumnName("StationID");

                entity.Property(e => e.FuelId).HasColumnName("FuelID");

                entity.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");

                entity.Property(e => e.TankCapacity).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Fuel)
                    .WithMany(p => p.TfuelTypeStation)
                    .HasForeignKey(d => d.FuelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TFuelTypeStation_NFuel");

                entity.HasOne(d => d.FuelType)
                    .WithMany(p => p.TfuelTypeStation)
                    .HasForeignKey(d => d.FuelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TFuelTypeStation_SFuelType");

                entity.HasOne(d => d.Station)
                    .WithMany(p => p.TfuelTypeStation)
                    .HasForeignKey(d => d.StationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TFuelTypeStation_SStation");
            });

            modelBuilder.Entity<TfuelTypeWareHouse>(entity =>
            {
                entity.HasKey(e => new { e.WareHouseId, e.FuelTypeId })
                    .HasName("PK_TWareHouseFuelType");

                entity.ToTable("TFuelTypeWareHouse");

                entity.Property(e => e.WareHouseId).HasColumnName("WareHouseID");

                entity.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");

                entity.Property(e => e.TankCapacity).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.FuelType)
                    .WithMany(p => p.TfuelTypeWareHouse)
                    .HasForeignKey(d => d.FuelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TFuelTypeWareHouse_SFuelType");

                entity.HasOne(d => d.WareHouse)
                    .WithMany(p => p.TfuelTypeWareHouse)
                    .HasForeignKey(d => d.WareHouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TFuelTypeWareHouse_NWareHouse");
            });

            modelBuilder.Entity<TonRoadQuota>(entity =>
            {
                entity.HasKey(e => new { e.StationId, e.FuelId, e.FuelTypeId, e.Date });

                entity.ToTable("TOnRoadQuota");

                entity.Property(e => e.StationId).HasColumnName("StationID");

                entity.Property(e => e.FuelId).HasColumnName("FuelID");

                entity.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserAdded).HasMaxLength(50);
            });

            modelBuilder.Entity<Tquota>(entity =>
            {
                entity.HasKey(e => new { e.FuelTypeId, e.Date });

                entity.ToTable("TQuota");

                entity.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UserAdded)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.FuelType)
                    .WithMany(p => p.Tquota)
                    .HasForeignKey(d => d.FuelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TQuota_SFuelType");
            });

            modelBuilder.Entity<TquotaCompany>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.WareHouseId, e.FuelTypeId, e.Date });

                entity.ToTable("TQuotaCompany");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.WareHouseId).HasColumnName("WareHouseID");

                entity.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UserAdded)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TquotaCompany)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TQuotaCompany_NCompany");

                entity.HasOne(d => d.FuelType)
                    .WithMany(p => p.TquotaCompany)
                    .HasForeignKey(d => d.FuelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TQuotaCompany_SFuelType");

                entity.HasOne(d => d.WareHouse)
                    .WithMany(p => p.TquotaCompany)
                    .HasForeignKey(d => d.WareHouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TQuotaCompany_NWareHouse");
            });

            modelBuilder.Entity<TquotaState>(entity =>
            {
                entity.HasKey(e => new { e.StateId, e.WareHouseId, e.FuelId, e.FuelTypeId, e.Date });

                entity.ToTable("TQuotaState");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.WareHouseId).HasColumnName("WareHouseID");

                entity.Property(e => e.FuelId).HasColumnName("FuelID");

                entity.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UserAdded)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Fuel)
                    .WithMany(p => p.TquotaState)
                    .HasForeignKey(d => d.FuelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TQuotaState_NFuel");

                entity.HasOne(d => d.FuelType)
                    .WithMany(p => p.TquotaState)
                    .HasForeignKey(d => d.FuelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TQuotaState_SFuelType");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.TquotaState)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TQuotaState_NState");

                entity.HasOne(d => d.WareHouse)
                    .WithMany(p => p.TquotaState)
                    .HasForeignKey(d => d.WareHouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TQuotaState_NWareHouse");
            });

            modelBuilder.Entity<TquotaStation>(entity =>
            {
                entity.HasKey(e => new { e.StationId, e.WareHouseId, e.FuelTypeId, e.Date });

                entity.ToTable("TQuotaStation");

                entity.Property(e => e.StationId).HasColumnName("StationID");

                entity.Property(e => e.WareHouseId).HasColumnName("WareHouseID");

                entity.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UserAdded)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TquotaStation)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TQuotaStation_SCompany");

                entity.HasOne(d => d.FuelType)
                    .WithMany(p => p.TquotaStation)
                    .HasForeignKey(d => d.FuelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TQuotaStation_SFuelType");

                entity.HasOne(d => d.Station)
                    .WithMany(p => p.TquotaStation)
                    .HasForeignKey(d => d.StationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TQuotaStation_SStation");

                entity.HasOne(d => d.WareHouse)
                    .WithMany(p => p.TquotaStation)
                    .HasForeignKey(d => d.WareHouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TQuotaStation_SWareHouse");
            });

            modelBuilder.Entity<TquotaWareHouse>(entity =>
            {
                entity.HasKey(e => new { e.WareHouseId, e.FuelTypeId, e.Date });

                entity.ToTable("TQuotaWareHouse");

                entity.Property(e => e.WareHouseId).HasColumnName("WareHouseID");

                entity.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UserAdded)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.FuelType)
                    .WithMany(p => p.TquotaWareHouse)
                    .HasForeignKey(d => d.FuelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TQuotaWareHouse_SFuelType");

                entity.HasOne(d => d.WareHouse)
                    .WithMany(p => p.TquotaWareHouse)
                    .HasForeignKey(d => d.WareHouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TQuotaWareHouse_NWareHouse");
            });

            modelBuilder.Entity<TstationQuota>(entity =>
            {
                entity.HasKey(e => new { e.StationId, e.FuelId, e.FuelTypeId, e.Date });

                entity.ToTable("TStationQuota");

                entity.Property(e => e.StationId).HasColumnName("StationID");

                entity.Property(e => e.FuelId).HasColumnName("FuelID");

                entity.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemWithdraw).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAssent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalWithdraw).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserAdded)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Fuel)
                    .WithMany(p => p.TstationQuota)
                    .HasForeignKey(d => d.FuelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TStationQuota_NFuel");

                entity.HasOne(d => d.FuelType)
                    .WithMany(p => p.TstationQuota)
                    .HasForeignKey(d => d.FuelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TStationQuota_SFuelType");

                entity.HasOne(d => d.Station)
                    .WithMany(p => p.TstationQuota)
                    .HasForeignKey(d => d.StationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TStationQuota_SStation");
            });

            modelBuilder.Entity<TstationType>(entity =>
            {
                entity.HasKey(e => new { e.StationId, e.StationTypeId });

                entity.ToTable("TStationType");

                entity.Property(e => e.StationId).HasColumnName("StationID");

                entity.Property(e => e.StationTypeId).HasColumnName("StationTypeID");

                entity.HasOne(d => d.Station)
                    .WithMany(p => p.TstationType)
                    .HasForeignKey(d => d.StationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TStationType_SStation");

                entity.HasOne(d => d.StationType)
                    .WithMany(p => p.TstationType)
                    .HasForeignKey(d => d.StationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TStationType_SStationType");
            });

            modelBuilder.Entity<ZandroidSettings>(entity =>
            {
                entity.HasKey(e => e.AndroidVersion);

                entity.ToTable("ZAndroidSettings");

                entity.Property(e => e.AndroidVersion)
                    .HasColumnType("decimal(3, 2)")
                    .HasDefaultValueSql("((1.00))");
            });

            modelBuilder.Entity<ZappUser>(entity =>
            {
                entity.HasKey(e => e.Imei);

                entity.ToTable("ZAppUser");

                entity.Property(e => e.Imei)
                    .HasColumnName("IMEI")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Token).IsRequired();
            });

            modelBuilder.Entity<ZcheckPoint>(entity =>
            {
                entity.HasKey(e => new { e.AssentId, e.CheckDate })
                    .HasName("PK_RCheckPoint");

                entity.ToTable("ZCheckPoint");

                entity.Property(e => e.AssentId).HasColumnName("AssentID");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StopStationId).HasColumnName("StopStationID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            });
        }
    }
}
