using Kontakty.Core;

namespace Kontakty.Terminal
{
    class Program
    {
        static ContactsBook contactsBook = new ContactsBook();

        static void Main()
        {
            // Przykładowe dane startowe
            contactsBook.AddContact(new Contact("Adam Kowalski", "adam@kowalski.pl"));
            contactsBook.AddContact(new Contact("Anna Nowak", null, "+48 665 665 665"));
            contactsBook.AddContact(new Contact("Jan Kowal", "jan@jan.pl", "+49 661 661 661"));

            while (true)
            {
                Console.WriteLine("\n--- Książka Adresowa ---");
                Console.WriteLine("1. Dodaj nowy kontakt");
                Console.WriteLine("2. Pokaż wszystkie kontakty");
                Console.WriteLine("3. Wyszukaj kontakt");
                Console.WriteLine("4. Usuń kontakt");
                Console.WriteLine("5. Wyjdź z programu");
                Console.Write("Wybierz opcję: ");

                string option = Console.ReadLine();
                Console.Clear(); // Czyścimy ekran dla lepszej czytelności

                switch (option)
                {
                    case "1":
                        AddNewContact();
                        break;
                    case "2":
                        contactsBook.PrintContacts(contactsBook.GetContacts());
                        break;
                    case "3":
                        SearchForContact();
                        break;
                    case "4":
                        RemoveContact();
                        break;
                    case "5":
                        return; // Zakończenie programu
                    default:
                        Console.WriteLine("Nieznana operacja.");
                        break;
                }
                Console.WriteLine("\nNaciśnij dowolny klawisz, aby kontynuować...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void AddNewContact()
        {
            Console.WriteLine("--- Dodawanie Nowego Kontaktu ---");
            Console.Write("Podaj imię i nazwisko: ");
            string name = Console.ReadLine();

            Console.Write("Podaj adres e-mail (opcjonalnie): ");
            string email = Console.ReadLine();

            Console.Write("Podaj numer telefonu (opcjonalnie): ");
            string phoneNumber = Console.ReadLine();

            contactsBook.AddContact(new Contact(name, email, phoneNumber));
            Console.WriteLine("Kontakt został dodany!");
        }

        static void SearchForContact()
        {
            Console.WriteLine("--- Wyszukiwanie Kontaktów ---");
            Console.Write("Wpisz szukaną frazę: ");
            string query = Console.ReadLine();
            var results = contactsBook.SearchContacts(query);
            contactsBook.PrintContacts(results);
        }

        static void RemoveContact()
        {
            Console.WriteLine("--- Usuwanie Kontaktu ---");
            Console.Write("Podaj imię i nazwisko kontaktu do usunięcia: ");
            string name = Console.ReadLine();
            if (contactsBook.RemoveContact(name))
            {
                Console.WriteLine("Kontakt został usunięty.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono takiego kontaktu.");
            }
        }
    }
}