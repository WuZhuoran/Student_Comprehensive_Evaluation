using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IntegrativeTestSystem; 

namespace IntegrativeTestSystem
{
    public partial class FormForCourse : Form
    {
        public Program.Student[] studentAllForm2 = new Program.Student[MainForm.MAXSTUDENT];
        public Program.Course [] courseAllForm2 = new Program.Course[MainForm.MAXSTUDENT];
        public int NumStu = 0;
        public int NumCou = 0;
        public string[] CourseName = new string[MainForm.MAXSTUDENT];
        public double[] CourseCredit = new double[MainForm.MAXSTUDENT];
        public int[] CourseType = new int[MainForm.MAXSTUDENT];


        public FormForCourse()
        {
            InitializeComponent();
            this.panelForCourse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.panelForCourse.AutoScroll = true;
            //MainForm mainForm  = (MainForm)this.Owner;
            this.buttonCourseInfoOK.Enabled = false;
            this.buttonInputGrade.Enabled = false;
            myDelegate = new DelegateDeliverTextBoxValue(ValueDeliverTextBoxFunction);
            //委托完成
            myDelegate1 = new delegateDiliverCourseValue(this.delegateDeliverCourseValueFunction);
            //使用Program.可以使用Program.cs中的类
            myDelegate2 = new delegateDeliverStudentValue(this.delegateDeliverStudentValueFunction);

            

        }
        /****委托1*/
        public delegate void DelegateDeliverTextBoxValue(string Str);
        public DelegateDeliverTextBoxValue myDelegate;
        private void ValueDeliverTextBoxFunction(string Str)
        {
            this.NumStu = Convert.ToInt32(Str);
            this.labelStudentNum.Text = Str;
        }
        /****委托2*/
        public delegate void delegateDeliverStudentValue(Program.Student[] arr);
        public delegateDeliverStudentValue myDelegate2;
        private void delegateDeliverStudentValueFunction(Program.Student[] arr)
        {
            for (int i = 0; i < Convert.ToInt32(this.labelStudentNum.Text); i++)
            {

                this.studentAllForm2[i] = new Program.Student(arr[i]);
            }
        }
        /****委托3*/
        public delegate void delegateDiliverCourseValue(int value);
        public delegateDiliverCourseValue myDelegate1;
        private void delegateDeliverCourseValueFunction(int value)
        {
            this.NumCou = value;
        }

        /*******************************************************************/
        private void buttonCourseInput_Click(object sender, EventArgs e)
        {
            this.buttonCourseInfoOK.Enabled = true;

            for (int i = 0; i < NumStu; i++)
            {
                Console.WriteLine(this.studentAllForm2[i].StudentName.ToString());
            }
            Console.WriteLine(this.NumCou.ToString());
            //上为测试用

            //形成3*课程数的格子

            TextBox TextBox1;
            TextBox LabelBox;
            int row = 0; //行数 总共不超过学生数

            //学号
            TextBox textBoxSNum = new TextBox();
            textBoxSNum.Text = "课程名";
            textBoxSNum.Size = new Size(150, 20);
            textBoxSNum.Location = new Point(50 + (150 + 10) * 0, 20);
            textBoxSNum.TextAlign = HorizontalAlignment.Center;
            textBoxSNum.Enabled = false;
            this.panelForCourse.Controls.Add(textBoxSNum);

            //姓名
            TextBox textBoxName = new TextBox();
            textBoxName.Text = "学分";
            textBoxName.Size = new Size(150, 20);
            textBoxName.Location = new Point(50 + (150 + 10) * 1, 20);
            textBoxName.TextAlign = HorizontalAlignment.Center;
            textBoxName.Enabled = false;
            this.panelForCourse.Controls.Add(textBoxName);

            //课程数
            TextBox textBoxCNum = new TextBox();
            textBoxCNum.Text = "类型1或2";
            textBoxCNum.Size = new Size(150, 20);
            textBoxCNum.Location = new Point(50 + (150 + 10) * 2, 20);
            textBoxCNum.TextAlign = HorizontalAlignment.Center;
            textBoxCNum.Enabled = false;
            this.panelForCourse.Controls.Add(textBoxCNum);

            //
            for (int i = 0; i < this.NumCou; i++)
            {
                LabelBox = new TextBox();
                LabelBox.Text = (i + 1).ToString();
                LabelBox.Size = new Size(30, 40);
                LabelBox.Location = new Point(0, 50 + 50 * row);
                LabelBox.Enabled = false;
                row++;
                this.panelForCourse.Controls.Add(LabelBox);

            }

            row = 0;    //Console.WriteLine("1"); 
            for (int i = 0; i < this.NumCou * 3; i++)
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
                    //如果课程名称相同可以在这改
                    //TextBox1.Text = "AAA";
                }
                else if ((i - 1) % 3 == 0)
                {
                    TextBox1.Location = new Point(50 + (TWidth + 10) * (i % 3), 50 + (THeight + 10) * row);
                    //如果课程学分相同可以在这修改
                    //TextBox1.Text = Convert.ToString(2);
                }
                else
                {
                    TextBox1.Location = new Point(50 + (TWidth + 10) * (i % 3), 50 + (THeight + 10) * row);
                    row++;
                    //如果课程类型一样可以在这儿修改
                    TextBox1.Text = Convert.ToString(1);
                    
                }

                TextBox1.Name = "TextBox" + i.ToString();

                this.panelForCourse.Controls.Add(TextBox1);
                this.buttonCourseInput.Enabled = false;
            }
        }

        private void buttonCourseInfoOK_Click(object sender, EventArgs e)
        {
            Control control = null;
            for (int i = 0; i < NumCou * 3; i++)
            {
                string tempName = "TextBox";
                tempName = tempName + i.ToString();
                foreach (Control item in this.panelForCourse.Controls)
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
                            this.CourseName[i / 3] = control.Text;

                        }
                        else if ((i - 1) % 3 == 0)  //1 4 7.....
                        {

                            this.CourseCredit[(i - 1) / 3] = Convert.ToDouble(control.Text);
                        }
                        else // 2 5 8.....
                        {
                            this.CourseType[(i - 2) / 3] = Convert.ToInt32(control.Text);
                        }
                    }

                }

            }

            

            for (int i = 0; i < this.NumCou; i++ )
            {
                this.courseAllForm2[i] = new Program.Course(this.CourseName[i], this.CourseType[i], CourseCredit[i]);
            }

            MessageBox.Show("课程信息读取完毕");
            this.buttonInputGrade.Enabled = true;
            this.buttonCourseInfoOK.Enabled = false;
        }

        private Control GetControl(string name, Control parent)
        {
            foreach (Control Item in this.panelForCourse.Controls)
            {
                if (Item.Name == name)
                {
                    return Item;
                }
            }
            return null;
        }

        private void buttonInputGrade_Click(object sender, EventArgs e)
        {
            FormForGrade thirdForm = new FormForGrade();
            foreach(Form Frm in Application.OpenForms)
            {
                if (Frm.Text == "FromForGrade")
                {
                    thirdForm = (FormForGrade)Frm;
                }
            }

            thirdForm.myDelegate5(this.NumStu, this.NumCou);
            thirdForm.myDelegate4(this.courseAllForm2);
            thirdForm.myDelegate3(this.studentAllForm2);
            thirdForm.Show();
        }

        private void buttonRefreash_Click(object sender, EventArgs e)
        {
            this.buttonCourseInfoOK.Enabled = false;
            this.buttonInputGrade.Enabled = false;
            this.buttonCourseInput.Enabled = true;
            this.panelForCourse.Controls.Clear();
        }


    }
}
