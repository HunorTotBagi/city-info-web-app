namespace CityInfo.API.Services
{
    public class LocalMailService
    {
        private string _mailTo = "admin@mycomapny.com";
        private string _mailFrom = "noreply@mycompany.com";

        public void Send(string subject, string message)
        {
            // send mail - output ot console window
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, with " +
                $"with {nameof(LocalMailService)}.");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
