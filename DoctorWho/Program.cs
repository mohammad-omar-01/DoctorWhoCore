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
 List<Doctor> GetAllDoctors()
{
    return context.Doctors.ToList();
}
 Enemy GetEnemyById(int enemyId)
{
    return context.Enemies.Find(enemyId);
}
 Companion GetCompanionById(int companionId)
{
    return context.Companions.Find(companionId);
}
void ViewExcution()
{

    var result = context.EpisodeSummaries.ToList();
    foreach (var episode in result)
    {
        Console.WriteLine($"Epsiode Name {episode.Title},Episode Enemey {episode.EnemyNames}");
    }
}
void FnCompanion()
{
    int episodeId = 3;

    var result = context.Database.SqlQuery<string>($"SELECT dbo.fnCompanion ({episodeId})").ToList();
    result.ForEach(a=>Console.WriteLine(a));


}
 void CreateCompanion(Companion companion)
{
    context.Companions.Add(companion);
    context.SaveChanges();
}
 void UpdateCompanion(Companion companion)
{
    context.Companions.Update(companion);
    context.SaveChanges();
}
 void DeleteCompanion(int companionId)
{
    var companion = context.Companions.Find(companionId);
    if (companion != null)
    {
        context.Companions.Remove(companion);
        context.SaveChanges();
    }
}
 void CreateEnemy(Enemy enemy)
{
    context.Enemies.Add(enemy);
    context.SaveChanges();
}
 void UpdateEnemy(Enemy enemy)
{
    context.Enemies.Update(enemy);
    context.SaveChanges();
}
 void DeleteEnemy(int enemyId)
{
    var enemy = context.Enemies.Find(enemyId);
    if (enemy != null)
    {
        context.Enemies.Remove(enemy);
        context.SaveChanges();
    }
}
 void CreateDoctor(Doctor doctor)
{
    context.Doctors.Add(doctor);
    context.SaveChanges();
}
 void UpdateDoctor(Doctor doctor)
{
    context.Doctors.Update(doctor);
    context.SaveChanges();
}
 void DeleteDoctor(int doctorId)
{
    var doctor = context.Doctors.Find(doctorId);
    if (doctor != null)
    {
        context.Doctors.Remove(doctor);
        context.SaveChanges();
    }
}
 void CreateAuthor(Author author)
{
    context.Authors.Add(author);
    context.SaveChanges();
}
 void UpdateAuthor(Author author)
{
    context.Authors.Update(author);
    context.SaveChanges();
}
 void DeleteAuthor(int authorId)
{
    var author = context.Authors.Find(authorId);
    if (author != null)
    {
        context.Authors.Remove(author);
        context.SaveChanges();
    }
}
 void CreateEpisode(Episode episode)
{
    context.Episodes.Add(episode);
    context.SaveChanges();
}
 void UpdateEpisode(Episode episode)
{
    context.Episodes.Update(episode);
    context.SaveChanges();
}
 void DeleteEpisode(int episodeId)
{
    var episode = context.Episodes.Find(episodeId);
    if (episode != null)
    {
        context.Episodes.Remove(episode);
        context.SaveChanges();
    }
}


