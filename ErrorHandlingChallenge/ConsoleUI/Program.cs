using System;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main()
        {
            PaymentProcessor paymentProcessor = new PaymentProcessor();
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Process item {0}", i);
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
                    Console.WriteLine("Skipped invalid record ");
                    iore.PrintException();
                }
                catch (FormatException fe) when (i != 5)
                {
                    Console.WriteLine("Formatting Issue ");
                    fe.PrintException();
                }
                catch (ArithmeticException ae)
                {
                    ae.PrintException();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Payment skipped for payment with {i} items ");
                    ex.PrintException();
                }

                Console.WriteLine();
            }
        }

    }

    static class ExceptionExtension
        {
            public static void PrintException(this Exception ex)
            {
               while (ex != null)
                {
                    Console.WriteLine(ex.Message);
                    ex = ex.InnerException;
                }
            }
        }
    }
