namespace MarketingApp.Entity
{
    public class Comment
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string CommentMessage { get; set; }
        public string ReturnUrl { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}