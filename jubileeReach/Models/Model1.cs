namespace jubileeReach.Views
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=jubileeReachDB")
        {
        }

        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<ACCOUNT> ACCOUNTS { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<CATEGORY> CATEGORies { get; set; }
        public virtual DbSet<COLOR> COLORS { get; set; }
        public virtual DbSet<demoTable> demoTables { get; set; }
        public virtual DbSet<DEP_LINKER> DEP_LINKER { get; set; }
        public virtual DbSet<DEPARTMENT> DEPARTMENTs { get; set; }
        public virtual DbSet<IMAGE> IMAGES { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<PRODUCT> PRODUCTs { get; set; }
        public virtual DbSet<PURCHASE_ORDER> PURCHASE_ORDER { get; set; }
        public virtual DbSet<PURCHASEDEMO> PURCHASEDEMOes { get; set; }
        public virtual DbSet<QUALITY> QUALITies { get; set; }
        public virtual DbSet<SIZE_GROUP> SIZE_GROUP { get; set; }
        public virtual DbSet<SIZE> SIZES { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.FIRST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.LAST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.USER_PASS)
                .IsUnicode(false);

            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetRoleClaims)
                .WithRequired(e => e.AspNetRole)
                .HasForeignKey(e => e.RoleId);

            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<CATEGORY>()
                .Property(e => e.CAT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<COLOR>()
                .Property(e => e.COLOR_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<demoTable>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<demoTable>()
                .Property(e => e.Tag_color)
                .IsUnicode(false);

            modelBuilder.Entity<demoTable>()
                .Property(e => e.color)
                .IsUnicode(false);

            modelBuilder.Entity<demoTable>()
                .Property(e => e.department)
                .IsUnicode(false);

            modelBuilder.Entity<demoTable>()
                .Property(e => e.brand)
                .IsUnicode(false);

            modelBuilder.Entity<demoTable>()
                .Property(e => e.retail_price)
                .HasPrecision(19, 2);

            modelBuilder.Entity<demoTable>()
                .Property(e => e.item_description)
                .IsUnicode(false);

            modelBuilder.Entity<demoTable>()
                .Property(e => e.sale_price)
                .HasPrecision(19, 2);

            modelBuilder.Entity<demoTable>()
                .Property(e => e.quality)
                .IsUnicode(false);

            modelBuilder.Entity<demoTable>()
                .Property(e => e.size)
                .IsUnicode(false);

            modelBuilder.Entity<DEP_LINKER>()
                .HasMany(e => e.CATEGORies)
                .WithRequired(e => e.DEP_LINKER1)
                .HasForeignKey(e => e.DEP_LINKER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DEPARTMENT>()
                .Property(e => e.DEPARTMENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTMENT>()
                .HasMany(e => e.DEP_LINKER)
                .WithRequired(e => e.DEPARTMENT)
                .HasForeignKey(e => e.DEP_NUM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IMAGE>()
                .HasMany(e => e.PRODUCTs)
                .WithOptional(e => e.IMAGE)
                .HasForeignKey(e => e.IMG_ID);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.ITEM_DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.BRAND)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.RETAIL_PRICE)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.SALE_PRICE)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PURCHASE_ORDER>()
                .Property(e => e.ITEM_DESRIPRION)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE_ORDER>()
                .Property(e => e.PRICE)
                .HasPrecision(19, 2);

            modelBuilder.Entity<PURCHASEDEMO>()
                .Property(e => e.FIRST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASEDEMO>()
                .Property(e => e.LAST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASEDEMO>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASEDEMO>()
                .Property(e => e.PICK_UP_TIME)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASEDEMO>()
                .Property(e => e.PHONENUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<QUALITY>()
                .Property(e => e.QUALITY1)
                .IsUnicode(false);

            modelBuilder.Entity<SIZE_GROUP>()
                .HasMany(e => e.CATEGORies)
                .WithRequired(e => e.SIZE_GROUP1)
                .HasForeignKey(e => e.SIZE_GROUP);

            modelBuilder.Entity<SIZE_GROUP>()
                .HasMany(e => e.SIZES)
                .WithOptional(e => e.SIZE_GROUP1)
                .HasForeignKey(e => e.SIZE_GROUP);

            modelBuilder.Entity<SIZE>()
                .Property(e => e.SIZE1)
                .IsUnicode(false);

            modelBuilder.Entity<Picture>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Picture>()
                .Property(e => e.brand)
                .IsUnicode(false);

            modelBuilder.Entity<Picture>()
                .Property(e => e.price)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Picture>()
                .Property(e => e.size)
                .IsUnicode(false);

            modelBuilder.Entity<Picture>()
                .Property(e => e.category)
                .IsUnicode(false);

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.start_ip_address)
                .IsUnicode(false);

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.end_ip_address)
                .IsUnicode(false);
        }
    }
}
