using KursProject.EntityLayer.Entities;

namespace KursProject.DataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
         int CategoryCount();
         int ActiveCategoryCount();
         int PassiveCategoryCount();
    }
}
