using System.Collections.Generic;
using MarketingApp.Business.Abstract;
using MarketingApp.Data.Abstract;
using MarketingApp.Entity;

namespace MarketingApp.Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private ICommentRepository _commentRepository;

        public CommentManager(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public void Create(Comment entity)
        {
            _commentRepository.Create(entity);
        }

        public void Delete(Comment entity)
        {
            _commentRepository.Delete(entity);
        }

        public List<Comment> GetAll()
        {
            return _commentRepository.GetAll();
        }

        public Comment GetById(int id)
        {
            return _commentRepository.GetById(id);
        }

        public void Update(Comment entity)
        {
            _commentRepository.Update(entity);
        }
    }
}