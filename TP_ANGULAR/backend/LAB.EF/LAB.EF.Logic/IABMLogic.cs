using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB.EF.Logic
{
    internal interface IABMLogic<T> //Para tipos genericos
    {
        List<T> GetAll();
        T GetById(string id);
        void Add(T toAdd);
        void Delete(string id);
        void Update(T toUpdate);
    }
}
