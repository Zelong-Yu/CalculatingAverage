using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopContinue = true;
            while (loopContinue)
            {
                DisplayMenu();
                if (Int32.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            TenNumSum();
                            break;
                        case 2:
                            TenScoresAvg();
                            break;
                        case 3:
                            Specific();
                            break;
                        case 4:
                            nonSpecific();
                            break;
                        case 5:
                            DisplayGradeScale();
                            break;
                        case 6:
                            fizzBuzz(100);
                            break;
                        case 0:
                            loopContinue = false;
                            Console.WriteLine("Hit any key to exit.");
                            break;
                        // Any other integer selection, asked to put in valid input
                        default:
                            loopContinue = true;
                            Console.WriteLine("Please enter a valid input. ");
                            break;

                    }
                }
                Console.WriteLine("Hit any key to continue.");
                Console.ReadKey();
            }
        }

        static void TenNumSum()
        {
            //Sum ten numbers between 0 and 100
            int n = 10;
            Console.WriteLine($"Put in each of the {n} numbers between 0 and 100 and Enter after each entry. Invalid entry will be ignored");
            List<double> scoreList = new List<double>();
            for (int i = 0; i < n;)
            {
                if (Double.TryParse(Console.ReadLine(), out double s) && s >= 0 && s <= 100)
                {
                    scoreList.Add(s);
                    i++;//only valid input increases loop index
                }
                else
                {
                    Console.WriteLine("Put a valid score between 0 and 100 and hit enter: ");
                }
            }
            //double sum = scoreList.Sum();
            //Console.WriteLine("Numeric Sum: {0}", sum);
            double recSum = RecursiveSum(scoreList);
            Console.WriteLine("Numeric Sum: {0}", recSum);
        }

        static void TenScoresAvg()
        {
            //Average ten scores between 0 and 100
            int n = 10;
            Console.WriteLine($"Put in each of the {n} scores between 0 and 100 and Enter after each entry. Invalid entry will be ignored");
            List<double> scoreList = new List<double>();
            for (int i = 0; i < n;)
            {
                if (Double.TryParse(Console.ReadLine(), out double s) && s >=0 && s <=100)
                {
                    scoreList.Add(s);
                    i++;//only valid input increases loop index
                }
                else
                {
                    Console.WriteLine("Put a valid score between 0 and 100 and hit enter: ");
                }
            }
            //double avg = scoreList.Average();
            //Console.WriteLine("Numeric Average: {0:F2}, Letter Grade {1}", avg, letterGrade(avg));
            double reCursiveAvg = RecursiveAvg(scoreList);
            Console.WriteLine("Numeric Average: {0:F2}, Letter Grade {1}", reCursiveAvg, letterGrade(reCursiveAvg));
        }
        static void Specific()
        {
            //Average a specific number of scores
            Console.WriteLine("How many scores are you putting in?");

            //Ask user how many scores to put
            int n; //declare to-be-specify number of scores n
            while (!Int32.TryParse(Console.ReadLine(), out n) || n<=0) //only accept positive integer input
            {
                Console.WriteLine("Put a valid positive integer number and hit enter: ");
            }

            Console.WriteLine($"Put in each of the {n} scores and Enter after each entry. Invalid entry will be ignored");
            List<double> scoreList = new List<double>();
            for (int i=0; i<n;)
            {
                if (Double.TryParse(Console.ReadLine(), out double s) && s >= 0 && s <= 100)
                {
                    scoreList.Add(s);
                    i++;  //only valid input increases loop index
                }
                else
                {
                    Console.WriteLine("Put a valid score between 0 and 100 and hit enter: ");
                }
            }
            //double avg = scoreList.Average();
            //Console.WriteLine("Numeric Average: {0:F2}, Letter Grade {1}", avg, letterGrade(avg));
            double reCursiveAvg = RecursiveAvg(scoreList);
            Console.WriteLine("Numeric Average: {0:F2}, Letter Grade {1}", reCursiveAvg, letterGrade(reCursiveAvg));
        }

        static void nonSpecific() 
        {
            //Average a non-specific number of scores
            Console.WriteLine("Put in a score and Enter. To Stop, type -1 and enter."); //Integer Average shows how error propagates if int type is used in the recursive average method
            List<double> scoreList = new List<double>();
            //List<int> intscoreList = new List<int>();
            while (Double.TryParse(Console.ReadLine(),out double s) && s != -1)
            {
                if (s >= 0 && s <= 100)
                {
                    scoreList.Add(s);
                    //Console.WriteLine(String.Join("; ", scoreList));
                    //intscoreList.Add((int)s);
                    //Console.WriteLine(String.Join("; ", intscoreList));
                    //double avg = scoreList.Average();
                    //Console.WriteLine("Numeric Average: {0:F2}, Letter Grade {1}", avg, letterGrade(avg));
                    double reCursiveAvg = RecursiveAvg(scoreList);
                    Console.WriteLine("Numeric Average: {0:F2}, Letter Grade {1}", reCursiveAvg, letterGrade(reCursiveAvg));
                    //int recursiveIntAvg = TestIntRecursiveAvg(intscoreList);
                    //Console.WriteLine("Integer Average: {0}, Letter Grade {1}", recursiveIntAvg, letterGrade(recursiveIntAvg));

                }
                else
                {
                    Console.WriteLine("Please put in valid score between 0 and 100.");
                }
            }
        }

        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Exercise 2A Calculating Averages");
            Console.WriteLine("Make a selection 0-5 and hit enter. Invalid input will bring you back to main menu.");
            Console.WriteLine("1. Sum of 10 numbers");
            Console.WriteLine("2. Average ten scores");
            Console.WriteLine("3. Average a specific number of scores");
            Console.WriteLine("4. Average a non-specific number of scores");
            Console.WriteLine("5. Display Letter Grade Scale");
            Console.WriteLine("6. fizzBuzz");
            Console.WriteLine("0. Quit");
        }
        static void DisplayGradeScale()
        {
            Console.WriteLine("Letter Grade   Percent Grade");
            Console.WriteLine("A+             97-100");
            Console.WriteLine("A              93-96.99");
            Console.WriteLine("A-             90-92.99");
            Console.WriteLine("B+             87-89.99");
            Console.WriteLine("B              83-86.99");
            Console.WriteLine("B-             80-82.99");
            Console.WriteLine("C+             77-79.99");
            Console.WriteLine("C              73-76.99");
            Console.WriteLine("C-             70-72.99");
            Console.WriteLine("D+             67-69.99");
            Console.WriteLine("D              65-66.99");
            Console.WriteLine("E/F            Below 65");
        }
        static double RecursiveSum(List<double> L)
        {
            //Customized method to calculate sum of a list of doubles
            int length = L.Count;
            double Helper(List<double> List, int i)
            {
                double result;
                result = List[i];
                if (i == 0) return result;
                else return result + Helper(List, i - 1);
            }
            return Helper(L, length - 1);  //index of list starts with 0 so use length-1
        }

        static int TestIntRecursiveAvg(List<int> L)
        {
            //This is used to test aggrevating error when int type is used
            int length = L.Count;
            int Helper(List<int> List, int i)
            {
                int result;
                result = List[i] / List.Count; ;
                //Console.Write(result.ToString()+' ');
                if (i == 0) return result;
                else return result + Helper(List, i - 1);
            }
            return Helper(L, length - 1);  //index of list starts with 0 so use length-1
        }

        static double RecursiveAvg(List<double> L)
        {
            //Customized method to calculate average of a list of doubles
            int length = L.Count;        
            double Helper(List<double> List, int i)
            {
                double result;
                result = List[i] / List.Count;
                //Console.Write(result.ToString() + ' ');
                if (i == 0) return result;
                else return result + Helper(List, i - 1);
            }
            return Helper(L, length-1);  //index of list starts with 0 so use length-1
        }

        static void fizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string test = "";
                test += (i % 3 == 0 ? "fizz" : "");
                //i % 5 == 0 ? test += "buzz" : test += ""; 
                test += i % 5 == 0 ? "buzz" : "";
                //string output = "";
                //output += test == "" ? i.ToString() : test;
                Console.Write((test == "") ? i.ToString()+", " : test+", ");
            }
        }

        static string letterGrade(double score)
        {
            //convert numerical grade to letter grade
            string L;
            if (score >= 97)
            {
                L = "A+";
            }
            else if (score >=93)
            {
                L = "A";
            }
            else if (score >= 90)
            {
                L = "A-";
            }
            else if (score >= 87)
            {
                L = "B+";
            }
            else if (score >= 83)
            {
                L = "B";
            }
            else if (score >= 80)
            {
                L = "B-";
            }
            else if (score >= 77)
            {
                L = "C+";
            }
            else if (score >= 73)
            {
                L = "C";
            }
            else if (score >= 70)
            {
                L = "C-";
            }
            else if (score >= 67)
            {
                L = "D+";
            }
            else if (score >= 65)
            {
                L = "D";
            }
            else
            {
                L = "E/F";
            }
            return L;
        }
    }
}
