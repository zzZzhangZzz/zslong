using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmQingjia
{
    public partial class FrmDaka : Form
    {
        public FrmDaka()
        {
            InitializeComponent();
        }


        public FrmShow FrmParent { get; set; }
        public Dictionary<string, Time> RecordList; 
       
        private void FrmDaka_Load(object sender, EventArgs e)
        {
            this.dgvTime.AutoGenerateColumns = false;
           
            BindingSource bs = new BindingSource();
            bs.DataSource = RecordList.Values;
            this.dgvTime.DataSource = bs;
            ts();

        }
        public void ts()
        {
           
            
                int row = this.dgvTime.RowCount;
                this.labTishi.Text = "共有" + row + "条打卡记录";
           
           
        }
     
    }
}
