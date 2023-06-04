using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.ViewModel;

[QueryProperty(nameof(Hotel), nameof(Hotel))]

public partial class DeatailsReservationPageViewModel : BaseViewModel
{
    public ObservableCollection<Hotel> Hotels { get; set; }
    public Hotel SelectedHotel { get; set; }

    [ObservableProperty]
    Hotel hotel;

   



    public DateTime currentDate;
    public DateTime CurrentDate

    {
        get { return currentDate; }
        set
        {
            currentDate = value;
            OnPropertyChanged();
        }
    }
    public DeatailsReservationPageViewModel() 
    {
        currentDate = DateTime.Today;
        Hotels = new ObservableCollection<Hotel>();
        Hotels.Add(new Hotel
        {
            TypeChambre1 = "Suite double",
            TypeChambre2 = "Suite double avec vue sur la mer",
            TypeChambre3 = "Chambre deluxe simple",
            TypeChambre4 = "Chambre deluxe double avec vu sur la mer",
            ImageChambre1 = "https://www.viroth-hotel.com/wp-content/uploads/2019/05/Deluxe-Double-Room-1-600x400.jpg",
            ImageChambre2 = "https://www.viroth-hotel.com/wp-content/uploads/2019/05/Deluxe-Double-Pool-View-1-600x400.jpg",
            ImageChambre3 = "https://www.viroth-hotel.com/wp-content/uploads/2019/05/Deluxe-Twin-Room-3-600x400.jpg",
            ImageChambre4 = "https://www.viroth-hotel.com/wp-content/uploads/2019/05/Deluxe-Twin-Pool-View-1-1024x683.jpg",
            PrixChambre1 = "136",
            PrixChambre2 = "188",
            PrixChambre3 = "136",
            PrixChambre4 = "156",
        });
        Hotels.Add(new Hotel
        {
            TypeChambre1 = "Chambre supérieure",
            TypeChambre2 = "Chambre D'angle",
            TypeChambre3 = "Chambre diamant vue ville",
            TypeChambre4 = "Chambre Diamant vue port",
            ImageChambre1 = "https://q-xx.bstatic.com/xdata/images/hotel/840x460/37641253.jpg?k=ae951a56876b5f41cff6256209a203f1f5217d1696e9e8c84c77ecb3f4f144c5&amp;o=",
            ImageChambre2 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/346905778.jpg?k=b53287c2a70e386128f87edd1f4d0d920635d2732f071bb0e20f81a810d90008&amp;o=",
            ImageChambre3 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/16077648.jpg?k=debd27d74507def56b4fa56878cea0e70746f20e9498875ce2ce39ea03ab7014&amp;o=",
            ImageChambre4 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/346725790.jpg?k=063fa6f56a2d59295ede3918cb4fe35577fbe3796b8d33619e390e4d5049e0de&amp;o=",
            PrixChambre1 = "200",
            PrixChambre2 = "250",
            PrixChambre3 = "225",
            PrixChambre4 = "230",
        });


        Hotels.Add(new Hotel
        {
            TypeChambre1 = "Chambre traditionnelle simple",
            TypeChambre2 = "Suite deluxe vue cascade",
            TypeChambre3 = "Cocon forestier en hauteur",
            TypeChambre4 = "Chambre traditionnelle magistrale",
            ImageChambre1 = "http://www.cfmedia.vfmleonardo.com/imageRepo/2/0/71/558/404/Bird_s-Nest-Pool-Bathroom_S.jpg",
            ImageChambre2 = "http://www.cfmedia.vfmleonardo.com/imageRepo/7/0/123/140/286/RFuWTtNP_S.jpg",
            ImageChambre3 = "http://www.cfmedia.vfmleonardo.com/imageRepo/7/0/123/140/222/lgZKt4rY_S.jpg",
            ImageChambre4 = "http://www.cfmedia.vfmleonardo.com/imageRepo/2/0/71/558/828/Tree-Pool-House-Bedroom_S.jpg",
            PrixChambre1 = "200",
            PrixChambre2 = "250",
            PrixChambre3 = "220",
            PrixChambre4 = "250",
        });

        Hotels.Add(new Hotel
        {
            TypeChambre1 = "Suite simple",
            TypeChambre2 = "Suite double",
            TypeChambre3 = "bungalow deluxe",
            TypeChambre4 = "bungalow deluxe double ",
            ImageChambre1 = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0d/2e/6b/d1/birds-nest-pool-villa.jpg?w=1200&amp;h=-1&amp;s=1",
            ImageChambre2 = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0d/2e/6c/ec/tent-pool-villa.jpg?w=1200&amp;h=-1&amp;s=1",
            ImageChambre3 = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0d/2e/6c/fd/tent-pool-villa-2.jpg?w=1200&amp;h=-1&amp;s=1",
            ImageChambre4 = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1a/8c/48/3b/clay-pool-cottage.jpg?w=1200&amp;h=-1&amp;s=1",
            PrixChambre1 = "125",
            PrixChambre2 = "130",
            PrixChambre3 = "140",
            PrixChambre4 = "150",
        });

        Hotels.Add(new Hotel
        {
            TypeChambre1 = "Chambre deluxe simple ",
            TypeChambre2 = "Chambre deluxe VIP",
            TypeChambre3 = "Chambre plein air vue montagne ",
            TypeChambre4 = "Chambre plein air vue ville",
            ImageChambre1 = "https://q-xx.bstatic.com/xdata/images/hotel/840x460/254177162.jpg?k=6522ee679fc7b78944dc54fb276218a9b5fca025378bf58685d30afa33189241&amp;o=",
            ImageChambre2 = "https://q-xx.bstatic.com/xdata/images/hotel/840x460/254172208.jpg?k=0cc8e1df1202d21a5113bc0e1ed573e7083d35731b67d4af5caec491968d4c06&amp;o=",
            ImageChambre3 = "https://q-xx.bstatic.com/xdata/images/hotel/max1280x900/254178372.jpg?k=02a2576dee3eb47e644597ecce087d1907cf9e69c00c42476d47ab0542c674b2&amp;o=",
            ImageChambre4 = "https://cdn-img.readytotrip.com/t/1024x768/content/7a/fc/7afc1091105e6a5bac7eda994d6aa15450d1c3d4.jpeg",
            PrixChambre1 = "275",
            PrixChambre2 = "300",
            PrixChambre3 = "401",
            PrixChambre4 = "410",
        });

        Hotels.Add(new Hotel
        {
            TypeChambre1 = "Chambre simple",
            TypeChambre2 = "Suite romantique ",
            TypeChambre3 = "Chambre vue mer",
            TypeChambre4 = "Suite simple",
            ImageChambre1 = "https://q-xx.bstatic.com/xdata/images/hotel/max1024x720/71387054.jpg?k=5efb1f4bc19e729d070174e5f2dcd837da60b12668bfaf4e95882c253bd787a3&amp;o=",
            ImageChambre2 = "https://i.travelapi.com/lodging/20000000/19830000/19829300/19829203/a2700827_z.jpg",
            ImageChambre3 = "https://media-cdn.tripadvisor.com/media/photo-s/0e/07/f8/a9/the-place-luxury-boutique.jpg",
            ImageChambre4 = "https://images.trvl-media.com/hotels/20000000/19830000/19829300/19829203/ade03287_z.jpg",
            PrixChambre1 = "300",
            PrixChambre2 = "350",
            PrixChambre3 = "275",
            PrixChambre4 = "325",
        });

        Hotels.Add(new Hotel
        {
            TypeChambre1 = "Chambre simple",
            TypeChambre2 = "Chambre double",
            TypeChambre3 = "Complexe deluxe",
            TypeChambre4 = "Suite vue ville",
            ImageChambre1 = "https://q-xx.bstatic.com/xdata/images/hotel/max1280x900/16918658.jpg?k=39825f5c1970f5d8c13b27947e9d4192fbabaac9fc87ba670b6368ed077e3ccf&amp;o=",
            ImageChambre2 = "https://q-xx.bstatic.com/xdata/images/hotel/max1280x900/16918669.jpg?k=eaf0696fa73388f5ef36c3f1eb654fab794d74284ae1ebbdc12cb36f051a97c2&amp;o=",
            ImageChambre3 = "https://q-xx.bstatic.com/xdata/images/hotel/max1280x900/16827515.jpg?k=486b66840cad2b4ff758291db013974416584a2eed9bf3422788cc6f9bc8c420&amp;o=",
            ImageChambre4 = "https://q-xx.bstatic.com/xdata/images/hotel/840x460/16918669.jpg?k=eaf0696fa73388f5ef36c3f1eb654fab794d74284ae1ebbdc12cb36f051a97c2&amp;o=",
            PrixChambre1 = "120",
            PrixChambre2 = "150",
            PrixChambre3 = "170",
            PrixChambre4 = "190",
        });

        Hotels.Add(new Hotel
        {
            TypeChambre1 = "Chambre simple",
            TypeChambre2 = "Chambre double",
            TypeChambre3 = "Suite diplomatique",
            TypeChambre4 = "Suite celébrité",
            ImageChambre1 = "http://www.cfmedia.vfmleonardo.com/imageRepo/1/0/20/30/501/1136419cdms_img_pho_000_nc__663255_Superior_Room___P.jpg",
            ImageChambre2 = "http://www.cfmedia.vfmleonardo.com/imageRepo/7/0/139/941/627/Hotel_Lounge_sitting_area_P.jpg",
            ImageChambre3 = "http://www.cfmedia.vfmleonardo.com/imageRepo/1/0/20/30/430/1136419cdms_img_pho_000_nc__663229_Meeting_Room___P.jpg",
            ImageChambre4 = "https://q-xx.bstatic.com/xdata/images/hotel/max1024x720/220814594.jpg?k=5da1a2ba300cd7166981de3dbb0aa492fd4ca473d3e71f3930bd8d64954131ae&amp;o=",
            PrixChambre1 = "300",
            PrixChambre2 = "350",
            PrixChambre3 = "400",
            PrixChambre4 = "410",
        });

        Hotels.Add(new Hotel
        {
            TypeChambre1 = "Suite deluxe",
            TypeChambre2 = "Chambre simple ",
            TypeChambre3 = "Suite détente",
            TypeChambre4 = "Chambre deluxe",
            ImageChambre1 = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1c/35/45/79/junior-suite.jpg?w=1200&amp;h=-1&amp;s=1",
            ImageChambre2 = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1c/35/45/77/studio-suite.jpg?w=1200&amp;h=-1&amp;s=1",
            ImageChambre3 = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1c/35/45/75/deluxe-studio-suite-bathroom.jpg?w=1200&amp;h=-1&amp;s=1",
            ImageChambre4 = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1c/35/45/74/bathroom.jpg?w=1200&amp;h=-1&amp;s=1",
            PrixChambre1 = "175",
            PrixChambre2 = "150",
            PrixChambre3 = "180",
            PrixChambre4 = "170",
        });

        Hotels.Add(new Hotel
        {
            TypeChambre1 = "Chambre simple",
            TypeChambre2 = "Chambre kids",
            TypeChambre3 = "Chambre kids double",
            TypeChambre4 = "Suite simple",
            ImageChambre1 = "https://q-xx.bstatic.com/xdata/images/hotel/840x460/276697599.jpg?k=4892aefb588a5972e9310fc93329d65bc98e8b42ecf93e90da51737344a443c3&amp;o=",
            ImageChambre2 = "https://q-xx.bstatic.com/xdata/images/hotel/840x460/276108312.jpg?k=603218cb9c44ad39e482969e696d440c1231266725ef652d3b6d9d8e97ac30e3&amp;o=",
            ImageChambre3 = "https://q-xx.bstatic.com/xdata/images/hotel/max1024x720/286314216.jpg?k=b0978098a1bf52bc5cd17e2849f57b65b77a04ceaeda94a55cbc9bedf8e4c9b6&amp;o=",
            ImageChambre4 = "https://q-xx.bstatic.com/xdata/images/hotel/840x460/286310404.jpg?k=fdf54ca0e7d60bafdb8fc169c1da7d1920c364a6c6e152cb6d18a916eda2f659&amp;o=",
            PrixChambre1 = "200",
            PrixChambre2 = "190",
            PrixChambre3 = "205",
            PrixChambre4 = "225",
        });

        Hotels.Add(new Hotel
        {
            TypeChambre1 = "Chambre deluxe simple",
            TypeChambre2 = "Chambre deluxe VIP",
            TypeChambre3 = "Suite diplomatique",
            TypeChambre4 = "Suite romantique",
            ImageChambre1 = "http://a.mktgcdn.com/p/q7BtXfjIEt_SZM3DPOFlCpC8LPlBhKZPf_TwXxyjJ44/3375x4500.jpg",
            ImageChambre2 = " https://bpprodstorage.blob.core.windows.net/bpblobcontainer/4327300/images/917a1c34-50ca-4bba-b87d-8ec709de89983y8RTgpSEnxBOLpl2OCmHV7kuLmlGO2Jgxc77CRY1GkBqQFzD4WvI3dQ6kvlRPYGrS6BK6zfqrTxRn6AAQ=s0.Jpeg",
            ImageChambre3 = "http://a.mktgcdn.com/p/BG3h3uibpaeMpeocbjfLGgGjDfUqNdcSX8azsCEubt0/1200x800.jpg",
            ImageChambre4 = "https://q-xx.bstatic.com/xdata/images/hotel/max1280x900/221906353.jpg?k=8fc3c187189df7daa51a94523be5759704d95053bd94cfb38ff0cd0e992adbcb&amp;o=",
            PrixChambre1 = "400",
            PrixChambre2 = "410",
            PrixChambre3 = "450",
            PrixChambre4 = "375",
        });

        Hotels.Add(new Hotel
        {
            TypeChambre1 = "Chambre simple",
            TypeChambre2 = "Chambre vue montagne",
            TypeChambre3 = "Suite meeting",
            TypeChambre4 = "Suite montagne vip",
            ImageChambre1 = "https://q-xx.bstatic.com/xdata/images/hotel/max1280x900/28532244.jpg?k=837e2643ca29b1af84f0d2ecba64d91b50441639e0241f3b06e65a1068d70f9f&amp;o=",
            ImageChambre2 = "https://q-xx.bstatic.com/xdata/images/hotel/max1280x900/35941209.jpg?k=e84646d6d9ddde6670b5f7d4f98e9fe40f9461a3c3de2414124f73e4027760e2&amp;o=",
            ImageChambre3 = "https://www.hotelscombined.ie//himg/3d/30/cd/leonardo-1119622-08_boardroom_O-036165.jpg",
            ImageChambre4 = "https://q-xx.bstatic.com/xdata/images/hotel/max1280x900/28532117.jpg?k=2e3508d1e9d8b0daa8c12981a61b641afc32c84d65652a7faede731502d79486&amp;o=",
            PrixChambre1 = "350",
            PrixChambre2 = "375",
            PrixChambre3 = "400",
            PrixChambre4 = "425",
        });

        Hotels.Add(new Hotel
        {
            TypeChambre1 = "Chambre Old school",
            TypeChambre2 = "Chambre Old school deluxe",
            TypeChambre3 = "Suite meeting",
            TypeChambre4 = "Suite romantique",
            ImageChambre1 = "https://q-xx.bstatic.com/xdata/images/hotel/max1280x900/174594425.jpg?k=4367bf71162ef35dc8d7d683d9d9e2d8cbdcec480f87041ef667237f06ed6725&amp;o=",
            ImageChambre2 = "https://q-xx.bstatic.com/xdata/images/hotel/max1280x900/174594423.jpg?k=ebe0404291374db2c49f31c0c61bc86442f94b1c21f3de135023f5b6410d862c&amp;o=",
            ImageChambre3 = "https://q-xx.bstatic.com/xdata/images/hotel/max1280x900/181297924.jpg?k=c28feecd34125e01b8d4b84525a0ab61ee11332c8b8fb7e6d101c9fc1ab177bc&amp;o=",
            ImageChambre4 = "https://res.cloudinary.com/grand-luxury/image/upload/w_1200,q_50,f_auto,c_fill,g_center,dpr_1/remote_glh/original/86565-root-megu-dining-room.jpg",
            PrixChambre1 = "250",
            PrixChambre2 = "275",
            PrixChambre3 = "300",
            PrixChambre4 = "290",
        });

        Hotels.Add(new Hotel
        {
            TypeChambre1 = "Antique luxury simple",
            TypeChambre2 = "Joyful Room deluxe",
            TypeChambre3 = "Garden view room",
            TypeChambre4 = "Modern room",
            ImageChambre1 = "https://i.travelapi.com/hotels/1000000/530000/523800/523756/6cadcc47_z.jpg",
            ImageChambre2 = "http://www.cfmedia.vfmleonardo.com/imageRepo/3/0/76/659/712/DeluxeStudio_Matisse_P.jpg",
            ImageChambre3 = "https://i.travelapi.com/hotels/1000000/530000/523800/523756/92fdf2bf_z.jpg",
            ImageChambre4 = "https://i.travelapi.com/lodging/32000000/31730000/31727900/31727821/864952f2_z.jpg",
            PrixChambre1 = "275",
            PrixChambre2 = "300",
            PrixChambre3 = "310",
            PrixChambre4 = "260",
        });

        Hotels.Add(new Hotel
        {
            TypeChambre1 = "Chambre simple ",
            TypeChambre2 = "Duplexe familiale",
            TypeChambre3 = "Suite meeting",
            TypeChambre4 = "Suite romantique",
            ImageChambre1 = "http://www.cfmedia.vfmleonardo.com/imageRepo/7/0/122/522/588/bkksp-two-bedroom-5155-hor-clsc_S.jpg",
            ImageChambre2 = " https://i.travelapi.com/lodging/3000000/2940000/2933900/2933858/8a5750b7_z.jpg",
            ImageChambre3 = " http://www.cfmedia.vfmleonardo.com/imageRepo/6/0/96/305/498/bkksp-garden-0106-hor-clsc_S.jpg",
            ImageChambre4 = "http://www.cfmedia.vfmleonardo.com/imageRepo/6/0/96/305/420/bkksp-spa-0099-hor-clsc_S.jpg",
            PrixChambre1 = "400",
            PrixChambre2 = "410",
            PrixChambre3 = "450",
            PrixChambre4 = "475",
        });
    }

    [RelayCommand]
    async Task NaviguatePlus() => await Shell.Current.GoToAsync(nameof(ValidationReservationPage));

}
