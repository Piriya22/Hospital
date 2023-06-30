using Hospital_BB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace Hospital_BB.Repository
{
    public interface IDoctorsRepo
    {
        public IEnumerable<Doctors> GetDoctor();

        public Doctors DoctorById(int Doctor_Id);
        Task<Doctors> CreateDoctor([FromForm] Doctors doctors, IFormFile imageFile);
        Task<Doctors> UpdateDoctor(int doctorid, Doctors doctor, IFormFile imageFile);
        public Doctors DeleteDoctor(int doctorid);



    }
}
