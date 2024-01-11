using IMS.CoreBusiness;
using IMS.UseCases.Interfaces;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Inventories
{
    public class EditInvetoryUseCase : IEditInvetoryUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public EditInvetoryUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }
        public async Task ExecuteAsync(Inventory inventory)
        {
            await inventoryRepository.UpdateInventoryAsync(inventory);
        }
    }
}
