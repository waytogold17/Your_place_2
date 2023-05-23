using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
namespace Demo2.Models;

    public class Hotel
    {
    public string Nom { get; set; }
    public string Description { get; set; }
    public string Etoiles { get; set; }
    public string TypeChambre1 { get; set; }
    public string TypeChambre2 { get; set; }
    public string TypeChambre3 { get; set; }
    public string TypeChambre4 { get; set; }
    public string imageHotel { get; set; }
    public string imageChambre1 { get; set; }
    public string imageChambre2 { get; set; }
    public string imageChambre3 { get; set; }
    public string imageChambre4 { get; set; }
    public string prixChambre1 { get; set; }
    public string prixChambre2 { get; set; }
    public string prixChambre3 { get; set; }
    public string prixChambre4 { get; set; }
    public string localisation { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }

}
    
[JsonSerializable(typeof(List<Hotel>))]
internal sealed partial class HotelContext : JsonSerializerContext
{

}

