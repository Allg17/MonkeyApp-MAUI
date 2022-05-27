namespace MonkeyFinder.ViewModel;

public abstract class BaseViewModel : INotifyPropertyChanged
{

    public bool IsBusy { get; set; }
    public bool IsNotBusy => !IsBusy;
    public string Title { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string name = null) =>
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
