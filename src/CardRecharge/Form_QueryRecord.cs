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
    public partial class Form_QueryRecord : Form
    {
        ServiceReference1.DoorAuthoritySoapClient client = new ServiceReference1.DoorAuthoritySoapClient();
        public Form_QueryRecord()
        {
            InitializeComponent();
            this.dataGridView1.AllowUserToAddRows = false;
            this.dtp_startDate.Format = DateTimePickerFormat.Custom;
            this.dtp_startDate.CustomFormat = "yyyy-MM-dd";
            this.dtp_endDate.Format = DateTimePickerFormat.Custom;
            this.dtp_endDate.CustomFormat = "yyyy-MM-dd";

        }

        private void Query_Click(object sender, EventArgs e)
        {
            string startDate = dtp_startDate.Text.Replace("-", "");
            string endDate = dtp_endDate.Text.Replace("-","");
            DataTable dt = client.GetRechargeInfo("",startDate,endDate);
            dataGridView1.DataSource = dt;
        }
    }
}
