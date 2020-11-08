using Microsoft.EntityFrameworkCore;
using ParsedData.Models;

namespace ParsedData.DAL
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }
        public DbSet<User> Users { get; set;}
        public DbSet<TaskData> TaskDatas { get; set;} 
    }
}