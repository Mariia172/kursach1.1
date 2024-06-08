using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace kursach.Models
{
    public class Library
    {
        public Library() {}
        public List<Actor> Actors = new List<Actor>();
        public Library(Library library)
        {
            this.Actors = library.Actors;
        }
        public void Add(Actor actor)
        {
            Actors.Add(actor);
        }
        public void Remove(Actor actor)
        {
            Actors.Remove(actor);
        }
        public List<Actor> Search(string name, string surname, string alias, string year, string hometown, bool gender, string films, string genres, string rewards)
        {
            var result = new List<Actor>();
            string gender2 = gender.ToString();
            foreach (var b in Actors)
            {
                if (b.Name.Contains(name) &&
                    b.Surname.Contains(surname) &&
                    b.Alias.Contains(alias)&&
                    b.Year.ToString().Contains(year)&&
                    b.HomeTown.Contains(hometown)&&
                    b.Gender.ToString().Contains(gender2)&&
                    b.Films.Contains(films)&&
                    b.Genres.Contains(genres)&&
                    b.Rewards.Contains(rewards))
                {
                    result.Add(b);
                }
            }
            return result;
        }
        public void SaveData(string path)
        {
            var jsonString = JsonSerializer.Serialize(this.Actors);
            File.WriteAllText(path, jsonString);
        }

        public void LoadData(string path)
        {
            var jsonString = File.ReadAllText(path);
            this.Actors = JsonSerializer.Deserialize<List<Actor>>(jsonString);
        }
    }
}
