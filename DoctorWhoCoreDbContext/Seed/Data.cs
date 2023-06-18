using DoctorWho.Db.Models;

namespace DoctorWhoCoreDbContext.Seed_
{
    public class Data
    {
        public static List<Author> Authors = new List<Author> {
        new Author
        {
            AuthorId = 1,
            AuthorName = " Anthony Coburn"

        },
        new Author
        {
            AuthorId = 2,
            AuthorName="Sydney Newman"

        },
        new Author{
            AuthorId = 3,
            AuthorName="David Whitaker"
        },
        new Author {
                AuthorId = 4,

        AuthorName="John Lucarotti"

        },
        new Author {
                AuthorId = 5,

        AuthorName="Terry Nation"

        }

        };
        public static List<Doctor> Doctors = new List<Doctor>
        {
            new Doctor
    {
                DoctorId    = 1,
        DoctorNumber = 1,
        DoctorName = "William Hartnell",
        BirthDate = new DateTime(1908, 8, 1),
        FirstEpisodeDate = new DateTime(1963, 10, 1),
        LastEpisodeDate = new DateTime(1966, 10, 1)
    },

  new Doctor
    {
      DoctorId = 2,
        DoctorNumber = 3,
        DoctorName = "Jon Pertwee",
        BirthDate = new DateTime(1913, 8, 1),
        FirstEpisodeDate = new DateTime(1970, 1, 1),
        LastEpisodeDate = new DateTime(1974, 6, 1)
    },

     new Doctor
    {
            DoctorId = 3,
        DoctorNumber = 5,
        DoctorName = "Peter Davison",
        BirthDate = new DateTime(1954, 3, 1),
        FirstEpisodeDate = new DateTime(1982, 1, 1),
        LastEpisodeDate = new DateTime(1984, 3, 1)
    },

     new Doctor
    {
         DoctorId = 4,
        DoctorNumber = 7,
        DoctorName = "Michael Jayston",
        BirthDate = new DateTime(1968, 11, 1),
        FirstEpisodeDate = new DateTime(1986, 10, 1),
        LastEpisodeDate = new DateTime(1986, 10, 1)
    },

   new Doctor
    {
       DoctorId = 5,
        DoctorNumber = 9,
        DoctorName = "Sylvester McCoy",
        BirthDate = new DateTime(1962, 7, 26),
        FirstEpisodeDate = new DateTime(1987, 10, 1),
        LastEpisodeDate = new DateTime(1989, 10, 1)
    }
        };
        public static List<Companion> Companions = new List<Companion>
    {
        new Companion
        {
            CompanionId = 1,
            CompanionName = "Susan Foreman",
            WhoPlayed = "Carole Ann Ford"
        },
        new Companion
        {
            CompanionId = 2,
            CompanionName = "Ian Chesterton",
            WhoPlayed = "William Russell"
        },
        new Companion
        {
            CompanionId = 3,
            CompanionName = "Steven Taylor",
            WhoPlayed = "Peter Purves"
        },
        new Companion
        {
             CompanionId = 4,
            CompanionName = "Sara Kingdom",
            WhoPlayed = "Jean Marsh"
        },
        new Companion
        {
            CompanionId= 5,
            CompanionName = "Anneke Wills",
            WhoPlayed = "Polly"
        },
        new Companion
        {
            CompanionId= 6,
            CompanionName = "Clara Oswald",
            WhoPlayed = "Jenna Coleman"
        },
        new Companion
        {
            CompanionId= 7,
            CompanionName = "Bill Potts",
            WhoPlayed = "Pearl Mackie"
        }
    };
        public static List<Enemy> Enemies=new List<Enemy>
        {
   
        new Enemy
        {
            EnemyId= 1,
            EnemyName = "Dalek",
            EnemyDescription = "The Daleks are a fictional extraterrestrial race of extremely xenophobic mutants principally portrayed in the British science fiction television programme Doctor Who."
        },
        new Enemy
        {
            EnemyId= 2,
            EnemyName = "Cybermen",
            EnemyDescription = "Cybermens are emotionless robots from another world that constantly change their design."
        },
        new Enemy
        {
            EnemyId= 3,
            EnemyName = "The Master",
            EnemyDescription = "He is the Doctor's Moriarty: a renegade Time Lord who may be the hero's intellectual equal, but who is also his moral opposite."
        },
        new Enemy
        {
            EnemyId= 4,
            EnemyName = "Davros",
            EnemyDescription = "Davros is a character from the long-running British science fiction television series Doctor Who."
        },
        new Enemy
        {
            EnemyId= 5,
            EnemyName = "Sontarans",
            EnemyDescription = "The Sontarans are a fictional race of extraterrestrial humanoids principally portrayed in the British science fiction television programme Doctor Who."
        }
         };
        public static List<Episode> Episodes = new List<Episode>
{
    new Episode
    {
        EpisodeId = 1,
        SeriesNumber = 1,
        EpisodeNumber = 1,
        EpisodeType = "Regular",
        Title = "An Unearthly Child",
        EpisodeDate = new DateTime(1963, 11, 23),
        AuthorId = 1,
        DoctorId = 1,
        Notes = "Introduction of the First Doctor"
    },
    new Episode
    {
        EpisodeId = 2,
        SeriesNumber = 1,
        EpisodeNumber = 2,
        EpisodeType = "Regular",
        Title = "The Daleks",
        EpisodeDate = new DateTime(1963, 12, 21),
        AuthorId = 2,
        DoctorId = 1,
        Notes = "First appearance of the Daleks"
    },
    new Episode
    {
        EpisodeId = 3,
        SeriesNumber = 1,
        EpisodeNumber = 3,
        EpisodeType = "Regular",
        Title = "The Edge of Destruction",
        EpisodeDate = new DateTime(1964, 02, 08),
        AuthorId = 3,
        DoctorId = 1,
        Notes = "Bottle episode set entirely inside the TARDIS"
    },
    new Episode
    {
        EpisodeId = 4,
        SeriesNumber = 1,
        EpisodeNumber = 4,
        EpisodeType = "Regular",
        Title = "Marco Polo",
        EpisodeDate = new DateTime(1964, 02, 22),
        AuthorId = 4,
        DoctorId = 1,
        Notes = "Historical adventure in the time of Marco Polo"
    },
    new Episode
    {
        EpisodeId = 5,
        SeriesNumber = 1,
        EpisodeNumber = 5,
        EpisodeType = "Regular",
        Title = "The Keys of Marinus",
        EpisodeDate = new DateTime(1964, 04, 11),
        AuthorId = 5,
        DoctorId = 1,
        Notes = "Adventure involving a quest for the Keys of Marinus",
    }
};

    }




}

