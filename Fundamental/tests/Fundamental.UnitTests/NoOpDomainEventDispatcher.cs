using System.Threading.Tasks;
using Fundamental.SharedKernel.Interfaces;
using Fundamental.SharedKernel;

namespace Fundamental.UnitTests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public Task Dispatch(BaseDomainEvent domainEvent)
        {
            return Task.CompletedTask;
        }
    }
}
