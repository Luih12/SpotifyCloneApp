using System.Collections.ObjectModel;

namespace SpotifyCloneApp;

public partial class MainPage : ContentPage
{
    public ObservableCollection<string> Songs { get; set; } = new ObservableCollection<string>();

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;

        Songs.Add("Anxiety (Remix)");
        Songs.Add("ILBB2 (feat. GloRilla)");
        Songs.Add("Bad Bih 4 Ya");
        Songs.Add("Ms. Whitman");
        Songs.Add("It Isn’t Perfect But It Might Be");
        Songs.Add("Gata Only");
        Songs.Add("Nasty");
        Songs.Add("MILLION DOLLAR BABY (VHS)");
        Songs.Add("BIRDS OF A FEATHER");
        Songs.Add("Alibi");
    }
}
