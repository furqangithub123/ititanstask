using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ititans_App1
{
    public class StudentService
    {
        private readonly StudentContext _context;

        public StudentService(StudentContext context)
        {
            _context = context;
        }

        public List<Student> GetStudents()
        {
            var studentList = _context.Students.FromSqlRaw("EXEC [dbo].[GetStudents]").ToList();
            return studentList;
        }
    }
}
