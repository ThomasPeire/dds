using DDS.BuildingBlocks.Infrastructure;
using DDS.Modules.Customers.Domain;
using Marten;

namespace DDS.Modules.Customers.Infrastructure;

public class CustomerRepository : Repository, ICustomerRepository
{
    public CustomerRepository(IDocumentSession session) : base(session)
    {
    }
}