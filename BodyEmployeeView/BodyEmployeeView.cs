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
        public event EventHandler SaveBtnClick;
        public event EventHandler CancelBtnClick;
        public event EventHandler DelBtnClick;
        public BodyEmployeeView()
        {
            InitializeComponent();
            RoleList.DataSource = roles;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            CancelBtnClick?.Invoke(this, EventArgs.Empty);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveBtnClick?.Invoke(this, EventArgs.Empty);
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            DelBtnClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
