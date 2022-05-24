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

        public void ThrowCustomException(string ExName, string ExDescription)
        {
            MessageBox.Show(ExDescription,ExName,MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public void ThrowNewException(Exception ex)
        {
            ExName = $"ERROR! {ex.Source}";
            ExDescription = ex.Message;

            ThrowCustomException(ExName, ExDescription);
        }
    }
}
