using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace IntegrativeTestSystem
{
    static public class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            

        }

        /// <summary>
        /// 课程类型 分为分数型与评价型
        /// </summary>
        //public enum CourseType { SCORE = 0, JUDEG = 1 };

        /// <summary>
        /// 当课程类型为评价型时，分为五个等级 每个等级对应不同分数
        /// </summary>
        public enum JudgeToScore { FAIL = 0, PASS = 1, MEDIUM = 2, WELL = 3, GOOD = 4 };

        /// <summary>
        /// 课程类 名称、类型、包括学分数
        /// </summary>
        public class Course
        {
            public string CourseName;  //课程名称
            public int courseType;      //课程类型
            public double Credit;              //学分

            //构造函数
            public Course(string w_name, int w_type, double w_credit)
            {
                this.CourseName = w_name;
                this.courseType = w_type;
                this.Credit = w_credit;
            }

            public Course(Course course)
            {
                this.CourseName = course.CourseName;
                this.courseType = course.courseType;
                this.Credit = course.Credit;
            }

        }

        /// <summary>
        /// 学生类 姓名 学号 课程数 与 总分
        /// </summary>
        public class Student
        {
            public string StudentName; //学生姓名
            public string StudentNum; //学生学号
            public int CourseTotalNum; //学生总共选择课程数，不同的学生可能有不同数量的课程
            public double[] EachCourseScore; //每门课的成绩 数组
            public double AverageGPA; //每个人的总分

            //构造函数

            public Student()
            {
                this.StudentName = "";
                this.StudentNum = "";
                this.CourseTotalNum = 0;
                this.AverageGPA = 0.0;
                this.EachCourseScore = new double[MainForm.MAXSTUDENT];

                for (int i = 0; i < this.CourseTotalNum; i++)
                {
                    this.EachCourseScore[i] = 0.0;
                }
            }

            public Student(string w_name, string w_num, int w_courseNum)
            {
                this.StudentName = w_name;
                this.StudentNum = w_num;
                this.CourseTotalNum = w_courseNum;
                this.AverageGPA = 0.0;
                this.EachCourseScore = new double[MainForm.MAXSTUDENT];

                for (int i = 0; i < this.CourseTotalNum; i++)
                {
                    this.EachCourseScore[i] = 0.0;
                }
            }

            public Student(Student s)
            {
                this.StudentName = s.StudentName;
                this.StudentNum = s.StudentNum;
                this.CourseTotalNum = s.CourseTotalNum;
                this.EachCourseScore = new double[MainForm.MAXSTUDENT];
                for (int i = 0; i < this.CourseTotalNum; i++)
                {
                    this.EachCourseScore[i] = s.EachCourseScore[i];
                }
                this.AverageGPA = s.AverageGPA;
            }

            //读取每门课成绩到EachCourseScore的值
            public void ReadScore(double[] w_eachCourseScore)
            {
                if (w_eachCourseScore == null)
                {
                    Console.WriteLine("学号为"+ this.StudentNum.ToString() +"的学生没有成绩");
                }

                for (int i = 0; i < this.CourseTotalNum; i++)
                {
                    this.EachCourseScore[i] = w_eachCourseScore[i];
                }
            }

            public void Clear()
            {
                this.AverageGPA = 0;
            }

            //
        }

    }
}
