using System;
using System.Collections.Generic;
using System.Text;


namespace _09022021
{
    class Student
    {
        public Dictionary<string, int> MarksBySubject;
        public double FindExerciseAverage()
        {
            int i = 0;
            int sum = 0;
            foreach(int item in this.MarksBySubject.Values)
            {
                sum += item;
            }
            return sum / this.MarksBySubject.Count;
        }
        public void AddExercise(string exercise,int mark)
        {
            this.MarksBySubject.Add(exercise, mark);
        }
        public Student()
        {
            this.MarksBySubject = new Dictionary<string, int>(0);
        }

    }
}
