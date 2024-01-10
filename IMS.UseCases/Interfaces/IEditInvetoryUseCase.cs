using IMS.CoreBusiness;

namespace IMS.UseCases.Interfaces
{
    public interface IEditInvetoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}