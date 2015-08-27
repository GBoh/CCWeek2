namespace RolodexDatabase.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RolodexDatabase.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "RolodexDatabase.Models.DataContext";
        }

        protected override void Seed(RolodexDatabase.Models.DataContext context)
        {
            context.Contacts.AddOrUpdate(
                c => c.Name,
                new Contact
                {
                    Name = "Mildred Greene",
                    Phone = "1234567890",
                    Birthday = new DateTime(1990, 4, 5),
                    Address = new Address
                    {
                        Street = "Memory Lane",
                        City = "Townsville",
                        State = "Tx",
                        Zip = "12345"
                    }

                },
                new Contact
                {
                    Name = "Janet Palmer",
                    Phone = "0987654321",
                    Birthday = new DateTime(1898, 9, 20),
                    Address = new Address
                    {
                        Street = "Lois Lane",
                        City = "Gotham",
                        State = "Wa",
                        Zip = "54321"
                    }

                }
                );
        }
    }
}
