namespace WpfApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IServiceProvider _serviceProvider;

        public ReactiveCommand<Unit, Unit> CompanyViewCommand { get; }
        public ReactiveCommand<Unit, Unit> DiscoveryViewCommand { get; }
        [Reactive] public object? CurrentView { get; private set; }

        public MainWindowViewModel( IServiceProvider serviceProvider )
        {
            CompanyViewCommand = ReactiveCommand.CreateFromTask( OnCompanyViewCommandAsync );
            DiscoveryViewCommand = ReactiveCommand.CreateFromTask( OnDiscoveryViewCommandAsync );
            _serviceProvider = serviceProvider;
        }

        private async Task OnCompanyViewCommandAsync( CancellationToken cancellationToken )
        {
            var vm = _serviceProvider.GetRequiredService<CompanyViewModel>();
            CurrentView = vm;
            await vm.InitializeAsync( cancellationToken );
        }
        private async Task OnDiscoveryViewCommandAsync( CancellationToken cancellationToken )
        {
            var vm = _serviceProvider.GetRequiredService<DiscoveryViewModel>();
            CurrentView = vm;
            await vm.InitializeAsync( cancellationToken );
        }

    }
}