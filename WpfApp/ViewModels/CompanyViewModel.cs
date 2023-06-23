using System.Collections.ObjectModel;

namespace WpfApp.ViewModels
{
    public class CompanyViewModel : ViewModelBase
    {
        private readonly ICompanyService _companyService;

        [Reactive] public ObservableCollection<Company>? Companies { get; private set; }

        public CompanyViewModel( ICompanyService companyService )
        {
            _companyService = companyService;
        }

        protected override async Task OnInitializeAsync( CancellationToken cancellationToken )
        {
            await base.OnInitializeAsync( cancellationToken );
            var companyList = await _companyService.GetAllAsync( cancellationToken );
            Companies = new ObservableCollection<Company>( companyList );
        }
    }
}