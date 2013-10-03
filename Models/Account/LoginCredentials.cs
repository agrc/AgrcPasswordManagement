using System.ComponentModel.DataAnnotations;

namespace AgrcPasswordManagement.Models.Account
{
    public class LoginCredentials : AccountAccessBase
    {
        private string _application;

        public LoginCredentials()
        {
            
        }

        public LoginCredentials(string email, string password, string application)
        {
            Password = password;
            Application = application;
            Email = email;
        }

        [Required]
        public string Password { get; set; }
        
        [Required]
        public string Application
        {
            get { return _application.ToLower(); }
            set
            {
                if (value == null || string.IsNullOrEmpty(value))
                    _application = null;
                else
                {
                    _application = value;
                }
            }
        }
    }
}