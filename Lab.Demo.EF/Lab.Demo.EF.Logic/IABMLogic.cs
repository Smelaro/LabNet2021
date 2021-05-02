using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();

        void Add(T newValue);

        void Delete(int id);

        void Update(T value);
    }
}
