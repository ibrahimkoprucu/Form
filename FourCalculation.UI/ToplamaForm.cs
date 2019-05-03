using System.Windows.Forms;

namespace FourCalculation.UI
{
    public partial class ToplamaForm : Form
    {
        public ToplamaForm()
        {
            InitializeComponent();
        }

        /*
        private static SingleReferenceForm _toplamaForm;

        public static SingleReferenceForm GetInstance()
        {
            if (_toplamaForm == null)
            {
                _toplamaForm = new SingleReferenceForm();
                _toplamaForm.FormClosed += _toplamaForm_FormClosed;
            }

            return _toplamaForm;
        }

        private static void _toplamaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _toplamaForm = null;
        }
        */
    }
}