using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IT_ORG_SQLite_RGR_2022.Services;

namespace IT_ORG_SQLite_RGR_2022.Services
{
    public partial class FCustomException : Form
    {
        public FCustomException(string _source, string _message)
        {
            InitializeComponent();
            exceptionTitleBox.Text = _source;
            exceptionMessageBox.Text = _message;
        }

        private void FCustomException_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
