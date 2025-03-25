using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyEmployeeView
{
    public partial class BodyEmployeeView: UserControl
    {
        readonly private List<string> roles = new List<string> { "Manager", "Employee" };
        public BodyEmployeeView()
        {
            InitializeComponent();
            RoleList.DataSource = roles;
        }
    }
}
