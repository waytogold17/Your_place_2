
using System.Net.Http.Json;
using hotellerie.Models;

namespace hotellerie.Services;

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
            var response = await httpClient.GetAsync("https://www.montemagno.com/monkeys.json");
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

