using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : ICompanyService
    {
        public void CompanyDeleted(Gamer gamer)
        {
            Console.WriteLine("Kampanya Silindi !");
        }

        public void CompanyUpdate(Gamer gamer)
        {
            Console.WriteLine("Kampanya Güncellendi !");
        }

        public void NewCompany(Gamer gamer)
        {
            Console.WriteLine("Kampanya Yenilendi !");
        }

        
    }
}
