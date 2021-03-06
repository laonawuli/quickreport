﻿namespace QuickReport.Controls.DefaultValue
{
    partial class ucDefaultValueDate
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbSystemValue = new System.Windows.Forms.CheckBox();
            this.cmbSystemDataValue = new System.Windows.Forms.ComboBox();
            this.cmbAddOrSub = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDay = new QuickReport.Controls.NumeralText();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "固定值：";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(66, 144);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(87, 29);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "确认";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(162, 144);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(87, 29);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd ";
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(74, 25);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(166, 23);
            this.dateTimePicker.TabIndex = 4;
            // 
            // cbSystemValue
            // 
            this.cbSystemValue.AutoSize = true;
            this.cbSystemValue.Checked = true;
            this.cbSystemValue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSystemValue.Location = new System.Drawing.Point(15, 67);
            this.cbSystemValue.Name = "cbSystemValue";
            this.cbSystemValue.Size = new System.Drawing.Size(75, 21);
            this.cbSystemValue.TabIndex = 5;
            this.cbSystemValue.Text = "系统值：";
            this.cbSystemValue.UseVisualStyleBackColor = true;
            this.cbSystemValue.CheckedChanged += new System.EventHandler(this.cbSystemValue_CheckedChanged);
            // 
            // cmbSystemDataValue
            // 
            this.cmbSystemDataValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSystemDataValue.FormattingEnabled = true;
            this.cmbSystemDataValue.Location = new System.Drawing.Point(91, 65);
            this.cmbSystemDataValue.Name = "cmbSystemDataValue";
            this.cmbSystemDataValue.Size = new System.Drawing.Size(149, 25);
            this.cmbSystemDataValue.TabIndex = 6;
            // 
            // cmbAddOrSub
            // 
            this.cmbAddOrSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddOrSub.FormattingEnabled = true;
            this.cmbAddOrSub.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmbAddOrSub.Location = new System.Drawing.Point(15, 101);
            this.cmbAddOrSub.Name = "cmbAddOrSub";
            this.cmbAddOrSub.Size = new System.Drawing.Size(35, 25);
            this.cmbAddOrSub.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "天";
            // 
            // txtDay
            // 
            this.txtDay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDay.Location = new System.Drawing.Point(56, 103);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(28, 23);
            this.txtDay.TabIndex = 10;
            // 
            // ucDefaultValueDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAddOrSub);
            this.Controls.Add(this.cmbSystemDataValue);
            this.Controls.Add(this.cbSystemValue);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucDefaultValueDate";
            this.Size = new System.Drawing.Size(260, 188);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.CheckBox cbSystemValue;
        private System.Windows.Forms.ComboBox cmbSystemDataValue;
        private System.Windows.Forms.ComboBox cmbAddOrSub;
        private System.Windows.Forms.Label label2;
        private NumeralText txtDay;
    }
}
