using KursProject.EntityLayer.Entities;

namespace KursProject.BusinessLayer.Abstract
{
    public interface IMoneyCaseService:IGenericService<MoneyCase>
    {
        decimal TTotalMoneyCaseAmount();
    }
}
