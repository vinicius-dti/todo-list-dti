﻿using Microsoft.EntityFrameworkCore;

namespace DTITodoList.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext()
        {
            
        }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) 
        {

        }

        public DbSet<TaskModel> Tasks { get; set; }
    }
}
