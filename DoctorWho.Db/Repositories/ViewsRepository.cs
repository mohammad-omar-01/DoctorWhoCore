namespace DoctorWho.Db.Repositories
{
    internal class ViewsRepository
    {
        private readonly DoctorWhoCoreContext context;
        public ViewsRepository(DoctorWhoCoreContext context)
        {
            context = context;
        }
        public void ViewExcution()
        {

            var result = context.EpisodeSummaries.ToList();
            foreach (var episode in result)
            {
                Console.WriteLine($"Epsiode Name {episode.Title},Episode Enemey {episode.EnemyNames}");
            }
        }
    }
}
