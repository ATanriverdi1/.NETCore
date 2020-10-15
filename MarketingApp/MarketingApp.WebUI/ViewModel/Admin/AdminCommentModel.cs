namespace MarketingApp.WebUI.ViewModel.Admin
{
    public class AdminCommentModel
    {
        public string UserId { get; set; }
        public string Title { get; set; }
        public string CommentMessage { get; set; }
        public int ProductId { get; set; }
        public string ReturnUrl { get; set; }
    }
}