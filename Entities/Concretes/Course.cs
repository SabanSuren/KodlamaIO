using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concretes
{
    public class Course:IEntity
    {
        public int CourseId { get; set; }

        public int InstructorId { get; set; }

        public int CompletionPercentage { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Instructor { get; set; }
    }
}
