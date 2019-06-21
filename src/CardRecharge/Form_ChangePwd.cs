using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardRecharge
{
    public partial class Form_ChangePwd : Form
    { 
       // ServiceReference1.DoorAuthoritySoapClient service = new CardRecharge.ServiceReference1.DoorAuthoritySoapClient();
        ServiceReference_Test.DoorAuthoritySoapClient service = new CardRecharge.ServiceReference_Test.DoorAuthoritySoapClient();
        string empid = "";
        public Form_ChangePwd()
        {
            InitializeComponent();
        }

        public Form_ChangePwd(string empid)
        {
            InitializeComponent();
            this.empid = empid;
        }
        private void Submmit_Click(object sender, EventArgs e)
        {
            string result = service.ChangePwd(empid,tb_Newpsw.Text);
            MessageBox.Show(result);
        }
    }
}
