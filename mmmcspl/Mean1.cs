using System;
using System.Collections.Generic;
using System.Linq;

namespace mmmcspl
{
    public class Mean1
    {
        public double ComputeMeanPeriod(List<double> grades)
        {
            double total = 0;
            foreach (var grade in grades)
            {
                total += grade;
            }
            return total / grades.Count;
        }

        public (double prelimMean, double midtermMean, double finalsMean) ComputeMeanPeriod(List<student> students)
        {
            List<double> prelimGrades = new List<double>();
            List<double> midtermGrades = new List<double>();
            List<double> finalsGrades = new List<double>();

            foreach (var student in students)
            {
                prelimGrades.Add(student.Prelim);
                midtermGrades.Add(student.Midterm);
                finalsGrades.Add(student.Finals);
            }

            double prelimMean = ComputeMeanPeriod(prelimGrades);
            double midtermMean = ComputeMeanPeriod(midtermGrades);
            double finalsMean = ComputeMeanPeriod(finalsGrades);

            return (prelimMean, midtermMean, finalsMean);
        }
        public List<double> ComputeFinalAverages(List<student> students)
        {
            List<double> finalAverages = new List<double>();

            foreach (var student in students)
            {
                double finalAverage = (student.Prelim + student.Midterm + student.Finals) / 3.0;
                finalAverages.Add(finalAverage);
            }

            return finalAverages;
        }
    }
}





           