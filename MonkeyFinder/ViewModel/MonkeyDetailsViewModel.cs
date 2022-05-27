namespace MonkeyFinder.ViewModel;
//Add QueryProperty
[QueryProperty(nameof(Monkey), "Monkey")]
public partial class MonkeyDetailsViewModel : BaseViewModel
{
    
    public MonkeyDetailsViewModel()
    {
    }


    public Monkey Monkey { get; set; }
}
