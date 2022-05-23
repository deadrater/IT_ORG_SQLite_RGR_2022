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
using IT_ORG_SQLite_RGR_2022.Database;
using IT_ORG_SQLite_RGR_2022.Database.Models;
using IT_ORG_SQLite_RGR_2022.Controllers;
using IT_ORG_SQLite_RGR_2022.Views;
/*using IT_ORG_SQLite_RGR_2022.Views.Profile;
using IT_ORG_SQLite_RGR_2022.Views.PetrolStationTypeView;
using IT_ORG_SQLite_RGR_2022.Views.PetrolStationView;
using IT_ORG_SQLite_RGR_2022.Views.EmployeesView;
using IT_ORG_SQLite_RGR_2022.Views.EquipmentView;
using IT_ORG_SQLite_RGR_2022.Views.MaterialLiabilityView;
using IT_ORG_SQLite_RGR_2022.Views.StructureView;
using IT_ORG_SQLite_RGR_2022.Views.ExportToWordView;*/

namespace IT_ORG_SQLite_RGR_2022
{
    public partial class MainWindow : Form
    {
        User mUser = null;
        AuthForm aForm = null;

        public MainWindow(User _user, AuthForm _form)
        {
            mUser = _user;
            aForm = _form;

            InitializeComponent();
        }
    }
}