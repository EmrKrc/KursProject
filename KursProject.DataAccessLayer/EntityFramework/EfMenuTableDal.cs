using KursProject.DataAccessLayer.Abstract;
using KursProject.DataAccessLayer.Concrete;
using KursProject.DataAccessLayer.Repositories;
using KursProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProject.DataAccessLayer.EntityFramework
{
    public class EfMenuTableDal : GenericRepository<MenuTable>, IMenuTableDal
    {
        public EfMenuTableDal(SignalRContext context) : base(context)
        {
        }

        public int MenuTableCount()
        {
           using var context = new SignalRContext();
            return context.MenuTables.Count();
        }
    }
}
