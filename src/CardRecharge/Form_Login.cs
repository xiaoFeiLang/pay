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
    public partial class Form_Login : Form
    {
        ServiceReference1.DoorAuthoritySoapClient service = new CardRecharge.ServiceReference1.DoorAuthoritySoapClient();
       // ServiceReference_Test.DoorAuthoritySoapClient service = new CardRecharge.ServiceReference_Test.DoorAuthoritySoapClient();
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string empid = tbEmpid.Text;
            string psw = tbPsw.Text;
            
            this.Dispose();
            string result = service.Login(empid, psw);
            if (result.Contains("|"))
            {
                string [] arr = result.Split('|');
                Form1 form = new Form1(arr[0],arr[1],arr[2]);
                form.ShowDialog();
            }
            else{
                MessageBox.Show(result);
            }
            //Application.Run(new Form1());
        }
    }
}
