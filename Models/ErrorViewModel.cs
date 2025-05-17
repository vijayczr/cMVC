namespace WebApplication1.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    } 
}
