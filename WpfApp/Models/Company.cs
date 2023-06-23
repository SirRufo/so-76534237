namespace WpfApp.Models
{
    public class Company : ReactiveObject
    {
        [Reactive] public int ID { get; set; }
        [Reactive] public string Name { get; set; } = string.Empty;
        [Reactive] public string Address { get; set; } = string.Empty;
        [Reactive] public string Postal { get; set; } = string.Empty;
        [Reactive] public string Location { get; set; } = string.Empty;
        [Reactive] public DateTime Created { get; set; }
    }
}
