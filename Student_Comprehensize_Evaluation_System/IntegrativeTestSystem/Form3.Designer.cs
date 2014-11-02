namespace IntegrativeTestSystem
{
    partial class FormForGrade
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
            this.panelForGrade = new System.Windows.Forms.Panel();
            this.buttonInputName = new System.Windows.Forms.Button();
            this.buttonGetResult = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelForGrade
            // 
            this.panelForGrade.Location = new System.Drawing.Point(12, 50);
            this.panelForGrade.Name = "panelForGrade";
            this.panelForGrade.Size = new System.Drawing.Size(960, 400);
            this.panelForGrade.TabIndex = 0;
            // 
            // buttonInputName
            // 
            this.buttonInputName.Location = new System.Drawing.Point(12, 12);
            this.buttonInputName.Name = "buttonInputName";
            this.buttonInputName.Size = new System.Drawing.Size(75, 23);
            this.buttonInputName.TabIndex = 1;
            this.buttonInputName.Text = "输入成绩";
            this.buttonInputName.UseVisualStyleBackColor = true;
            this.buttonInputName.Click += new System.EventHandler(this.buttonInputName_Click);
            // 
            // buttonGetResult
            // 
            this.buttonGetResult.Location = new System.Drawing.Point(103, 12);
            this.buttonGetResult.Name = "buttonGetResult";
            this.buttonGetResult.Size = new System.Drawing.Size(75, 23);
            this.buttonGetResult.TabIndex = 2;
            this.buttonGetResult.Text = "获取结果";
            this.buttonGetResult.UseVisualStyleBackColor = true;
            this.buttonGetResult.Click += new System.EventHandler(this.buttonGetResult_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(199, 12);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "计算";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // FormForGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonGetResult);
            this.Controls.Add(this.buttonInputName);
            this.Controls.Add(this.panelForGrade);
            this.Name = "FormForGrade";
            this.Text = "成绩输入页面";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForGrade;
        private System.Windows.Forms.Button buttonInputName;
        private System.Windows.Forms.Button buttonGetResult;
        private System.Windows.Forms.Button buttonCalculate;
    }
}