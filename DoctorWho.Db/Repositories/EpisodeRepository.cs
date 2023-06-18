using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeRepository
    {
        private readonly DoctorWhoCoreContext context;

        public EpisodeRepository(DoctorWhoCoreContext context)
        {
            this.context = context;
        }
        public List<Episode> GetAllEpisodes()
        {
            return context.Episodes.ToList();
        }
        public Episode GetEpisodeById(int episodeId)
        {
            return context.Episodes.Find(episodeId);
        }
        public void CreateEpisode(Episode episode)
        {
            context.Episodes.Add(episode);
            context.SaveChanges();
        }
        public void UpdateEpisode(Episode episode)
        {
            context.Episodes.Update(episode);
            context.SaveChanges();
        }
        public void DeleteEpisode(int episodeId)
        {
            var episode = context.Episodes.Find(episodeId);
            if (episode != null)
            {
                context.Episodes.Remove(episode);
                context.SaveChanges();
            }
        }
        public void AddEnimesToEpisode(int episodeId, int enmeyId)
        {
            var epsiode = context.Episodes.FirstOrDefault(a => a.EpisodeId == episodeId);
            var enemey = context.Enemies.FirstOrDefault(a => a.EnemyId == enmeyId);
            epsiode.Enemies.Add(enemey);
            context.SaveChanges();
        }
        public void AddCompanionToEpisode(int episodeId, int companionId)
        {
            var epsiode = context.Episodes.FirstOrDefault(a => a.EpisodeId == episodeId);
            var companion = context.Companions.FirstOrDefault(a => a.CompanionId == companionId);
            epsiode.Companions.Add(companion);
            context.SaveChanges();
        }
        public void AddEnimesToEpisodes()
        {
            var episodes = context.Episodes.ToList();
            var enemies = context.Enemies.ToList();
            var i = 1;
            foreach (var episode in episodes)
            {
                episode.Enemies.Add(enemies.FirstOrDefault(a => a.EnemyId == i));
                i++;
            }

            context.SaveChanges();
        }
        public void AddCompanionToepisode()
        {

            var episodes = context.Episodes.ToList();
            var companions = context.Companions.ToList();
            var i = 1;
            foreach (var episode in episodes)
            {
                episode.Companions.Add(companions.FirstOrDefault(a => a.CompanionId == i));
                i++;
            }

            context.SaveChanges();

        }
    }
}
