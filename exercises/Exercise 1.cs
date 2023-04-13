namespace ConsoleExercise
{
    class Exercise1 : ExerciseBase
    {
        public int number1;
        public int number2;
        public int result;

        public void setNumber1() {
            int.TryParse(Console.ReadLine(), out this.number1);
        }

        public void setNumber2() {
            int.TryParse(Console.ReadLine(), out this.number2);
        }

        public int setResult() {
            this.result = this.number1 + this.number2;
            return this.result;
        }
        public override void execute() {
            Console.Clear();
            Exercise1 exercise = new Exercise1();

            Console.Write(
                "\n \t Exercício 1 - Some dois números!" +
                "\n \n \t Escolha o primeiro número: "
                );
            
            exercise.setNumber1();

            Console.Write(
                "\n \t Digite o segundo número: "
            );

            exercise.setNumber2();

            Console.Write(
                "\n \t O resultado da soma: " + 
                exercise.number1 + " + " + exercise.number2 +
                " = " + exercise.setResult() + "\n \n \n"
                );

        }
    }
}