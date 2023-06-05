using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;
using SQLite;
using PrimaryKeyAttribute = SQLite.PrimaryKeyAttribute;
using System.Text.Json.Serialization;

namespace hotellerie.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement, Column("id") ]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
    }

    public class HotelsDbContext : DbContext
    {
        public static object User { get; internal set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            object value = optionsBuilder.UseSqlite("Data Source=Models/hotels.db");
        }
    }


    public class Hotel
    {
        public string Nom { get; set; }
        public string Description { get; set; }
        public string Etoiles { get; set; }
        public string TypeChambre1 { get; set; }
        public string TypeChambre2 { get; set; }
        public string TypeChambre3 { get; set; }
        public string TypeChambre4 { get; set; }
        public string ImageHotel { get; set; }
        public string ImageChambre1 { get; set; }
        public string ImageChambre2 { get; set; }
        public string ImageChambre3 { get; set; }
        public string ImageChambre4 { get; set; }
        public string PrixChambre1 { get; set; }
        public string PrixChambre2 { get; set; }
        public string PrixChambre3 { get; set; }
        public string PrixChambre4 { get; set; }
        public string Localisation { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Commentaire { get; set; }


    }
    [JsonSerializable(typeof(List<Hotel>))]
    internal sealed partial class HotelContext : JsonSerializerContext
    {

    }


    public class HotelData
    {
        public List<Hotel> Hotels { get; set; }
        public void LoadHotelsFromJsonFile(string filePath)
        {
            Hotels = new List<Hotel>();

            using (StreamReader file = File.OpenText(filePath))
            {
                string jsonContent = file.ReadToEnd();

                foreach (string line in jsonContent.Split('\n'))
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        Hotel hotel = JsonConvert.DeserializeObject<Hotel>(line);
                        Hotels.Add(hotel);
                    }
                }
            }
        }
     
    }
    public class DataEntry
    {
        public void Loading()
        {
            string directoryPath = System.AppContext.BaseDirectory;
            string filePath = Path.Combine(directoryPath, "Models/YourPlace.json");

            HotelData hotelData = new HotelData();
            hotelData.LoadHotelsFromJsonFile(filePath);
            List<Hotel> hotels = hotelData.Hotels;
        }
    }
}

    
