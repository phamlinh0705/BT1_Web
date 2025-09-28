using System;
using System.Windows.Forms;
using FunnyLib;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form   // 👈 kế thừa từ Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int number = 0;
            Int32.TryParse(txtNumber.Text, out number);

            PersonalFunny pf = new PersonalFunny(name, number);
            lblResult.Text = pf.GenerateMessage();
        }
    }
}
