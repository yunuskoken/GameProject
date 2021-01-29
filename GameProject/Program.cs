using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, FirstName = "Yunus", LastName = "KÖKEN", BirthYear = 1999, IdentityNumber = 12345 });

            OrderManager orderManager = new OrderManager();

            orderManager.NewCompany(new Gamer { Id = 1, FirstName = "Yunus", LastName = "KÖKEN", BirthYear = 1999,IdentityNumber=12345 });
        }
    }
}
