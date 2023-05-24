using CommunityToolkit.Mvvm.Input;

namespace ButtonViewScrollRepro;
public partial class MainPageViewModel {
    public List<string> Items { get; } = Enumerable.Range(0, 100).Select(i => $"Item {i}").ToList();

    [RelayCommand]
    public void ItemTapped( string item ) {
        Console.WriteLine($"ItemTapped: {item}");
    }
}
