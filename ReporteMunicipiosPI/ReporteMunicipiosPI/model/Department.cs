using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReporteMunicipiosPI.Model
{
    class Department
    {
        private string name;
        private int countMun;

        public Department(string _name, int _countMun)
        {
            name = _name;
            countMun = _countMun;
        }

        public string Name
        {
            get => name;
        }

        public string CountMun
        {
            get => countMun;
            set => countMun = value;
        }
    }

}
