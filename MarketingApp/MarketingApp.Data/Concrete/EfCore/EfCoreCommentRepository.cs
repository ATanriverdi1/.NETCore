using MarketingApp.Data.Abstract;
using MarketingApp.Entity;

namespace MarketingApp.Data.Concrete.EfCore
{
    public class EfCoreCommentRepository :EfCoreGenericRepository<Comment, MarketingContext>, ICommentRepository
    {
        
    }
}