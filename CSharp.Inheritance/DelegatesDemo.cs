namespace CSharpConcepts
{

    public class Usage
    {
        static void Main()
        {
            ClassTeacher teacher = new ClassTeacher();
            Student student = new Student { MarksInChemistry = 40, MarksInPhysics = 60, MarksInMaths = 39, MarksInLanguages = 280, Name = "Arun", IsAnswerPaperIntact = true };
            teacher.EvaluateMarks(student);
        }
    }

    //class teacher and evaluator are 2 parties.. and the delegate promote helper acts as a communicator b/w these 2 parties.
    public class ClassTeacher
    {
        public delegate void EvaluationHelper(Student std);

        public void EvaluateMarks(Student student)
        {
            //delegated the evaluation process.
            EvaluationHelper evaluationHelper = Evaluator.EvaluateStudent;
            evaluationHelper.Invoke(student);
        }

        public void MarkAttendance()
        {

        }

        public void TakeLecture()
        {

        }
        
        public void ConductTest()
        {

        }
    }
    public class Evaluator
    {

        public static void EvaluateStudent(Student std)
        {
            if (std.MarksInLanguages > 250 && std.MarksInMaths > 40)
                Console.WriteLine(std.Name + " Passed");
            else
                Console.WriteLine(std.Name + " Failed");

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
