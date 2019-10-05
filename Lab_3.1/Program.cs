/*Zadanie ze srednia ucznia - napisac program, ktory pomaga policzyc srednia dla danego ucznia, jeden przedmiot, nie wiemy ile
bedzie ocen. Średnia arytmetyczna*/

using System;
using System.Text;

namespace Lab_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Funkcje obiekt = new Funkcje();
            
            StringBuilder builder = new StringBuilder();

            string text = "@";
            float sum = 0;
            float result = 0;

            while (text != string.Empty)
            {
                text = Console.ReadLine();
                builder.Append(text + ";");
            }

            string gradesString = builder.ToString();
            string[] grades = gradesString.Split(";", StringSplitOptions.RemoveEmptyEntries);

            float[] gradesInt = new float[grades.Length];

            for (int i = 0; i < grades.Length; i++)
            {
                gradesInt[i] = Convert.ToSingle(grades[i]);
            }

            foreach (float grade in gradesInt)
            {
                sum += grade;
            }

            result = obiekt.ObliczSrednia(sum, gradesInt.Length);
            double result2 = System.Math.Round(result, 2);
            Console.WriteLine(result2);
        }
    }
}