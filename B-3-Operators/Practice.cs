using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_3_Operators
{
    public partial class Practice
    {

        /// <summary>
        /// B3-P1/5. NumbersAddition. Напишите алгоритм, который складывает два числа.
        /// </summary>
        #region

        public static void B3_P1_9_NumbersAddition()
        {
            //int a = NumberHolder.x; //one more option to do this task
            //int b = NumberHolder.y; //one more option to do this task
            //int result = Sum(a,b); //one more option to do this task
            //Console.WriteLine(result); //one more option to do this task 
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            string operatorToAdd = Console.ReadLine();
            int actualResult = Sum(a, b);
            Console.WriteLine(actualResult);

        }

        public static int Sum(int a, int b)
        {
            int c = a + b;
            return c;
        }

        public static int AdditivOperation(int a, int b, string additivityOperator)
        {
            if (additivityOperator == "-")
            {

                return a - b;
            }
            else if (additivityOperator == "+")
            {
                return a + b;
            }
            else
            {
                throw new System.ArgumentException("Operator is incorrect", "additivityOperator");
            }

        }
        public static int SumFiveNumbers(int a, int b, int c, int d, int e)

        {
            int Sum = a;
            Sum += b;
            Sum += c;
            Sum += d;
            Sum += e;
            return Sum;
        }
        public static int CountAreaOfCircle(double p, int R)
        {
            int S = Convert.ToInt32(p * R);
            return S;
        }

        public static int CountSumToPayEveryMonthsForBasicLoan (int sumOfCredit)
        {
            int sumToPayEveryMonthsForBasicLoan = sumOfCredit / 12;
            return sumToPayEveryMonthsForBasicLoan;

        }

        public static int CountSumByMonths(int sumOfCredit, int sumToPayEveryMonthsForBasicLoan, int percentsOfCredit, int numberOfdaysInMonthsOfPayment)
        {
            int sumByMonths = Convert.ToInt32((sumOfCredit - sumToPayEveryMonthsForBasicLoan) * percentsOfCredit / 365 * numberOfdaysInMonthsOfPayment);
            return sumByMonths;
        }

        public static int CountOverallSumOfCredit(int sumToPayEveryMonthsJanuary,int sumToPayEveryMonthsFebruary,int sumToPayEveryMonthsMarch, int sumToPayEveryMonthsApril, int sumToPayEveryMonthsMay, int sumToPayEveryMonthsJune, int sumToPayEveryMonthsJuly, int sumToPayEveryMonthsAugust, int sumToPayEveryMonthsSeptember,int sumToPayEveryMonthsOctober, int sumToPayEveryMonthsNovember, int sumToPayEveryMonthsDecember)
        {
            int overallSumOfCredit = sumToPayEveryMonthsJanuary;
            overallSumOfCredit += sumToPayEveryMonthsFebruary;
            overallSumOfCredit += sumToPayEveryMonthsMarch;
            overallSumOfCredit += sumToPayEveryMonthsApril;
            overallSumOfCredit += sumToPayEveryMonthsMay;
            overallSumOfCredit += sumToPayEveryMonthsJune;
            overallSumOfCredit += sumToPayEveryMonthsJuly;
            overallSumOfCredit += sumToPayEveryMonthsAugust;
            overallSumOfCredit += sumToPayEveryMonthsSeptember;
            overallSumOfCredit += sumToPayEveryMonthsOctober;
            overallSumOfCredit += sumToPayEveryMonthsNovember;
            overallSumOfCredit += sumToPayEveryMonthsDecember;

            return overallSumOfCredit;
        }
#endregion

        /// <summary>
        /// B3-P2/9. CheckResultAddition. Изменить предыдущий алгоритм. 
        /// Пускай он теперь не выводит ответ сам. 
        /// А запрашивает ответ и потом проверяет его на правильность.
        /// </summary>
        public static void B3_P2_9_CheckResultAddition()
        {
            int a = NumberHolder.x;
            int b = NumberHolder.y;
            int result = Sum(a, b);
            Console.WriteLine(result == 11);
        }

        /// <summary>
        /// B3-P3/9. CheckResultAdditionWithTips. Изменить предыдущий алгоритм. 
        /// Пускай он теперь выводит не только информацию правильно или не правильно, 
        /// но и дополнительно, 	ожидается число больше или меньше указанного.
        /// </summary>
        public static void B3_P3_9_CheckResultAdditionWithTips()
        {
            int a = NumberHolder.x;
            int b = NumberHolder.y;
            int result = Sum(a, b);
            Console.WriteLine("when result is correct:" + (result == 11));
            string tips = (result > 11) ? "The value should be greater" : "The value should be less";
            Console.WriteLine(tips);
        }

        /// <summary>
        /// B3-P4/9. CheckResultWithOperator. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм теперь запрашивает оператор (+ или -).
        /// </summary>
        public static void B3_P4_9_CheckResultWithOperator()
        {
            int a = NumberHolder.x;
            int b = NumberHolder.y;
            string additivityOperator = NumberHolder.additivityOperator;
            //int result = Sum(a, b);
            int result = AdditivOperation(a, b, additivityOperator);
            Console.WriteLine("when result is correct:" + (result == 11));
            string tips = (result > 11) ? "The value should be greater" : "The value should be less";
            Console.WriteLine(tips);
        }

        /// <summary>
        /// B3-P5/9. CheckResultWithAttemps. Изменить предыдущий алгоритм. 
        /// Пускай у пользователя будет 3 попытки чтобы решить эту задачу правильно
        /// </summary>
        public static void B3_P5_9_CheckResultWithAttemps()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            string operatorToAdd = Console.ReadLine();
            int expectedResult = Convert.ToInt32(Console.ReadLine());
            int actualResult = AdditivOperation(a, b, operatorToAdd);
            bool resultCorrect = actualResult == expectedResult;
            Console.WriteLine("when result is correct:" + resultCorrect);
            int numberOfAttempts = 1;
            while (!resultCorrect || numberOfAttempts < 3)
            {
                string tips = (actualResult > expectedResult) ? "The value should be greater" : "The value should be less";
                Console.WriteLine(tips);
                expectedResult = Convert.ToInt32(Console.ReadLine());
                resultCorrect = actualResult == expectedResult;
                Console.WriteLine("when result is correct:" + resultCorrect);
                numberOfAttempts++;
            }
        }

        /// <summary>
        /// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм складывает пять чисел вместо двух.
        /// </summary>
        public static void B3_P6_9_FiveNumbersAddition()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            int expectedResult = Convert.ToInt32(Console.ReadLine());
            int actualResult = SumFiveNumbers(a, b, c, d, e);
            bool resultCorrect = actualResult == expectedResult;
            Console.WriteLine("when result is correct:" + resultCorrect);
            int numberOfAttempts = 1;
            while (!resultCorrect || numberOfAttempts < 3)
            {
                string tips = (actualResult > expectedResult) ? "The value should be greater" : "The value should be less";
                Console.WriteLine(tips);
                expectedResult = Convert.ToInt32(Console.ReadLine());
                resultCorrect = actualResult == expectedResult;
                Console.WriteLine("when result is correct:" + resultCorrect);
                numberOfAttempts++;
            }
        }

        /// <summary>
        /// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
        /// В конце алгоритма выводить информацию была ли задача решена правильно.
        /// </summary>
        public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            int expectedResult = Convert.ToInt32(Console.ReadLine());
            int actualResult = SumFiveNumbers(a, b, c, d, e);
            bool resultCorrect = actualResult == expectedResult;
            Console.WriteLine("when result is correct:" + resultCorrect);
            int numberOfAttempts = 1;
            while (!resultCorrect || numberOfAttempts < 3)
            {
                string tips = (actualResult > expectedResult) ? "The value should be greater" : "The value should be less";
                Console.WriteLine(tips);
                expectedResult = Convert.ToInt32(Console.ReadLine());
                resultCorrect = actualResult == expectedResult;
                Console.WriteLine("when result is correct:" + resultCorrect);
                numberOfAttempts++;
            }
            Console.WriteLine("result of task is correct when:" + (resultCorrect = Convert.ToBoolean(actualResult & expectedResult)));

        }

        /// < summary >
        /// B3 - P8 / 9.CircleArea.Написать алгоритм, рассчитывающий площадь круга по заданному радиусу. 
        /// </ summary >
        public static void B3_P8_9_CircleArea()
        {
            Console.WriteLine("Insert the radius of a circle:");
            int R = Convert.ToInt32(Console.ReadLine());
            double p = Convert.ToInt32(3.1415);
            //S= (pR)(pR)
            int circleArea = CountAreaOfCircle(p, R);
            Console.WriteLine("The area of circle is:" + circleArea);
        }

        /// <summary>
        /// B3-P9/9. CreaditCalculator.Написать программу - калькулятор кредита на 1 год.
        /// </summary>
        public static void B3_P9_9_CreaditCalculator()
        {
            Console.WriteLine("Insert sum of credit:");
           
            int sumOfCredit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert credit percents:");
            int percentsOfCredit = Convert.ToInt32(Console.ReadLine());

            int numberOfdaysInMonthsOfPaymentJanuary = 31;
            int numberOfdaysInMonthsOfPaymentFebruary = 28;
            int numberOfdaysInMonthsOfPaymentMarch = 31;
            int numberOfdaysInMonthsOfPaymentApril = 30;
            int numberOfdaysInMonthsOfPaymentMay = 31;
            int numberOfdaysInMonthsOfPaymentJune = 30;
            int numberOfdaysInMonthsOfPaymentJuly = 31;
            int numberOfdaysInMonthsOfPaymentAugust = 31;
            int numberOfdaysInMonthsOfPaymentSeptember = 30;
            int numberOfdaysInMonthsOfPaymentOctober = 31;
            int numberOfdaysInMonthsOfPaymentNovember = 30;
            int numberOfdaysInMonthsOfPaymentDecember = 31;

            int sumToPayEveryMonthsForBasicLoan = CountSumToPayEveryMonthsForBasicLoan(sumOfCredit);

            int sumToPayEveryMonthsJanuary = CountSumByMonths(sumOfCredit, sumToPayEveryMonthsForBasicLoan, percentsOfCredit, numberOfdaysInMonthsOfPaymentJanuary);
            int sumToPayEveryMonthsFebruary = CountSumByMonths(sumOfCredit, sumToPayEveryMonthsForBasicLoan, percentsOfCredit, numberOfdaysInMonthsOfPaymentFebruary);
            int sumToPayEveryMonthsMarch = CountSumByMonths(sumOfCredit, sumToPayEveryMonthsForBasicLoan, percentsOfCredit, numberOfdaysInMonthsOfPaymentMarch);
            int sumToPayEveryMonthsApril = CountSumByMonths(sumOfCredit, sumToPayEveryMonthsForBasicLoan, percentsOfCredit, numberOfdaysInMonthsOfPaymentApril);
            int sumToPayEveryMonthsMay = CountSumByMonths(sumOfCredit, sumToPayEveryMonthsForBasicLoan, percentsOfCredit, numberOfdaysInMonthsOfPaymentMay);
            int sumToPayEveryMonthsJune = CountSumByMonths(sumOfCredit, sumToPayEveryMonthsForBasicLoan, percentsOfCredit, numberOfdaysInMonthsOfPaymentJune);
            int sumToPayEveryMonthsJuly = CountSumByMonths(sumOfCredit, sumToPayEveryMonthsForBasicLoan, percentsOfCredit, numberOfdaysInMonthsOfPaymentJuly);
            int sumToPayEveryMonthsAugust = CountSumByMonths(sumOfCredit, sumToPayEveryMonthsForBasicLoan, percentsOfCredit, numberOfdaysInMonthsOfPaymentAugust);
            int sumToPayEveryMonthsSeptember = CountSumByMonths(sumOfCredit, sumToPayEveryMonthsForBasicLoan, percentsOfCredit, numberOfdaysInMonthsOfPaymentSeptember);
            int sumToPayEveryMonthsOctober = CountSumByMonths(sumOfCredit, sumToPayEveryMonthsForBasicLoan, percentsOfCredit, numberOfdaysInMonthsOfPaymentOctober);
            int sumToPayEveryMonthsNovember = CountSumByMonths(sumOfCredit, sumToPayEveryMonthsForBasicLoan, percentsOfCredit, numberOfdaysInMonthsOfPaymentNovember);
            int sumToPayEveryMonthsDecember = CountSumByMonths(sumOfCredit, sumToPayEveryMonthsForBasicLoan, percentsOfCredit, numberOfdaysInMonthsOfPaymentDecember);
           
            int overallSumOfCredit = CountOverallSumOfCredit(sumToPayEveryMonthsJanuary, sumToPayEveryMonthsFebruary, sumToPayEveryMonthsMarch, sumToPayEveryMonthsApril, sumToPayEveryMonthsMay, sumToPayEveryMonthsJune, sumToPayEveryMonthsJuly, sumToPayEveryMonthsAugust, sumToPayEveryMonthsSeptember, sumToPayEveryMonthsOctober, sumToPayEveryMonthsNovember, sumToPayEveryMonthsDecember);

            Console.WriteLine("Payment for credit during each months of the year: \r\n" + "January:" + " " + sumToPayEveryMonthsJanuary + "\r\n" + "February:" + " " + sumToPayEveryMonthsFebruary + "\r\n" + "March:" + " " + sumToPayEveryMonthsMarch + "\r\n" + "April:" + " " + sumToPayEveryMonthsApril + "\r\n" + "May:" + " " + sumToPayEveryMonthsMay + "\r\n" + "June:" + " " + sumToPayEveryMonthsJune + "\r\n" + "July:" + " " + sumToPayEveryMonthsJuly + "\r\n" + "August:" + sumToPayEveryMonthsAugust + "\r\n" + "September:" + " " + sumToPayEveryMonthsSeptember + "\r\n" + "October:" + " " + sumToPayEveryMonthsOctober + "\r\n" + "November:" + " " + sumToPayEveryMonthsNovember + "\r\n" + "December:" + " " + sumToPayEveryMonthsDecember);
            Console.WriteLine("Overall amount payment for credit:" + " " + overallSumOfCredit );
           
        }
    }
}
