using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontakty.Core
{
    public class Contact
    {
        private string? _email;
        public string Name { get; set; }
        public string? Email
        {
            get
            {
                return _email;
            }

            set
            {
                if (isValidEmail(value))
                {
                    _email = value;
                }
            }
        }
        public string? PhoneNumber { get; set; }

        public Contact(string name, string? email = null, string? phoneNumber = null)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public string GetContact()
        {
            return $"Imię i nazwisko: {Name}, E-mail: {Email ?? "brak"}, Nr telefonu: {PhoneNumber ?? "brak"}";
        }

        private bool isValidEmail(string? email)
        {
            if (email == null) return false;

            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}
