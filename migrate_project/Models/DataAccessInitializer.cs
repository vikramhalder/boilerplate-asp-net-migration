using System.Data.Entity;

namespace migrate_project.Models
{ 
    public class DataAccessInitializer : CreateDatabaseIfNotExists<DataAccess>
    {
        protected override void Seed(DataAccess context)
        {
            base.Seed(context);
        }
    }
}