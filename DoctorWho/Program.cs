using DoctorWho.Db;
using DoctorWho.Db.Models;
using FluentAssertions;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

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
void AddAuhtorUsingStoredProecure(string name)
{
    context.Database.ExecuteSqlInterpolated($"exec inseartAuthors {name}");
    context.SaveChanges();
}
void ViewExcution()
{

    var result = context.EpisodeSummaries.ToList();
    foreach (var episode in result)
    {
        Console.WriteLine($"Epsiode Name {episode.Title},Episode Enemey {episode.EnemyNames}");
    }
}

void functionExcution()
{
    int episodeId = 3;

    var result = context.Database.SqlQuery<string>($"SELECT dbo.fnCompanion ({episodeId})").ToList();
    result.ForEach(a=>Console.WriteLine(a));


}


functionExcution();
