using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    internal interface IPersonRepository
    {
        void EditPeson(string name,int age);
        void ShowDet();
    }
}
