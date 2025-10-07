using Kontakty.Core;

namespace Kontakty.WinForms
{
    public partial class Form1 : Form
    {
        private ContactsBook _contactsBook = new ContactsBook();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _contactsBook.AddContact(new Contact("Adam Kowalski", "adamkowalski@gmail.com"));
            _contactsBook.AddContact(new Contact("Adam Kowalski", null, "+48 556 556 556"));
            _contactsBook.AddContact(new Contact("Adam Kowalski", "adamkowalski@gmail.com", "+48 556 556 556"));
            RefreshContacts();
        }

        private void RefreshContacts()
        {
            contactsListbox.Items.Clear();
            List<Contact> contacts = _contactsBook.GetContacts();

            foreach (Contact contact in contacts)
            {
                contactsListbox.Items.Add($"{contact.Name}, {contact.Email}");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            nameTextbox.Clear();
            emailTextbox.Clear();
            phoneTextbox.Clear();
            contactsListbox.SelectedItem = null;
            nameTextbox.Focus();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextbox.Text))
            {
                MessageBox.Show("Imiê i nazwisko nie mo¿e byc puste", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Add new contact

        }
    }
}
