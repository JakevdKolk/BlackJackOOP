namespace BlackJackOOP
{
    internal class handleGame
    {

        public int grade { get; set; }
        public handleGame()
        {
            grade = 10;
        }

        

        public void calcGrade()
        {
            grade = grade - 1;
        }
        public int getGrade()
        {
            Console.WriteLine("grade is " + grade);
            return grade;
        }
    }
}