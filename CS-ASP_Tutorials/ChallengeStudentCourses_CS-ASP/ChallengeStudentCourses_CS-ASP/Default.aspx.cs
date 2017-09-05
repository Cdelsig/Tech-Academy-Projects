using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses_CS_ASP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                resultLabel.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */

            List<Course> courses = new List<Course>() {
                new Course { CourseID = 100, CourseName = "Potions", Students = new List<Student>() {
                    new Student {StudentID = 1, StudentName = "Harry Potter"},
                    new Student {StudentID = 2, StudentName = "Hermione Granger"}} },
                new Course { CourseID = 200, CourseName = "Transfiguration", Students = new List<Student>() {
                    new Student {StudentID = 3, StudentName = "Ron Weasley"},
                    new Student {StudentID = 4, StudentName = "Neville Longbottom"}} },
                new Course {CourseID = 300, CourseName = "Defense Against the Dark Arts", Students = new List<Student>() {
                    new Student {StudentID = 5, StudentName = "Draco Malfoy"},
                    new Student {StudentID = 6, StudentName = "Luna Lovegood"}} }
                };
            foreach (var course in courses)
            {
                resultLabel.Text += String.Format("<br />Course: {0} -- {1} <br />",
                    course.CourseID,
                    course.CourseName);

                foreach (var student in course.Students)
                {
                    resultLabel.Text += String.Format("** Student: {0} - {1}<br />",
                        student.StudentID,
                        student.StudentName);
                };
            };
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */

            Course course1 = new Course() { CourseID = 100, CourseName = "Potions" };
            Course course2 = new Course() { CourseID = 200, CourseName = "Transfiguration" };
            Course course3 = new Course() { CourseID = 300, CourseName = "Defense Against the Dark Arts" };

            Dictionary<int, Student> students = new Dictionary<int, Student>() {

                { 1, new Student {StudentID = 1, StudentName = "Harry Potter", Courses = new List<Course> {course1, course2 }} },
                { 2, new Student {StudentID = 2, StudentName = "Hermione Granger", Courses = new List<Course> {course2, course3}} },
                { 3, new Student {StudentID = 3, StudentName = "Ron Weasley", Courses = new List<Course> {course1, course3}} }

            };

            foreach (var student in students)
            {
                resultLabel.Text += String.Format("<br />Student: {0} -- {1}<br />", student.Key, student.Value.StudentName);

                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("**Course: {0} -- {1}<br />", course.CourseID, course.CourseName);
                };

            };

        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */

            List<Student> students = new List<Student>() {
                new Student {StudentID = 1, StudentName = "Harry Potter", Schedules = new List<Schedule>() {
                    new Schedule {CourseID = 100, CourseName = "Potions", Grade = 68},
                    new Schedule {CourseID = 200, CourseName = "Transfiguration", Grade = 100} } },
                new Student {StudentID = 2, StudentName = "Hermione Granger", Schedules = new List<Schedule>() {
                    new Schedule {CourseID = 200, CourseName = "Transfiguration", Grade = 98},
                    new Schedule {CourseID = 300, CourseName = "Defense Against the Dark Arts", Grade = 97 } } },
               new Student {StudentID = 3, StudentName = "Ron Weasley", Schedules = new List<Schedule>() {
                    new Schedule {CourseID = 100, CourseName = "Potions", Grade = 55},
                    new Schedule {CourseID = 300, CourseName = "Defense Against the Dark Arts", Grade = 76 } } }
            };

            foreach (var student in students)
            {
                resultLabel.Text += String.Format("<br />Student: {0} -- {1}<br />", student.StudentID, student.StudentName);

                foreach (var schedule in student.Schedules)
                {
                    resultLabel.Text += String.Format("**Course: {0} -- {1} -- Grade: {2} <br />", schedule.CourseID, schedule.CourseName, schedule.Grade);
                };

            };

        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public List<Course> Courses { get; set; }
        public List<Schedule> Schedules { get; set; }
    }

    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public List<Student> Students { get; set; }
    }

    public class Schedule
    {
        public int Grade { get; set; }
        public Student student { get; set; }
        public int CourseID { get; set; }
        public string CourseName { get; set; }
    }
}

    
