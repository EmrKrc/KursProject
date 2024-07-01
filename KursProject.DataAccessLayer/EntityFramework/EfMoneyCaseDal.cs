using KursProject.DataAccessLayer.Abstract;
using KursProject.DataAccessLayer.Concrete;
using KursProject.DataAccessLayer.Repositories;
using KursProject.EntityLayer.Entities;

namespace KursProject.DataAccessLayer.EntityFramework
{
    public class EfMoneyCaseDal : GenericRepository<MoneyCase>, IMoneyCaseDal
    {
        public EfMoneyCaseDal(SignalRContext context) : base(context)
        {
        }

        public decimal TotalMoneyCaseAmount()
        {
            using var context = new SignalRContext();
            return context.MoneyCases.Select(x => x.TotalAmount).FirstOrDefault();
        }
    }
}
