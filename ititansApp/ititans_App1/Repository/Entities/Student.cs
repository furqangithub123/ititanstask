using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ititans_App1
{

    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Class { get; set; } // New property
    }

    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(b => b.Age).HasDefaultValue(5);
        }
    }

}
