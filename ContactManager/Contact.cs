using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public string Note { get; set; }
        public bool Favorite { get; set; }
        public DateTime Created { get; set; }
        public int ID { get; set; }
        public Color Color { get; set; }
        public bool Deleted { get; set; }
        /*
        public Contact(Account loggedAccount, string firstName, string secondName, string birthday, string email, string phoneNumber, string note)
        {
            // Contact name
            FirstName = firstName;
            SecondName = secondName;
            FullName = firstName + " " + secondName;
            
            Birthday = BirthdayIntegrityCheck(birthday);
            Email = EmailIntegrityCheck(email);
            PhoneNumber = PhoneNumberIntegrityCheck(phoneNumber);
            Note = note;
            Created = DateTime.Today;
            Favorite = false;
            ID = GetNewID(loggedAccount);
            Color = Color.White;
            Deleted = false;
        }
        
        // Tvorba nového ID, najde největší a nové je o 1 větší, pokud nenajde začne jedničkou.
        private int GetNewID(Account loggedAccount)
        {
            List<int> idList = new List<int>();
            if (loggedAccount.Contacts.Count > 0)
            {
                foreach (var contact in loggedAccount.Contacts)
                {
                    idList.Add(contact.ID);
                }
            }
            else
            {
                idList.Add((int)0);
            }

            return idList.Max() + 1;
        }

        // Kontrola validního data narození
        private DateTime BirthdayIntegrityCheck(string birthday)
        {
            if (string.IsNullOrEmpty(birthday))
            {
                return DateTime.MinValue;
            }
            else
            {
                DateTime parsedBirthday;
                if (DateTime.TryParse(birthday, out parsedBirthday))
                {
                    return parsedBirthday;
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
        }

        // Kontrola validního emailu pomocí regexu https://www.c-sharpcorner.com/blogs/validate-email-address-in-c-sharp1
        private string EmailIntegrityCheck(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                return email;
            }
            else
            {
                return "";
            }
        }

        // Kontrola validního lefoního čísla
        private long PhoneNumberIntegrityCheck(string phoneNumberString)
        {
            long phoneNumber;
            if (long.TryParse(phoneNumberString, out phoneNumber))
            {
                if (long.Parse(phoneNumberString) > 0)
                {
                    return phoneNumber;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }
        
        */


    }
}
