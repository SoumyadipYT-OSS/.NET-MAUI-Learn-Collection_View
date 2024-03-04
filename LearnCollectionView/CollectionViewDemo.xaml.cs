namespace LearnCollectionView;

public partial class CollectionViewDemo : ContentPage
{
	public CollectionViewDemo()
	{
		InitializeComponent();
        showCollectionView1.ItemsSource = GetCountries();
        showCollectionView2.ItemsSource = GetCountries();
	}

    private static List<Country> GetCountries() {
        return [
            new() { CountryName = "India", IsoCode = "IN", FlagUrl = "https://th.bing.com/th/id/R.826f9d8b33298bfee67446156e971c0d?rik=wiUcYGmZ2%2fCIwA&riu=http%3a%2f%2fwww.youthincmag.com%2fwp-content%2fuploads%2f2017%2f08%2findian-flag-photos-hd-wallpapers-download-free.jpg&ehk=PKkgKkLnLkk3Uq1BJAobhTyvCVRtq1Prgi%2b%2fWg0f%2b3A%3d&risl=&pid=ImgRaw&r=0"},
            new() { CountryName = "Russia", IsoCode = "RU", FlagUrl = "https://media.wired.com/photos/5926d7e08d4ebc5ab806ba8f/1:1/w_2500,c_limit/DNC-russia-hack-175590689.jpg"},
            new() { CountryName = "Israel", IsoCode = "IL", FlagUrl = "https://cdn.theculturetrip.com/wp-content/uploads/2017/12/flag_8046843840.jpg"},
            new() { CountryName = "Nepal", IsoCode = "NL", FlagUrl = "https://media.istockphoto.com/photos/nepal-national-flag-waving-on-pole-against-sunny-blue-sky-background-picture-id1128977462?k=6&m=1128977462&s=170667a&w=0&h=3FGlylUGFVlsoqZLNnVxkGnei9tywFe57d2iDocTqrQ="  },
            new() { CountryName = "France", IsoCode = "FR", FlagUrl = "https://ae01.alicdn.com/kf/HTB1ETwlLXXXXXcbXpXXq6xXFXXX8/New-Hot-Sale-Large-France-National-Flag-French-Banner-150-90CM-5-3FT-Eyelets-for-Hanging.jpg_640x640.jpg"},
            new() { CountryName = "Japan", IsoCode = "JP", FlagUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b5/Flag_of_Japan_.jpg" },
            new() { CountryName = "Germany", IsoCode = "DE", FlagUrl = "https://3.bp.blogspot.com/-Pi9Jg-BeA04/VTwxUkpC2NI/AAAAAAAAJxc/9m4gYyLu1EQ/s1600/germany-flag-hd-wallpapers-page-0.jpg"},
        ];
    }
}