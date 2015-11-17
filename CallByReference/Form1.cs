using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallByReference
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateNumberTo100(object sender, EventArgs e)
        {
            int inputNum;
            if(int.TryParse(txtEnterNum.Text, out inputNum))
            {
                lblB4Call.Text = inputNum.ToString();
                MethodDefinition md = new MethodDefinition();
                int result = md.UpdateNumberTo100(ref inputNum);
                lblResult.Text = result.ToString();
                lblAfterCall.Text = result.ToString();
                lblResult.Visible = true;
                lblB4Call.Visible = true;
                lblAfterCall.Visible = true;

                
            }
        }

        private void btn_Reset_Form(object sender, EventArgs e)
        {
            txtEnterNum.Clear();
            lblResult.Text = "";
            lblB4Call.Text = "";
            lblAfterCall.Text = "";
        }
    }
}
