using KursProject.EntityLayer.Entities;

namespace KursProject.BusinessLayer.Abstract
{
    public interface IMenuTableService:IGenericService<MenuTable>
    {
        int TMenuTableCount();
    }
}
