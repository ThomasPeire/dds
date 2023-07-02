using DDS.BuildingBlocks.Application;

namespace DDS.Modules.Customers.Application.Models;

public class CustomerView : IView
{
    public Guid Id { get; set; }
}