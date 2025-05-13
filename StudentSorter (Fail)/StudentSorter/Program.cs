namespace StudentSorter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student("Gosho", 3.50),
                new Student("Ivan", 6),
                new Student("Pesho", 2.66),
                new Student("Boqn", 4.30),
                new Student("Asen", 2)

            };

           

            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].ToString());


            }

            StudentSort.Sort(students);

        }
    }
}
