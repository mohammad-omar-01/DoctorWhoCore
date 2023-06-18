using DoctorWho.Db;

DoctorWhoCoreContext context = new DoctorWhoCoreContext();

void AddEnimesToEpisode(int episodeId, int enmeyId)
{
    var epsiode = context.Episodes.FirstOrDefault(a => a.EpisodeId == episodeId);
    var enemey = context.Enemies.FirstOrDefault(a => a.EnemyId == enmeyId);
    epsiode.Enemies.Add(enemey);
    context.SaveChanges();
}
void AddCompanionToEpisode(int episodeId, int companionId)
{
    var epsiode = context.Episodes.FirstOrDefault(a => a.EpisodeId == episodeId);
    var companion = context.Companions.FirstOrDefault(a => a.CompanionId == companionId);
    epsiode.Companions.Add(companion);
    context.SaveChanges();
}
void AddEnimesToEpisodes()
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
void AddCompanionToepisode()
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
//AddEnimesToEpisodes();
//AddEnimesToEpisode(2, 1);
AddCompanionToepisode();
AddCompanionToEpisode(1, 2);
AddCompanionToEpisode(2, 2);
AddCompanionToEpisode(3, 2);