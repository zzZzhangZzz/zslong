namespace FrmQingjia
{
    partial class FrmInsert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbOne = new System.Windows.Forms.GroupBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.bttTianjia = new System.Windows.Forms.Button();
            this.labGender = new System.Windows.Forms.Label();
            this.labId = new System.Windows.Forms.Label();
            this.labAge = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.gbOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOne
            // 
            this.gbOne.Controls.Add(this.cmbGender);
            this.gbOne.Controls.Add(this.bttTianjia);
            this.gbOne.Controls.Add(this.labGender);
            this.gbOne.Controls.Add(this.labId);
            this.gbOne.Controls.Add(this.labAge);
            this.gbOne.Controls.Add(this.labName);
            this.gbOne.Controls.Add(this.textAge);
            this.gbOne.Controls.Add(this.textName);
            this.gbOne.Controls.Add(this.textId);
            this.gbOne.Location = new System.Drawing.Point(39, 31);
            this.gbOne.Name = "gbOne";
            this.gbOne.Size = new System.Drawing.Size(362, 381);
            this.gbOne.TabIndex = 0;
            this.gbOne.TabStop = false;
            this.gbOne.Text = "信息维护";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbGender.Location = new System.Drawing.Point(179, 221);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 23);
            this.cmbGender.TabIndex = 3;
            // 
            // bttTianjia
            // 
            this.bttTianjia.Location = new System.Drawing.Point(122, 292);
            this.bttTianjia.Name = "bttTianjia";
            this.bttTianjia.Size = new System.Drawing.Size(110, 39);
            this.bttTianjia.TabIndex = 2;
            this.bttTianjia.Text = "保存";
            this.bttTianjia.UseVisualStyleBackColor = true;
            this.bttTianjia.Click += new System.EventHandler(this.bttTianjia_Click);
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGender.Location = new System.Drawing.Point(62, 223);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(39, 19);
            this.labGender.TabIndex = 1;
            this.labGender.Text = "性别";
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labId.Location = new System.Drawing.Point(62, 49);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(39, 19);
            this.labId.TabIndex = 1;
            this.labId.Text = "工号";
            // 
            // labAge
            // 
            this.labAge.AutoSize = true;
            this.labAge.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAge.Location = new System.Drawing.Point(62, 167);
            this.labAge.Name = "labAge";
            this.labAge.Size = new System.Drawing.Size(39, 19);
            this.labAge.TabIndex = 1;
            this.labAge.Text = "年龄";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labName.Location = new System.Drawing.Point(62, 116);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(39, 19);
            this.labName.TabIndex = 1;
            this.labName.Text = "姓名";
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(179, 164);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(121, 25);
            this.textAge.TabIndex = 0;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(179, 113);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(121, 25);
            this.textName.TabIndex = 0;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(179, 46);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(121, 25);
            this.textId.TabIndex = 0;
            // 
            // FrmInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 454);
            this.Controls.Add(this.gbOne);
            this.Name = "FrmInsert";
            this.Text = "员工信息维护";
            this.Load += new System.EventHandler(this.FrmInsert_Load);
            this.gbOne.ResumeLayout(false);
            this.gbOne.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOne;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button bttTianjia;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Label labAge;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textId;
    }
}