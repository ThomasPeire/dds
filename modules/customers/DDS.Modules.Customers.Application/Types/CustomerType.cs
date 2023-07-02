using DDS.Modules.Customers.Application.Models;
using DDS.Modules.Customers.Domain;

namespace DDS.Modules.Customers.Application.Types;

public class CustomerType : ObjectType<CustomerView>
{
    protected override void Configure(IObjectTypeDescriptor<CustomerView> descriptor)
    {
        descriptor.Name(nameof(Customer));
        descriptor.Field(x => x.Id).Type<NonNullType<UuidType>>();
    }
}