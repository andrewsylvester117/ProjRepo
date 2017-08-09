using System;
using LiteDB;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Reflection;

namespace Back_End
{
    public class DBops
    {
        public static void Profiles()
        {
            using (var db = new LiteDatabase("Profiles.db"))
            {
                var cards = db.GetCollection("HustleCards");

                

                // var col = db.GetCollection<YourClass>("collection");
                // col.Delete(x => x.Created < DateTime.Now);
            }
        }


         // Creating a new a profile, there needs to be check that no one has the same Username
        //          





        public static void AddToGroupDocuments(Group group)
        {
            using (var db = new LiteDatabase("GroupDocuments.db"))
            {
                var groups = db.GetCollection<Group>("GroupDocuments");

                groups.Insert(group);

            }
        }




        public static void AddProfile(Profile profile)
        {
            using (var db = new LiteDatabase("Profiles.db"))
            {
                var profiles = db.GetCollection<Profile>("Profiles");

                profiles.Insert(profile);

            }
        }

        public static void AddHighScoreToProfile(HighScore highscore)
        {

            using (var db = new LiteDatabase("HighScores.db"))
            {
                var scores  = db.GetCollection<HighScore>("HighScores");
                using (var db1 = new LiteDatabase("Profiles.db"))
                {
                    var players = db1.GetCollection<Profile>("Profiles");
                    scores.Insert(highscore);

                }


            }
        }





    }






}
