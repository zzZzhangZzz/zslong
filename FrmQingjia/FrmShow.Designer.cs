namespace FrmQingjia
{
    partial class FrmShow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打卡记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labWorkerid = new System.Windows.Forms.Label();
            this.textWorkerid = new System.Windows.Forms.TextBox();
            this.bttCha = new System.Windows.Forms.Button();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.签到ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.签退ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.打卡记录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.新增ToolStripMenuItem.Text = "新增";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.修改ToolStripMenuItem.Text = "修改";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 打卡记录ToolStripMenuItem
            // 
            this.打卡记录ToolStripMenuItem.Name = "打卡记录ToolStripMenuItem";
            this.打卡记录ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.打卡记录ToolStripMenuItem.Text = "打卡记录";
            this.打卡记录ToolStripMenuItem.Click += new System.EventHandler(this.打卡记录ToolStripMenuItem_Click);
            // 
            // labWorkerid
            // 
            this.labWorkerid.AutoSize = true;
            this.labWorkerid.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labWorkerid.Location = new System.Drawing.Point(51, 83);
            this.labWorkerid.Name = "labWorkerid";
            this.labWorkerid.Size = new System.Drawing.Size(93, 19);
            this.labWorkerid.TabIndex = 1;
            this.labWorkerid.Text = "员工工号";
            // 
            // textWorkerid
            // 
            this.textWorkerid.Location = new System.Drawing.Point(177, 80);
            this.textWorkerid.Name = "textWorkerid";
            this.textWorkerid.Size = new System.Drawing.Size(184, 25);
            this.textWorkerid.TabIndex = 2;
            // 
            // bttCha
            // 
            this.bttCha.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bttCha.Location = new System.Drawing.Point(436, 73);
            this.bttCha.Name = "bttCha";
            this.bttCha.Size = new System.Drawing.Size(91, 38);
            this.bttCha.TabIndex = 3;
            this.bttCha.Text = "查询";
            this.bttCha.UseVisualStyleBackColor = true;
            this.bttCha.Click += new System.EventHandler(this.bttCha_Click);
            // 
            // dgvShow
            // 
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvShow.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvShow.Location = new System.Drawing.Point(26, 155);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.RowTemplate.Height = 27;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(513, 404);
            this.dgvShow.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "WorkerId";
            this.Column1.HeaderText = "工号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "WorkerName";
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "WorkerAge";
            this.Column3.HeaderText = "年龄";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "WorkerSex";
            this.Column4.HeaderText = "性别";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.签到ToolStripMenuItem,
            this.签退ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 52);
            // 
            // 签到ToolStripMenuItem
            // 
            this.签到ToolStripMenuItem.Name = "签到ToolStripMenuItem";
            this.签到ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.签到ToolStripMenuItem.Text = "签到";
            this.签到ToolStripMenuItem.Click += new System.EventHandler(this.签到ToolStripMenuItem_Click);
            // 
            // 签退ToolStripMenuItem
            // 
            this.签退ToolStripMenuItem.Name = "签退ToolStripMenuItem";
            this.签退ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.签退ToolStripMenuItem.Text = "签退";
            this.签退ToolStripMenuItem.Click += new System.EventHandler(this.签退ToolStripMenuItem_Click);
            // 
            // FrmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 623);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.bttCha);
            this.Controls.Add(this.textWorkerid);
            this.Controls.Add(this.labWorkerid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmShow";
            this.Text = "员工信息维护";
            this.Load += new System.EventHandler(this.FrmShow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打卡记录ToolStripMenuItem;
        private System.Windows.Forms.Label labWorkerid;
        private System.Windows.Forms.TextBox textWorkerid;
        private System.Windows.Forms.Button bttCha;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 签到ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 签退ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

