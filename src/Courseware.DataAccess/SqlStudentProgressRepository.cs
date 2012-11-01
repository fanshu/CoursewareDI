using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Courseware.Domain;

namespace Courseware.DataAccess
{
    public class SqlStudentProgressRepository : IStudentProgressRepository
    {
        private readonly string _connString;

        public SqlStudentProgressRepository(string connectionString)
        {
            // Handle connection string
            _connString = connectionString;
        }

        public string GetStudentProgress(int studentId)
        {
            // Sql access with connection string


            return studentId + ": Level 2 Unit 5 Lesson 3......";
        }
    }
}
