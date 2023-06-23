namespace WpfApp.DataServices.Fakes
{
    internal class FakeCompanyService : ICompanyService
    {
        public async Task<ICollection<Company>> GetAllAsync( CancellationToken cancellationToken = default )
        {
            await Task.Delay( 250 ).ConfigureAwait( false );
            return Enumerable.Range( 1, 10 )
                .Select( id => new Company
                {
                    ID = id,
                    Address = $"Address {id}",
                    Location = $"Location {id}",
                    Name = $"Name {id}",
                    Postal = $"Postal {id}",
                    Created = DateTime.UtcNow,
                } )
                .ToList();
        }
    }
}
