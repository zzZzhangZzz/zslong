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
    public partial class FrmInsert : Form
    {

        public FrmShow MyFa { get;set;  }
        public FrmInsert()
        {
            InitializeComponent();
            this.cmbGender.SelectedIndex = 0;
        }

        private void FrmInsert_Load(object sender, EventArgs e)
        {

        }


        public void jia()
        {
            try
            {
                WorkerIfo wk3 = new WorkerIfo();
                wk3.WorkerId = textId.Text.Trim();
                wk3.WorkerAge = textAge.Text.Trim();
                wk3.WorkerName = textName.Text.Trim();
                //wk3.WorkerSex = cmbGender.Text;
                if (cmbGender.SelectedItem.ToString() == "男")
                {
                    wk3.WorkerSex = Gender.男.ToString();
                }
                else
                {
                    wk3.WorkerSex = Gender.女.ToString();
                }

              
            //    List<WorkerIfo> list = new List<WorkerIfo>();

              
                foreach (WorkerIfo item in MyFa.wker)
                {

                    if (item.WorkerId == wk3.WorkerId)
                    {
                        MessageBox.Show("此账号已存在");
                        return;
                    }
                    
                }
                MyFa.wker.Add(wk3);
                //  MessageBox.Show("添加成功");
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("出错"+ex.Message);

            }
            finally
            {
               this.MyFa.BindGird(MyFa.wker);
            }
        }

        private void bttTianjia_Click(object sender, EventArgs e)
        {
            jia();
           
        }



    }
}
