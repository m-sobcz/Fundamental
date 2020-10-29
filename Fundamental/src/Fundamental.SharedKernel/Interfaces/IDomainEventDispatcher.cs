using System.Threading.Tasks;
using Fundamental.SharedKernel;

namespace Fundamental.SharedKernel.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}