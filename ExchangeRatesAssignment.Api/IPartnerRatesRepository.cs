
namespace ExchangeRatesAssignment.Api
{
    public interface IPartnerRatesRepository
    {
        Task<IEnumerable<PartnerRate>> GetPartnerRatesAsync(CancellationToken cancellationToken = default);
    }
}
