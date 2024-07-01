using KursProject.EntityLayer.Entities;

namespace KursProject.DataAccessLayer.Abstract
{
    public interface IMoneyCaseDal:IGenericDal<MoneyCase>
    {
        decimal TotalMoneyCaseAmount();
    }
}
