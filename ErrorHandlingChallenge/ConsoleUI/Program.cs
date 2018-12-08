using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessor paymentProcessor = new PaymentProcessor();
            for (int i = 0; i <= 10; i++)
            {
                try
                {
                    var result = paymentProcessor.MakePayment($"Demo{i}", i);
                    if (result == null)
                        Console.Write($"Null value for item {i} ");
                    else
                        Console.Write(result.TransactionAmount);
                }
                catch (IndexOutOfRangeException iore)
                {
                    Console.Write("Skipped invalid record ");
                    iore.PrintInnerException();
                }
                catch (FormatException fe) when (i != 5)
                {
                    Console.Write("Formatting Issue ");
                    fe.PrintInnerException();
                }
                catch (ArithmeticException ae)
                {
                    Console.Write(ae.Message);
                    ae.PrintInnerException();
                }
                catch (Exception ex)
                {
                    Console.Write($"Payment skipped for payment with {i} items ");
                    ex.PrintInnerException();
                }

                Console.WriteLine();
            }
        }

    }

    static class ExceptionExtension
        {
            public static void PrintInnerException(this Exception ex)
            {
                if (ex.InnerException != null)
                    Console.Write(ex.InnerException.Message);
            }
        }
    }
