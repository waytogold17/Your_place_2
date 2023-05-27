using Demo2.Models;
using System.Net.Http.Json;


namespace Demo2.Services;

    public class HotelServicecs
    {
        HttpClient httpClient;
        public HotelServicecs()
        {
            this.httpClient = new HttpClient();
        }

         List<Hotel> hotelList;
         public async Task<List<Hotel>> GetHotels()
        {
            if (hotelList?.Count > 0)
                return hotelList;

            // Online
            var response = await httpClient.GetAsync("https://raw.githubusercontent.com/waytogold17/Your_place_2/amelio2s/Demo2/Resources/Raw/your_place.json");
            if (response.IsSuccessStatusCode)
            {
                hotelList = await response.Content.ReadFromJsonAsync(HotelContext.Default.ListHotel);
            }

            // Offline
            using var stream = await FileSystem.OpenAppPackageFileAsync("your_place.json");
            using var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync();
            hotelList = JsonSerializer.Deserialize(contents, HotelContext.Default.ListHotel);

            return hotelList;
        }
    }

