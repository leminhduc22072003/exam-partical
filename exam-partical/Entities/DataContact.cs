using System;
using Microsoft.EntityFrameworkCore;


namespace exam_partical.Entities
{
    public class DataContact : DbContext
    {
        public DataContact(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}