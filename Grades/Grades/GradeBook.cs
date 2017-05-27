using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        List<float> grades;
        public GradeBook()
        {
            grades = new List<float>();
        }


        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in grades)
            {
                //if (grade > stats.HighestGrade)
                //{
                //    stats.HighestGrade = grade;
                //}
                stats.HighestGrade = Math.Max(stats.HighestGrade, grade);
                stats.LowestGrade = Math.Min(stats.LowestGrade, grade);
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;

            return stats;
        }
    }
}
