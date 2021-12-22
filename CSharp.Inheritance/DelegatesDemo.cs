using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    //class teacher and evaluator are 2 parties.. and the delegate promote helper acts as a communicator b/w these 2 parties.
    public class ClassTeacher
    {
        public void StartEvaluating()
        {
            Evaluator eval = new Evaluator();
            eval.MakeValuationOfMarks(PromoteStudent);
        }
        public void PromoteStudent(Student std)
        {
            if (std.MarksInLanguages > 250 && std.MarksInMaths > 40)
                Console.WriteLine(std.Name + " Passed");
            else
                Console.WriteLine(std.Name + " Failed");

        }
    }
    public class Evaluator
    {
        public Student std = new Student { MarksInChemistry = 40, MarksInPhysics = 60, MarksInMaths = 39, MarksInLanguages = 280, Name = "Arun",IsAnswerPaperIntact=true };
        public delegate void PromoteHelper(Student std);
        public void MakeValuationOfMarks(PromoteHelper phm)
        {
            if(std.IsAnswerPaperIntact)
                phm(std);
        }


    }
    public class Student
    {
        public string Name { get; set; }
        public int MarksInLanguages { get; set; }
        public int MarksInMaths { get; set; }
        public int MarksInPhysics { get; set; }
        public int MarksInChemistry { get; set; }
        public bool IsAnswerPaperIntact { get; set; }
    }

}
