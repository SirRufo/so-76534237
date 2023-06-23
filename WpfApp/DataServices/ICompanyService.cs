namespace WpfApp.DataServices
{
    public interface ICompanyService
    {
        Task<ICollection<Company>> GetAllAsync( CancellationToken cancellationToken = default );
    }
}
