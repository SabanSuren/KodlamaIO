using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concretes
{
    public class Instructor:IEntity
    {
        public int InstructorId { get; set; }


        public string InstructorName { get; set; }

        public string Email { get; set; }


       
    }
}
