using System.Collections.Generic;
using MarketingApp.Entity;

namespace MarketingApp.Business.Abstract
{
    public interface ICommentService
    {
        List<Comment> GetAll();
        Comment GetById(int id);

        void Create(Comment entity);

        void Update(Comment entity);

        void Delete(Comment entity);
    }
}