namespace DoctorWho.Db.Repositories
{
    public class DoctorRepository
    {
        private readonly DoctorWhoCoreContext Context;

        public DoctorRepository(DoctorWhoCoreContext context)
        {
            Context = context;
        }

        public List<Doctor> GetAllDoctors()
        {
            return Context.Doctors.ToList();
        }

        public Doctor GetDoctorById(int doctorId)
        {
            return Context.Doctors.Find(doctorId);
        }

        public void CreateDoctor(Doctor doctor)
        {
            Context.Doctors.Add(doctor);
            Context.SaveChanges();
        }

        public void UpdateDoctor(Doctor doctor)
        {
            Context.Doctors.Update(doctor);
            Context.SaveChanges();
        }
        public void DeleteDoctor(int doctorId)
        {
            Doctor doctor = GetDoctorById(doctorId);
            if (doctor != null)
            {
                Context.Doctors.Remove(doctor);
                Context.SaveChanges();
            }
        }
    }
}
