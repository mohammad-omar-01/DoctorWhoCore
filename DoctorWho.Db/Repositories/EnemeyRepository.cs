using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public class EnemyRepository
    {
        private readonly DoctorWhoCoreContext _context;

        public EnemyRepository(DoctorWhoCoreContext context)
        {
            _context = context;
        }

        public List<Enemy> GetAllEnemies()
        {
            return _context.Enemies.ToList();
        }

        public Enemy GetEnemyById(int enemyId)
        {
            return _context.Enemies.Find(enemyId);
        }

        public void CreateEnemy(Enemy enemy)
        {
            _context.Enemies.Add(enemy);
            _context.SaveChanges();
        }

        public void UpdateEnemy(Enemy enemy)
        {
            _context.Enemies.Update(enemy);
            _context.SaveChanges();
        }

        public void DeleteEnemy(int enemyId)
        {
            var enemy = _context.Enemies.Find(enemyId);
            if (enemy != null)
            {
                _context.Enemies.Remove(enemy);
                _context.SaveChanges();
            }
        }
    }
}
