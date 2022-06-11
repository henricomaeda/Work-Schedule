using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Scheduling
{
    public partial class FrmQuery : Form
    {
        public FrmQuery()
        {
            InitializeComponent();
        }

        private void FrmQuery_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            FrmMainMenu MainMenu = new FrmMainMenu();
            this.Hide();
            MainMenu.ShowDialog();
        }
    }
}
