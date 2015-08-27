using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RolodexDatabase.Models
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var contacts = new List<Contact>
            {
                new Contact {
                Name = "Greg",
                Phone = "1234567890",
                Address = new Address {
                    Street = "Memory Lane",
                    City = "Townsville",
                    State = "Tx",
                    Zip = "77380"
                    }
                }
            };

            foreach (var c in contacts)
            {
                context.Contacts.Add(c);
            }
        }
    }
}