using System;
using System.Windows.Forms;

namespace FourCalculation.UI
{
    public partial class frmMainForm : Form
    {
        private readonly FormManager _formManager;

        public frmMainForm()
        {
            _formManager = new FormManager();
            InitializeComponent();
        }

        private void openButtonsHandler(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            _formManager.OpenForm(btn.Tag.ToString());
        }
    }
}