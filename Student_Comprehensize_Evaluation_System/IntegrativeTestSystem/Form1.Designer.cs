namespace IntegrativeTestSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textStudentNum = new System.Windows.Forms.TextBox();
            this.labelStudentNum = new System.Windows.Forms.Label();
            this.panelForStudent = new System.Windows.Forms.Panel();
            this.buttonForStudentNum = new System.Windows.Forms.Button();
            this.buttonForRefresh = new System.Windows.Forms.Button();
            this.buttonStuInfoOK = new System.Windows.Forms.Button();
            this.buttonForSameCourseNum = new System.Windows.Forms.Button();
            this.textBoxSameCourse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textStudentNum
            // 
            resources.ApplyResources(this.textStudentNum, "textStudentNum");
            this.textStudentNum.Name = "textStudentNum";
            // 
            // labelStudentNum
            // 
            resources.ApplyResources(this.labelStudentNum, "labelStudentNum");
            this.labelStudentNum.Name = "labelStudentNum";
            // 
            // panelForStudent
            // 
            resources.ApplyResources(this.panelForStudent, "panelForStudent");
            this.panelForStudent.Name = "panelForStudent";
            // 
            // buttonForStudentNum
            // 
            resources.ApplyResources(this.buttonForStudentNum, "buttonForStudentNum");
            this.buttonForStudentNum.Name = "buttonForStudentNum";
            this.buttonForStudentNum.UseVisualStyleBackColor = true;
            this.buttonForStudentNum.Click += new System.EventHandler(this.buttonForStudentNum_Click);
            // 
            // buttonForRefresh
            // 
            resources.ApplyResources(this.buttonForRefresh, "buttonForRefresh");
            this.buttonForRefresh.Name = "buttonForRefresh";
            this.buttonForRefresh.UseVisualStyleBackColor = true;
            this.buttonForRefresh.Click += new System.EventHandler(this.buttonForRefresh_Click);
            // 
            // buttonStuInfoOK
            // 
            resources.ApplyResources(this.buttonStuInfoOK, "buttonStuInfoOK");
            this.buttonStuInfoOK.Name = "buttonStuInfoOK";
            this.buttonStuInfoOK.UseVisualStyleBackColor = true;
            this.buttonStuInfoOK.Click += new System.EventHandler(this.buttonStuInfoOK_Click);
            // 
            // buttonForSameCourseNum
            // 
            resources.ApplyResources(this.buttonForSameCourseNum, "buttonForSameCourseNum");
            this.buttonForSameCourseNum.Name = "buttonForSameCourseNum";
            this.buttonForSameCourseNum.UseVisualStyleBackColor = true;
            this.buttonForSameCourseNum.Click += new System.EventHandler(this.buttonForSameCourseNum_Click);
            // 
            // textBoxSameCourse
            // 
            resources.ApplyResources(this.textBoxSameCourse, "textBoxSameCourse");
            this.textBoxSameCourse.Name = "textBoxSameCourse";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.textBoxSameCourse);
            this.Controls.Add(this.buttonForSameCourseNum);
            this.Controls.Add(this.buttonStuInfoOK);
            this.Controls.Add(this.buttonForRefresh);
            this.Controls.Add(this.buttonForStudentNum);
            this.Controls.Add(this.panelForStudent);
            this.Controls.Add(this.labelStudentNum);
            this.Controls.Add(this.textStudentNum);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textStudentNum;
        private System.Windows.Forms.Label labelStudentNum;
        private System.Windows.Forms.Panel panelForStudent;
        private System.Windows.Forms.Button buttonForStudentNum;
        private System.Windows.Forms.Button buttonForRefresh;
        private System.Windows.Forms.Button buttonStuInfoOK;
        private System.Windows.Forms.Button buttonForSameCourseNum;
        private System.Windows.Forms.TextBox textBoxSameCourse;
    }
}

