using System.ComponentModel.DataAnnotations;

namespace a
{
    public class Student
    {
        [Key]
        public string ID { get; set; }
        public string name { get; set; }
        public double grade { get; set; }
        public int gradeLevel { get; set; }

        public Student() { }// defines an empty constructor function

        public override string ToString()
        {
            return $"{this.name}({this.ID}), Grade: {this.grade:F2} (Level {this.gradeLevel})";
        }

        public int GetGradeLevel()
        {
            if (this.grade >= 80)
            {
                this.gradeLevel = 1;
            }
            else if (this.grade >= 65)
            {
                this.gradeLevel = 2;
            }
            else
            {
                this.gradeLevel = 3;
            }
            return gradeLevel;
        }
    }
}