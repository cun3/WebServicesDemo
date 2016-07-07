using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProteinTrackerClient.ProteinTrackerService;

namespace ProteinTrackerClient
{
    public partial class ProteinTrackerForm : Form
    {
        private ProteinTrackingServiceSoapClient service = new ProteinTrackingServiceSoapClient();
        private User[] users;
        public ProteinTrackerForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            users = service.ListUsers();
            cboSelectUser.DataSource = users;
            cboSelectUser.DisplayMember = "Name";
            cboSelectUser.ValueMember = "UserId";
        }

        private void OnAddNewUser(object sender, EventArgs e)
        {
            service.AddUser(txtName.Text, int.Parse(txtGoal.Text));
            users = service.ListUsers();
            cboSelectUser.DataSource = users;
        }

        private void OnUserChanged(object sender, EventArgs e)
        {
            var index = cboSelectUser.SelectedIndex;
            lblTotalVal.Text = users[index].Total.ToString();
            lblGoalVal.Text = users[index].Goal.ToString();
        }

        private void OnAddProtein(object sender, EventArgs e)
        {
            var userId = users[cboSelectUser.SelectedIndex].UserId;
            var newTotal = service.AddProtein(int.Parse(txtAmount.Text),userId);
            users[cboSelectUser.SelectedIndex].Total = newTotal;
            lblTotalVal.Text = newTotal.ToString();
        }
    }
}
