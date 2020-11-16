using System;
using Microsoft.EntityFrameworkCore;
using ParsedData.Models;

namespace ParsedData.DAL
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { 
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set;}
        public DbSet<TaskData> TaskDatas { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

             modelBuilder.Entity<TaskData>()
                   .HasOne(m => m.TaskManagerUser)
                   .WithMany(t => t.ManagerTaskDatas)
                   .HasForeignKey(m => m.TaskManagerUserId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TaskData>()
                   .HasOne(m => m.ExecutorUser)
                   .WithMany(t => t.ExecutorTaskDatas)
                   .HasForeignKey(m => m.ExecutorUserId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>().HasData(
                new User [] {
                    new User { UserId = 1, Sername = "Ivanov", Name = "Ivan", CreateDate =  new DateTime(2020, 01, 01), LastUpdate = new DateTime(2020, 01, 01), UserStateId = 1 },
                    new User { UserId = 2, Sername = "Vasya", Name = "Vasiliy", CreateDate =  new DateTime(2020, 02, 25), LastUpdate = new DateTime(2020, 02, 25), UserStateId = 1 },
                    new User { UserId = 3, Sername = "Nikolya", Name = "Nekrasov", CreateDate =  new DateTime(2020, 05, 11), LastUpdate = new DateTime(2020, 05, 25), UserStateId = 1 },
                    new User { UserId = 4, Sername = "Дмитрий", Name = "Кисилёв", CreateDate =  new DateTime(2020, 07, 16), LastUpdate = new DateTime(2020, 07, 26), UserStateId = 1 },
                    new User { UserId = 5, Sername = "Юрий", Name = "Нагиев", CreateDate =  new DateTime(2020, 01, 21), LastUpdate = new DateTime(2020, 01, 22), UserStateId = 1 }
                }               
                );
            modelBuilder.Entity<TaskData>().HasData(
                new TaskData [] {
                    new TaskData {  TaskId = 1, Name = "Samsung Galaxy S2", Description = "Smartphone 16GB", CreateDate = new DateTime(2019, 09, 21), LastUpdate = new DateTime(2019, 09, 21), TaskStateId = 3, TaskManagerUserId = 1, ExecutorUserId = 1 },
                    new TaskData {  TaskId = 2, Name = "Samsung Galaxy S3", Description = "Smartphone 32GB", CreateDate = new DateTime(2019, 10, 21), LastUpdate = new DateTime(2019, 10, 21), TaskStateId = 3, TaskManagerUserId = 1, ExecutorUserId = 1  },
                    new TaskData {  TaskId = 3, Name = "Samsung Galaxy S4", Description = "Smartphone 64GB", CreateDate = new DateTime(2019, 11, 11), LastUpdate = new DateTime(2019, 11, 11), TaskStateId = 3, TaskManagerUserId = 1, ExecutorUserId = 1  },
                    new TaskData {  TaskId = 4, Name = "Samsung Galaxy S5", Description = "Smartphone 128GB", CreateDate = new DateTime(2019, 01, 01), LastUpdate = new DateTime(2019, 01, 01), TaskStateId = 3, TaskManagerUserId = 1, ExecutorUserId = 1  },
                    new TaskData {  TaskId = 5, Name = "Samsung Galaxy S6", Description = "Smartphone 128GB", CreateDate = new DateTime(2019, 02, 02), LastUpdate = new DateTime(2019, 02, 02), TaskStateId = 3, TaskManagerUserId = 1, ExecutorUserId = 1 },
                    new TaskData {  TaskId = 6, Name = "Samsung Galaxy S7", Description = "Smartphone 128GB", CreateDate = new DateTime(2019, 02, 05), LastUpdate = new DateTime(2019, 02, 05), TaskStateId = 3, TaskManagerUserId = 1, ExecutorUserId = 1 },
                    new TaskData {  TaskId = 7, Name = "Samsung Galaxy S8", Description = "Smartphone 64GB", CreateDate = new DateTime(2019, 09, 21), LastUpdate = new DateTime(2019, 09, 21), TaskStateId = 3,  TaskManagerUserId = 1, ExecutorUserId = 1 },
                    new TaskData {  TaskId = 8, Name = "Samsung Galaxy S9", Description = "Smartphone 32GB White", CreateDate = new DateTime(2019, 10, 21), LastUpdate = new DateTime(2019, 10, 21), TaskStateId = 3,  TaskManagerUserId = 1, ExecutorUserId = 1  },
                    new TaskData {  TaskId = 9, Name = "Samsung Galaxy S10", Description = "Smartphone 64GB Red", CreateDate = new DateTime(2019, 11, 11), LastUpdate = new DateTime(2019, 11, 11), TaskStateId = 3,  TaskManagerUserId = 1, ExecutorUserId = 1  },
                    new TaskData {  TaskId = 10, Name = "Samsung Galaxy S11", Description = "Smartphone 128GB Ultra", CreateDate = new DateTime(2019, 12, 20), LastUpdate = new DateTime(2019, 12, 28), TaskStateId = 3,  TaskManagerUserId = 1, ExecutorUserId = 1  },
                    new TaskData {  TaskId = 11, Name = "Samsung Galaxy S20", Description = "Smartphone 128GB black", CreateDate = new DateTime(2019, 08, 16), LastUpdate = new DateTime(2019, 08, 19), TaskStateId = 3,  TaskManagerUserId = 1, ExecutorUserId = 1  },
                    new TaskData {  TaskId = 12, Name = "Samsung Galaxy S21", Description = "Smartphone 128GB light", CreateDate = new DateTime(2019, 05, 27), LastUpdate = new DateTime(2019, 05, 27), TaskStateId = 3, TaskManagerUserId = 1, ExecutorUserId = 1  },
                    new TaskData {  TaskId = 13, Name = "Xiaomi Note plus 2", Description = "Xiaomi Note plus 16GB", CreateDate = new DateTime(2019, 09, 21), LastUpdate = new DateTime(2019, 09, 21), TaskStateId = 3,  TaskManagerUserId = 1, ExecutorUserId = 1  },
                    new TaskData {  TaskId = 14, Name = "Xiaomi Note plus 3", Description = "Xiaomi Note plus 16GB", CreateDate = new DateTime(2019, 10, 21), LastUpdate = new DateTime(2019, 10, 21), TaskStateId = 3,  TaskManagerUserId = 1, ExecutorUserId = 1 },
                    new TaskData {  TaskId = 15, Name = "Xiaomi Note plus 4", Description = "Xiaomi Note plus 16GB", CreateDate = new DateTime(2019, 11, 11), LastUpdate = new DateTime(2019, 11, 11), TaskStateId = 3,  TaskManagerUserId = 1, ExecutorUserId = 1  },
                    new TaskData {  TaskId = 16, Name = "Xiaomi Note plus 5", Description = "Xiaomi Note plus 128GB", CreateDate = new DateTime(2019, 01, 01), LastUpdate = new DateTime(2019, 01, 01), TaskStateId = 3, TaskManagerUserId = 1, ExecutorUserId = 1  },
                    new TaskData {  TaskId = 17, Name = "Xiaomi Note plus 6", Description = "Xiaomi Note plus 128GB", CreateDate = new DateTime(2019, 02, 06), LastUpdate = new DateTime(2019, 02, 02), TaskStateId = 3, TaskManagerUserId = 1, ExecutorUserId = 1 },
                    new TaskData {  TaskId = 18, Name = "Xiaomi Note plus 7", Description = "Xiaomi Note plus 128GB", CreateDate = new DateTime(2019, 02, 06), LastUpdate = new DateTime(2019, 02, 06), TaskStateId = 3,  TaskManagerUserId = 1, ExecutorUserId = 1 },
                    new TaskData {  TaskId = 19, Name = "Xiaomi Note plus 8", Description = "Xiaomi Note plus 64GB", CreateDate = new DateTime(2019, 09, 19), LastUpdate = new DateTime(2019, 09, 18), TaskStateId = 3,  TaskManagerUserId = 1, ExecutorUserId = 1  },
                    new TaskData {  TaskId = 20, Name = "Xiaomi Note plus 9", Description = "Xiaomi Note plus 32GB White", CreateDate = new DateTime(2019, 10, 14), LastUpdate = new DateTime(2019, 10, 12), TaskStateId = 3, TaskManagerUserId = 1, ExecutorUserId = 1 },
                    new TaskData {  TaskId = 21, Name = "Xiaomi Note plus 10", Description = "Xiaomi Note plus 64GB Red", CreateDate = new DateTime(2019, 11, 13), LastUpdate = new DateTime(2019, 11, 11), TaskStateId = 3, TaskManagerUserId = 1, ExecutorUserId = 1 },
                    new TaskData {  TaskId = 22, Name = "Xiaomi Note plus 11", Description = "Xiaomi Note plus 128GB Ultra", CreateDate = new DateTime(2019, 12, 24), LastUpdate = new DateTime(2019, 12, 24), TaskStateId = 3, TaskManagerUserId = 1, ExecutorUserId = 1  },
                    new TaskData {  TaskId = 23, Name = "Xiaomi Note plus 12", Description = "Xiaomi Note plus 128GB black", CreateDate = new DateTime(2019, 08, 17), LastUpdate = new DateTime(2019, 08, 16), TaskStateId = 3, TaskManagerUserId = 1, ExecutorUserId = 1  },
                    new TaskData {  TaskId = 24, Name = "Xiaomi Note plus 13", Description = "Xiaomi Note plus 128GB light", CreateDate = new DateTime(2019, 05, 29), LastUpdate = new DateTime(2019, 05, 27), TaskStateId = 3, TaskManagerUserId = 1, ExecutorUserId = 1  }
                }
            );
        } 
    }
}