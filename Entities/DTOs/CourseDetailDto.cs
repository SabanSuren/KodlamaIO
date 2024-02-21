using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CourseDetailDto
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public string CourseDescription { get; set; }

        public string InstructorName { get; set; }

        public int CompletionPercentage { get; set; }
        public string Description { get; set; }
    }
}
