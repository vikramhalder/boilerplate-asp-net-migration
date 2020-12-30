namespace migrate_project.Models
{
    using Entity;
    using System.Data.Entity;

    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public partial class DataAccess : DbContext
    {
        public DataAccess() : base("name=DataAccess")
        {
            Database.SetInitializer<DataAccess>(new DataAccessInitializer());
        }

        public virtual DbSet<Person> persons { get; set; } 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}