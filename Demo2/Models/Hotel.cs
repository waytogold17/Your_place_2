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

