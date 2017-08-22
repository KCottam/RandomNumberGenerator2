using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGenerator2
{
    public partial class Modification : UserControl
    {
        public Modification()
        {
            InitializeComponent();
        }

        String originalText_Upper = "Upper";
        String originalText_Lower = "Lower";
        String originalText_Target = "Target";
        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox these = (sender as TextBox);
            switch (these.Name)
            {
                case "txtUpper":
                    if (these.Text == originalText_Upper)
                        these.Text = "";
                    break;
                case "txtLower":
                    if (these.Text == originalText_Lower)
                        these.Text = "";
                    break;
                case "txtTarget":
                    if (these.Text == originalText_Target)
                        these.Text = "";
                    break;
            }
        }
        private void txt_Exit(object sender, EventArgs e)
        {
            TextBox these = (sender as TextBox);
            switch (these.Name)
            {
                case "txtUpper":
                    if (these.Text == "")
                        these.Text = originalText_Upper;
                    break;
                case "txtLower":
                    if (these.Text == "")
                        these.Text = originalText_Lower;
                    break;
                case "txtTarget":
                    if (these.Text == "")
                        these.Text = originalText_Target;
                    break;
            }
        }

        public int Upper;
        public int Lower;
        public int Target;

        private void txtUpper_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtUpper.Text, out Upper))
                txtUpper.BackColor = System.Drawing.SystemColors.Window;
            else
                txtUpper.BackColor = System.Drawing.Color.Pink;
            CheckText();
        }

        private void txtLower_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtLower.Text, out Lower))
                txtLower.BackColor = System.Drawing.SystemColors.Window;
            else
                txtLower.BackColor = System.Drawing.Color.Pink;
            CheckText();
        }
        
        private void CheckText()
        {
            if(Upper < Lower)
                txtUpper.BackColor = System.Drawing.Color.Pink;
            else
                txtUpper.BackColor = System.Drawing.SystemColors.Window;

            if(Lower > Upper)
                txtLower.BackColor = System.Drawing.Color.Pink;
            else
                txtLower.BackColor = System.Drawing.SystemColors.Window;
        }

       

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtTarget_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtTarget.Text, out Target))
                txtTarget.BackColor = System.Drawing.SystemColors.Window;
            else
                txtTarget.BackColor = System.Drawing.Color.Pink;
        }
    }
}
