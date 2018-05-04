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
    public partial class FrmShow : Form
    {
        public FrmShow()
        {
            InitializeComponent();
        }
        //定义储存签到信息的数据
        public Dictionary<string, Time> dic = new Dictionary<string, Time>();

        //刷新数据
        public void BindGird(List<WorkerIfo> list)
        {
            this.dgvShow.DataSource = new BindingList<WorkerIfo>(list);
        }

        //定义储存员工信息的集合
        public List<WorkerIfo> wker = new List<WorkerIfo>();

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsert jia = new FrmInsert();
            //回参
            jia.MyFa = this;
            jia.Show();

        }

        private void 打卡记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDaka dk = new FrmDaka();
            dk.RecordList = this.dic;
            dk.Show();
        }

        private void FrmShow_Load(object sender, EventArgs e)
        {
            show();
        }

        //初始化定义数据
        public void show()
        {
        
         
            WorkerIfo wk = new WorkerIfo();
            wk.WorkerName = "张三";
            wk.WorkerId = "119";
            wk.WorkerAge = "23";
            wk.WorkerSex = "男";

            WorkerIfo wk2 = new WorkerIfo();
            wk2.WorkerName = "李四";
            wk2.WorkerId = "130";
            wk2.WorkerAge = "24";
            wk2.WorkerSex = "男";
            wker.Add(wk);
            wker.Add(wk2);
          //  wker.Add(wk.WorkerName,wk);
           // wker.Add(wk2.WorkerName, wk2);
            BindingSource bs = new BindingSource();
            dgvShow.DataSource = new BindingList<WorkerIfo>(wker);
           // dgvShow.DataSource = bs;

          

        }



        private void bttCha_Click(object sender, EventArgs e)
        {
            //定义新的集合
            List<WorkerIfo> temp = new List<WorkerIfo>();
            //循环遍历
            foreach (WorkerIfo item in this.wker)
            {
                //
                if(item.WorkerId.IndexOf(this.textWorkerid.Text.Trim())!=-1)
                {
                    temp.Add(item);
                }
            }
            this.dgvShow.DataSource = new BindingList<WorkerIfo>(temp);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        FrmDaka ff = new FrmDaka();

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("是否确定删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {

              //  List<WorkerIfo> tempList = new List<WorkerIfo>();
                string id = dgvShow.SelectedRows[0].Cells[1].Value.ToString();
               for (int i = 0; i < wker.Count; i++)
                {
                    if(wker[i].WorkerId==id)
                    {
                        wker.Remove(wker[i]);
                        BindGird(wker);
                        MessageBox.Show("删除成功！");
                       
                        break;
                       
                    }
                   
                }
                 this.dgvShow.DataSource = new BindingList<WorkerIfo>(wker);
            }
             
            }
       
        private void 签到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            if (this.dgvShow.SelectedRows.Count != 1)
            {
                MessageBox.Show("请选中一行！");
                return;
            }
            string worko = dgvShow.CurrentRow.Cells[1].Value.ToString();
          
            foreach (string item in dic.Keys)
            {
                if (worko == item)
                {
                    MessageBox.Show("您已经签到过！");
                    return;
                }
            }
            Time record = new Time();

            record.ID = worko;

            record.Name = dgvShow.CurrentRow.Cells[0].Value.ToString();
            record.SignInTime = DateTime.Now;
            this.dic.Add(record.ID, record);
          //  ff.FrmParent = this;
            MessageBox.Show("签到成功！");



        }

        private void 签退ToolStripMenuItem_Click(object sender, EventArgs e)
        {








            if (this.dgvShow.SelectedRows.Count != 1)
            {
                MessageBox.Show("请选择一行！");
                return;
            }
            string ID = dgvShow.CurrentRow.Cells[1].Value.ToString();
            bool isOut = false;
            foreach (string item in dic.Keys)
            {
                if (item == ID)
                {
                    this.dic[item].SignOutTime = DateTime.Now;
                    MessageBox.Show("签退成功！");
                    isOut = true;
                    break;
                }
            }


            if (!isOut)
            {
                MessageBox.Show("尚未签到！");
            }
        }
















        }





    }

