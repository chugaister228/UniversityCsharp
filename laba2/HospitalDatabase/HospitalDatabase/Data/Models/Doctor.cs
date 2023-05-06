using HospitalDatabaseDAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabase.Data.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }

        public string? Name { get; set; }

        public string? Speciality { get; set; }

        //one to many
        public ICollection<Visitation>? Visitations { get; set; }
    }
}
