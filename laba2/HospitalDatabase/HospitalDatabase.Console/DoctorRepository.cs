using HospitalDatabase.DAL.Entities;
using HospitalDatabase.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabase.Console
{
    public class DoctorRepository
    {
        private readonly HospitalContext _context;

        public DoctorRepository(HospitalContext context) { _context = context; }

        public async Task<Doctor> GetDoctorByLoginAndEmail(string login, string email)
        {
            var doctorResult = await _context
                .Set<Doctor>()
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Login == login && x.Email == email);

            if(doctorResult is not null) { return doctorResult; }
            else { throw new NullReferenceException("Wrong login or email!"); }
        }
    }
}
