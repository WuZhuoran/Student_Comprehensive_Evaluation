using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace IntegrativeTestSystem
{
    public partial class MainForm : Form
    {
        public const int MAXSTUDENT = 50;//最大学生数

        public string[] StudentName = new string[MAXSTUDENT];
        public string[] StudentNum = new string[MAXSTUDENT];
        public int[] CourseNum = new int[MAXSTUDENT];
        internal int studentTotalNum = 0;
        public int CourseTotal;
        private Program.Student[] studentAll = new Program.Student[MAXSTUDENT];
        public MainForm()
        {
            InitializeComponent();
            
            this.buttonStuInfoOK.Enabled = false;
            this.panelForStudent.AutoScroll = true; //允许滚动
            this.textBoxSameCourse.Enabled = false;
            this.buttonForSameCourseNum.Enabled = false;
            this.panelForStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            
        }

        /// <summary>
        /// 第一页确认按钮
        /// 点击后在Panel中形成一定数量的TextBox 数量为textStudentNum中的值 * 3，即每一个学生3个框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonForStudentNum_Click(object sender, EventArgs e)
        {
            
            if (this.textStudentNum.Text == "")
            {
                MessageBox.Show("未输入学生数！");
                return;
            }

            TextBox TextBox1;
            TextBox LabelBox;
            int row = 0; //行数 总共不超过学生数
            
            //学号
            TextBox textBoxSNum = new TextBox();
            textBoxSNum.Text = "姓名";
            textBoxSNum.Size = new Size(150, 20);
            textBoxSNum.Location = new Point(50 + (150 + 10) * 0, 20);
            textBoxSNum.TextAlign = HorizontalAlignment.Center;
            textBoxSNum.Enabled = false;
            this.panelForStudent.Controls.Add(textBoxSNum);

            //姓名
            TextBox textBoxName = new TextBox();
            textBoxName.Text = "学号";
            textBoxName.Size = new Size(150, 20);
            textBoxName.Location = new Point(50 + (150 + 10) * 1, 20);
            textBoxName.TextAlign = HorizontalAlignment.Center;
            textBoxName.Enabled = false;
            this.panelForStudent.Controls.Add(textBoxName);
            
            //课程数
            TextBox textBoxCNum = new TextBox();
            textBoxCNum.Text = "课程数";
            textBoxCNum.Size = new Size(150, 20);
            textBoxCNum.Location = new Point(50 + (150 + 10) * 2, 20);
            textBoxCNum.TextAlign = HorizontalAlignment.Center;
            textBoxCNum.Enabled = false;
            this.panelForStudent.Controls.Add(textBoxCNum);

            //
            for (int i = 0; i < Convert.ToInt32(this.textStudentNum.Text); i++)
            {
                LabelBox = new TextBox();
                LabelBox.Text = (i + 1).ToString();
                LabelBox.Size = new Size(30, 40);
                LabelBox.Location = new Point(0, 50 + 50 * row);
                LabelBox.Enabled = false;
                row++;
                this.panelForStudent.Controls.Add(LabelBox);

            }

            row = 0;    //Console.WriteLine("1"); 
            for (int i = 0; i < Convert.ToInt32(this.textStudentNum.Text) * 3; i++)
            {

                TextBox1 = new TextBox();
                TextBox1.Text = "";
                TextBox1.Multiline = true;
                TextBox1.Size = new Size(150, 40);

                int LocationX = TextBox1.Location.X;
                int LocationY = TextBox1.Location.Y;
                int TWidth = TextBox1.Width;
                int THeight = TextBox1.Height;


                if (i % 3 == 0)
                {
                    TextBox1.Location = new Point(50 + (TWidth + 10) * (i % 3), 50 + (THeight + 10) * row);
                    //如果学生名称一样可以在这修改
                    //TextBox1.Text = "AVC";
                }
                else if ((i - 1) % 3 == 0)
                {
                    TextBox1.Location = new Point(50 + (TWidth + 10) * (i % 3), 50 + (THeight + 10) * row);
                    //如果学生学号一样可以在这修改
                    //TextBox1.Text = Convert.ToString(123);
                }
                else
                {
                    TextBox1.Location = new Point(50 + (TWidth + 10) * (i % 3), 50 + (THeight + 10) * row);
                    row++;
                    //如果课程数一样可以在这儿修改
                    //TextBox1.Text = Convert.ToString(16);
                }

                TextBox1.Name = "TextBox" + i.ToString();

                this.panelForStudent.Controls.Add(TextBox1);

            }

            this.buttonForStudentNum.Enabled = false;
            this.buttonStuInfoOK.Enabled = false;
            this.buttonForSameCourseNum.Enabled = true;
            this.textBoxSameCourse.Enabled = true;
            this.buttonForStudentNum.Enabled = false;

        }

        private void buttonForRefresh_Click(object sender, EventArgs e)
        {
            this.buttonForStudentNum.Enabled = true;
            this.buttonStuInfoOK.Enabled = false;
            this.panelForStudent.Controls.Clear();
        }

        private void buttonStuInfoOK_Click(object sender, EventArgs e)
        {
            //

            Control control = null;

            for (int i = 0; i < Convert.ToInt32(textStudentNum.Text) * 3; i++)
            {
                string tempName = "TextBox";
                tempName = tempName + i.ToString();
                foreach (Control item in this.panelForStudent.Controls)
                {
                    control = GetControl(tempName, item);
                    if (control == null || control.Text == "")
                    {
                        MessageBox.Show("有textbox未输入或名称出错.");
                        return;
                    }
                    else
                    {
                        if (i % 3 == 0)//第一种 3的倍数 0 3 6...
                        {
                            this.StudentName[i/3] = control.Text;
                            
                        }
                        else if ((i - 1) % 3 == 0)  //1 4 7.....
                        {

                            this.StudentNum[(i-1)/3] = control.Text;
                        }
                        else // 2 5 8.....
                        {
                            this.CourseNum[(i-2)/3] = Convert.ToInt32(control.Text);
                        }
                    }
                    
                }
                
            }
            MessageBox.Show("学生信息读取完毕");
            /***************测试代码******************/
            /*for (int i = 0; i < Convert.ToInt32(textStudentNum.Text); i++)
            /*{
            /*    Console.WriteLine(this.StudentName[i].ToString() + "--" + this.StudentNum[i].ToString() + "--" + this.CourseNum[i].ToString());
            /*}
            /***************测试代码******************/
            this.studentTotalNum = Convert.ToInt32(this.textStudentNum.Text);
            
            
            for (int i = 0; i < this.studentTotalNum; i++)
            {
                studentAll[i] = new Program.Student(this.StudentName[i], this.StudentNum[i], this.CourseNum[i]);
                //Console.WriteLine(this.StudentNum[i].ToString() + this.StudentName[i].ToString() + this.CourseNum[i]);
            }            

            
            
         
            
            /////////////////////////////////////////////////////////////////以下是产生新的窗口
            FormForCourse secondForm = new FormForCourse();
            
            //secondForm.Owner = this;
            foreach(Form Frm in Application.OpenForms)
            {
                if (Frm.Text == "FormForCourse")
                {
                    secondForm = (FormForCourse)Frm;
                }
                
            }
            secondForm.myDelegate(this.textStudentNum.Text);
            secondForm.myDelegate1(this.CourseTotal);
            secondForm.myDelegate2(this.studentAll);
            secondForm.Show();
            //进入第二个页面
        }

        private Control GetControl(string name, Control parent)
        {
            foreach (Control Item in this.panelForStudent.Controls)
            {
                if (Item.Name == name)
                {
                    return Item;
                }
            }
            return null;
        }

        public string textBoxStudentNum
        {
            get { return this.textStudentNum.Text; }
            set { textStudentNum.Text = value; }
        }

        private void buttonForSameCourseNum_Click(object sender, EventArgs e)
        {
            int temp = 0;
            if (this.textBoxSameCourse.Text == "" || !int.TryParse(this.textBoxSameCourse.Text, out temp))
            {
                MessageBox.Show("请输入课程数！");
                return;
            }
            else
            {
                this.CourseTotal = Convert.ToInt32(this.textBoxSameCourse.Text);
                this.buttonStuInfoOK.Enabled = true;
            }
        }
    }
}
