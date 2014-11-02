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
    public partial class FormForGrade : Form
    {
        public Program.Student[] studentAllForm3 = new Program.Student[MainForm.MAXSTUDENT];
        public Program.Course[] courseAllForm3 = new Program.Course[MainForm.MAXSTUDENT];
        public int NumStudent = 0;
        public int NumCourse = 0;
        public double [,] ScoreAll = new double[MainForm.MAXSTUDENT, MainForm.MAXSTUDENT]; //先把所有分数储存好
        public FormForGrade()
        {
            InitializeComponent();
            this.panelForGrade.AutoScroll = Enabled;
            this.buttonCalculate.Enabled = false;
            this.buttonGetResult.Enabled = false;
            this.panelForGrade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            myDelegate5 = new delegateDeliverIntValue(this.delegateDeliverIntValueFunction);
            myDelegate4 = new delegateDeliverCourseValue(this.delegateDeliverCourseValueFunction);
            myDelegate3 = new delegateDeliverStudentValue(this.delegateDeliverStudentValueFunction);
            //委托结束


        }

        //委托1 Student
        public delegate void delegateDeliverStudentValue(Program.Student[] arr);
        public delegateDeliverStudentValue myDelegate3;
        private void delegateDeliverStudentValueFunction(Program.Student[] arr)
        {
            for (int i = 0; i < this.NumStudent; i++)
            {
                this.studentAllForm3[i] = new Program.Student(arr[i]);
            }
        }


        //委托2 Course
        public delegate void delegateDeliverCourseValue(Program.Course[] arr);
        public delegateDeliverCourseValue myDelegate4;
        private void delegateDeliverCourseValueFunction(Program.Course[] arr)
        {
            for (int i = 0; i < this.NumCourse; i++)
            {
                this.courseAllForm3[i] = new Program.Course(arr[i]);
            }
        }
        //委托3 int

        public delegate void delegateDeliverIntValue(int value1Student, int value2Course);
        public delegateDeliverIntValue myDelegate5;
        private void delegateDeliverIntValueFunction(int value1Student, int value2Course)
        {
            this.NumStudent = value1Student;
            this.NumCourse = value2Course;
        }

        private void buttonInputName_Click(object sender, EventArgs e)
        {
            this.buttonGetResult.Enabled = true;
            this.buttonInputName.Enabled = false;
            TextBox TextBox1;
            TextBox LabelBox;
            int row = 0; //行数 总共不超过学生数

            for (int i = 0; i < this.NumCourse; i++)
            {
                TextBox textBoxTemp = new TextBox();
                textBoxTemp.Text = courseAllForm3[i].CourseName;
                textBoxTemp.Size = new Size(100, 20);
                textBoxTemp.Location = new Point(50 + 110 * i, 20);
                textBoxTemp.TextAlign = HorizontalAlignment.Center;
                textBoxTemp.Enabled = false;
                this.panelForGrade.Controls.Add(textBoxTemp);
            }

            for (int i = 0; i < this.NumStudent; i++)
            {
                LabelBox = new TextBox();
                LabelBox.Text = this.studentAllForm3[i].StudentName;
                LabelBox.Size = new Size(40, 40);
                LabelBox.Location = new Point(0, 50 + 30 * row);
                LabelBox.Enabled = false;
                row++;
                this.panelForGrade.Controls.Add(LabelBox);
            }

            row = 0;    //Console.WriteLine("1"); 
            int col = 0;
            for (int i = 0; i < this.NumStudent * this.NumCourse; i++)
            {

                TextBox1 = new TextBox();
                TextBox1.Text = "";
                TextBox1.Multiline = true;
                TextBox1.Size = new Size(100, 20);

                int LocationX = TextBox1.Location.X;
                int LocationY = TextBox1.Location.Y;
                int TWidth = TextBox1.Width;
                int THeight = TextBox1.Height;


                //for (int j = 0; j < this.NumCourse; j++)
                //{
                //    TextBox1.Location = new Point(50 + (TWidth + 10) * (j % this.NumCourse), 50 + (THeight + 10) * row);
                //}
                if (col < this.NumCourse)
                {
                    TextBox1.Location = new Point(50 + (TWidth + 10) * (col % this.NumCourse), 50 + (THeight + 10) * row);
                    col++;

                }
                if (col == this.NumCourse)
                {
                    col = 0;
                    row++;
                };

                TextBox1.Name = "TextBox" + i.ToString();

                this.panelForGrade.Controls.Add(TextBox1);

            }


        }

        private void buttonGetResult_Click(object sender, EventArgs e)
        {
            //读入数据
            this.buttonGetResult.Enabled = false;
            this.buttonCalculate.Enabled = true;
            Control control = null;
            int StuRow = 0; //行
            int CouCol = 0; //列
            //int k = 0; //计数
            for (int i = 0; i < NumCourse * NumStudent; i++)
            {
                string tempName = "TextBox";
                tempName = tempName + i.ToString();

                //CouCol = 0;
                foreach (Control item in this.panelForGrade.Controls)
                {

                    control = GetControl(tempName, item);
                    if (control == null)
                    {
                        MessageBox.Show("有textbox名称出错.");
                        return;
                    }
                    else
                    {
                        if (i >= StuRow * NumCourse && i < (StuRow + 1) * NumCourse)
                        {
                            this.ScoreAll[StuRow, CouCol] = Convert.ToDouble(control.Text);
                            CouCol++;
                            break;
                        }
                        if (i != 0 && i % this.NumCourse == 0)
                        {
                            StuRow++;
                            CouCol = 0;
                        }
                    }


                }
                //把数组赋值到Student类中


            }
            //for (int j = 0; j < this.NumStudent; j++)
            //{
            //    for (int k = 0; k < this.NumCourse; k++)
            //    {
            //        Console.Write(this.ScoreAll[j, k].ToString() + "-");
            //    }
            //    Console.WriteLine();
            //}
            

            for (int i = 0; i < this.NumStudent; i++)
            {
                for (int j = 0; j < this.NumCourse; j++)
                {
                    this.studentAllForm3[i].EachCourseScore[j] = this.ScoreAll[i, j];
                   // Console.Write(this.studentAllForm3[i].EachCourseScore[j].ToString() + "-");
                }
                //Console.WriteLine();
            }
            MessageBox.Show("读取完毕");
        }

        private Control GetControl(string name, Control parent)
        {
            foreach (Control Item in this.panelForGrade.Controls)
            {
                if (Item.Name == name)
                {
                    return Item;
                }
            }
            return null;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            this.buttonGetResult.Enabled = true;
            double TotalCredit = 0;

            for (int i = 0; i < this.NumStudent; i++)
            {
                TotalCredit = 0;
                for (int j = 0; j < this.NumCourse; j++)
                {

                    this.studentAllForm3[i].AverageGPA += this.studentAllForm3[i].EachCourseScore[j] * this.courseAllForm3[j].Credit;
                    TotalCredit += this.courseAllForm3[j].Credit;
                }
                this.studentAllForm3[i].AverageGPA /= TotalCredit;
            }

            MessageBox.Show("计算完毕，结果见输出");
            for (int i = 0; i < this.NumStudent; i++)
            {
                Console.WriteLine(this.studentAllForm3[i].StudentName + ": " + this.studentAllForm3[i].AverageGPA.ToString());
                this.studentAllForm3[i].Clear();
            }
        }
    }
}
