using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_ORG_SQLite_RGR_2022.Services
{
    public class CustomExceptions
    {
        string ExName { get; set; }
        string ExDescription { get; set; }

        public void ThrowNewException(string _source, string _helplink)
        {
            FCustomException customException = new FCustomException(_source, _helplink);
            customException.Show();
        }
    }
}
