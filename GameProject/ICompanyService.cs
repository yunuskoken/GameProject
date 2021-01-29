using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICompanyService
    {
        void NewCompany(Gamer gamer);
        void CompanyDeleted(Gamer gamer);
        void CompanyUpdate(Gamer gamer);

    }
}
