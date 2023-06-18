using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public class CompanionRepository
    {
        private readonly DoctorWhoCoreContext _context;

        public CompanionRepository(DoctorWhoCoreContext context)
        {
            _context = context;
        }

        public List<Companion> GetAllCompanions()
        {
            return _context.Companions.ToList();
        }

        public Companion GetCompanionById(int companionId)
        {
            return _context.Companions.Find(companionId);
        }

        public void CreateCompanion(Companion companion)
        {
            _context.Companions.Add(companion);
            _context.SaveChanges();
        }

        public void UpdateCompanion(Companion companion)
        {
            _context.Companions.Update(companion);
            _context.SaveChanges();
        }

        public void DeleteCompanion(int companionId)
        {
            var companion = _context.Companions.Find(companionId);
            if (companion != null)
            {
                _context.Companions.Remove(companion);
                _context.SaveChanges();
            }
        }
    }
}
