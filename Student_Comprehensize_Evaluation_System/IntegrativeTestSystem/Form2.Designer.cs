namespace IntegrativeTestSystem
{
    partial class FormForCourse
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
            this.panelForCourse = new System.Windows.Forms.Panel();
            this.labelStudentNum = new System.Windows.Forms.Label();
            this.buttonCourseInput = new System.Windows.Forms.Button();
            this.buttonCourseInfoOK = new System.Windows.Forms.Button();
            this.buttonInputGrade = new System.Windows.Forms.Button();
            this.buttonRefreash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelForCourse
            // 
            this.panelForCourse.Location = new System.Drawing.Point(12, 50);
            this.panelForCourse.Name = "panelForCourse";
            this.panelForCourse.Size = new System.Drawing.Size(960, 400);
            this.panelForCourse.TabIndex = 3;
            // 
            // labelStudentNum
            // 
            this.labelStudentNum.AutoSize = true;
            this.labelStudentNum.Location = new System.Drawing.Point(12, 18);
            this.labelStudentNum.Name = "labelStudentNum";
            this.labelStudentNum.Size = new System.Drawing.Size(0, 12);
            this.labelStudentNum.TabIndex = 4;
            // 
            // buttonCourseInput
            // 
            this.buttonCourseInput.Location = new System.Drawing.Point(121, 13);
            this.buttonCourseInput.Name = "buttonCourseInput";
            this.buttonCourseInput.Size = new System.Drawing.Size(93, 23);
            this.buttonCourseInput.TabIndex = 5;
            this.buttonCourseInput.Text = "课程信息录入";
            this.buttonCourseInput.UseVisualStyleBackColor = true;
            this.buttonCourseInput.Click += new System.EventHandler(this.buttonCourseInput_Click);
            // 
            // buttonCourseInfoOK
            // 
            this.buttonCourseInfoOK.Location = new System.Drawing.Point(235, 13);
            this.buttonCourseInfoOK.Name = "buttonCourseInfoOK";
            this.buttonCourseInfoOK.Size = new System.Drawing.Size(92, 23);
            this.buttonCourseInfoOK.TabIndex = 6;
            this.buttonCourseInfoOK.Text = "课程录入完毕";
            this.buttonCourseInfoOK.UseVisualStyleBackColor = true;
            this.buttonCourseInfoOK.Click += new System.EventHandler(this.buttonCourseInfoOK_Click);
            // 
            // buttonInputGrade
            // 
            this.buttonInputGrade.Location = new System.Drawing.Point(348, 13);
            this.buttonInputGrade.Name = "buttonInputGrade";
            this.buttonInputGrade.Size = new System.Drawing.Size(75, 23);
            this.buttonInputGrade.TabIndex = 7;
            this.buttonInputGrade.Text = "输入成绩";
            this.buttonInputGrade.UseVisualStyleBackColor = true;
            this.buttonInputGrade.Click += new System.EventHandler(this.buttonInputGrade_Click);
            // 
            // buttonRefreash
            // 
            this.buttonRefreash.Location = new System.Drawing.Point(897, 13);
            this.buttonRefreash.Name = "buttonRefreash";
            this.buttonRefreash.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreash.TabIndex = 8;
            this.buttonRefreash.Text = "刷新";
            this.buttonRefreash.UseVisualStyleBackColor = true;
            this.buttonRefreash.Click += new System.EventHandler(this.buttonRefreash_Click);
            // 
            // FormForCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.buttonRefreash);
            this.Controls.Add(this.buttonInputGrade);
            this.Controls.Add(this.buttonCourseInfoOK);
            this.Controls.Add(this.buttonCourseInput);
            this.Controls.Add(this.labelStudentNum);
            this.Controls.Add(this.panelForCourse);
            this.Name = "FormForCourse";
            this.Text = "课程计算页面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelForCourse;
        private System.Windows.Forms.Label labelStudentNum;
        private System.Windows.Forms.Button buttonCourseInput;
        private System.Windows.Forms.Button buttonCourseInfoOK;
        private System.Windows.Forms.Button buttonInputGrade;
        private System.Windows.Forms.Button buttonRefreash;
    }
}