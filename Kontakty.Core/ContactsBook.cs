using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontakty.Core
{
    /// <summary>
    /// Klasa reprezentujaca Ksiazke Adresowa
    /// </summary>
    public class ContactsBook
    {
        /// <summary>
        /// Lista kontaktów (prywatna)
        /// </summary>
        private List<Contact> _contacts = new List<Contact>();

        /// <summary>
        /// Metoda dodajaca Contact do Ksiazki
        /// </summary>
        /// <param name="contact">Kontakt, ktory chcemy dodac</param>
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public List<Contact> GetContacts()
        {
            return _contacts;
        }

        /// <summary>
        /// Metoda do usuwania kontaktu
        /// </summary>
        public bool RemoveContact(string name)
        {
            var contactToRemove = _contacts.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (contactToRemove != null)
            {
                _contacts.Remove(contactToRemove);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Metoda do wyszukiwania kontaktów
        /// </summary>
        public List<Contact> SearchContacts(string query)
        {
            return _contacts.Where(c => c.Name.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public void PrintContacts(List<Contact> contactsToShow)
        {
            if (!contactsToShow.Any())
            {
                Console.WriteLine("Nie znaleziono kontaktów.");
                return;
            }

            foreach (Contact contact in contactsToShow)
            {
                Console.WriteLine(contact.GetContact());
            }
        }
    }
}
