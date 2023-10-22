using System;
using System.Runtime.CompilerServices;

namespace DomaciURIS // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name;

            Console.WriteLine("Unesite Vase ime:");
            name = Console.ReadLine();

            StartGame(name);

        }

        private static void StartGame(String names)
        {
            int counter = 0;

            int sum = 0;


            int help2 = 0;

            while (counter < 10)
            {
                int secondthrow = 0;
                int firstthrow = 0;

                if (counter == 9)
                {
                    int thirdthrow = 0;

                    if (help2 == 0)
                    {
                        Console.WriteLine("Unesi broj srusenih kegli pri prvom bacanju");
                        firstthrow = Convert.ToInt32(Console.ReadLine());
                        if (firstthrow != 10)
                        {
                            Console.WriteLine("Unesi broj srusenih kegli pri drugom bacanju");
                            secondthrow = Convert.ToInt32(Console.ReadLine());


                            if (firstthrow + secondthrow == 10)
                            {
                                Console.WriteLine("SPARE!");
                                help2 = 1;
                                Console.WriteLine("Unesi broj srusenih kegli pri trecem bacanju");
                                thirdthrow = Convert.ToInt32(Console.ReadLine());

                                sum += firstthrow + secondthrow + thirdthrow;
                            }
                            else
                            {


                                Console.WriteLine("Broj poena pri " + (counter + 1) + " formi je " + (firstthrow + secondthrow + thirdthrow + sum));

                                sum += firstthrow + secondthrow;

                                help2 = 0;
                            }
                        }
                        else
                        {
                            Console.WriteLine("STRIKE!");
                            help2 = 2;
                            Console.WriteLine("Unesi broj srusenih kegli pri trecem bacanju");
                            thirdthrow = Convert.ToInt32(Console.ReadLine());

                            sum += 10 + thirdthrow;
                        }






                    }
                    else if (help2 == 1)
                    {
                        Console.WriteLine("Unesi broj srusenih kegli pri prvom bacanju");
                        firstthrow = Convert.ToInt32(Console.ReadLine());

                        if (firstthrow != 10)
                        {
                            Console.WriteLine("Rezultat za frame " + counter + " iznosi " + (firstthrow + 10 + sum));

                            Console.WriteLine("Unesi broj srusenih kegli pri drugom bacanju");
                            secondthrow = Convert.ToInt32(Console.ReadLine());


                            if (firstthrow + secondthrow == 10)
                            {
                                Console.WriteLine("SPARE!");
                                Console.WriteLine("Unesi broj srusenih kegli pri trecem bacanju");
                                thirdthrow = Convert.ToInt32(Console.ReadLine());
                                help2 = 1;
                                sum += 10 + thirdthrow;
                            }
                            else
                            {


                                Console.WriteLine("Broj poena pri " + (counter + 1) + " formi je " + (firstthrow + secondthrow + sum));

                                sum += firstthrow + secondthrow;


                                help2 = 0;
                            }
                        }
                        else
                        {
                            Console.WriteLine("STRIKE!");
                            Console.WriteLine("Unesi broj srusenih kegli pri trecem bacanju");
                            thirdthrow = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Rezultat za frame " + counter + " iznosi " + (firstthrow + 10 + sum));
                            sum += 10 + thirdthrow;

                            help2 = 2;
                        }



                    }
                    else if (help2 == 2)
                    {
                        Console.WriteLine("Unesi broj srusenih kegli pri prvom bacanju");
                        firstthrow = Convert.ToInt32(Console.ReadLine());

                        if (firstthrow != 10)
                        {
                            Console.WriteLine("Unesi broj srusenih kegli pri drugom bacanju");
                            secondthrow = Convert.ToInt32(Console.ReadLine());


                            if (firstthrow + secondthrow == 10)
                            {
                                Console.WriteLine("SPARE!");
                                Console.WriteLine("Rezultat za frame " + counter + " iznosi " + (10 + sum));
                                Console.WriteLine("Unesi broj srusenih kegli pri trecem bacanju");
                                thirdthrow = Convert.ToInt32(Console.ReadLine());
                                

                                sum += 10 + firstthrow + secondthrow + thirdthrow;

                                help2 = 1;
                            }
                            else
                            {
                                Console.WriteLine("Rezultat za frame " + (counter) + " iznosi " + (firstthrow + secondthrow + 10 + sum));
                                Console.WriteLine("Rezultat za frame " + (counter + 1) + " iznosi " + (firstthrow + secondthrow + sum));

                                sum += 10  + thirdthrow;


                                help2 = 0;
                            }
                        }
                        else
                        {
                            Console.WriteLine("STRIKE!");
                            Console.WriteLine("Unesi broj srusenih kegli pri trecem bacanju");
                            thirdthrow = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Rezultat za frame " + counter + " iznosi " + (10 + 10 + sum));
                            help2 = 2;
                            sum += 10 + thirdthrow;
                        }



                    }

                    
                }
                else
                {
                    if (help2 == 0)
                    {
                        Console.WriteLine("Unesi broj srusenih kegli pri prvom bacanju");
                        firstthrow = Convert.ToInt32(Console.ReadLine());
                        if (firstthrow != 10)
                        {
                            Console.WriteLine("Unesi broj srusenih kegli pri drugom bacanju");
                            secondthrow = Convert.ToInt32(Console.ReadLine());


                            if (firstthrow + secondthrow == 10)
                            {
                                Console.WriteLine("SPARE!");
                                help2 = 1;
                            }
                            else
                            {
                                Console.WriteLine("Broj poena pri " + (counter + 1) + " formi je " + (firstthrow + secondthrow + sum));

                                help2 = 0;
                            }
                        }
                        else
                        {
                            Console.WriteLine("STRIKE!");
                            help2 = 2;
                        }


                        sum += firstthrow + secondthrow;



                    }
                    else if (help2 == 1)
                    {
                        Console.WriteLine("Unesi broj srusenih kegli pri prvom bacanju");
                        firstthrow = Convert.ToInt32(Console.ReadLine());

                        if (firstthrow != 10)
                        {
                            Console.WriteLine("Rezultat za frame " + counter + " iznosi " + (sum + firstthrow)); // tu sam

                            Console.WriteLine("Unesi broj srusenih kegli pri drugom bacanju");
                            secondthrow = Convert.ToInt32(Console.ReadLine());


                            if (firstthrow + secondthrow == 10)
                            {
                                Console.WriteLine("SPARE!");
                                help2 = 1;
                            }
                            else
                            {
                                Console.WriteLine("Broj poena pri " + (counter + 1) + " formi je " + (firstthrow + sum));


                                help2 = 0;
                            }
                        }
                        else
                        {
                            Console.WriteLine("STRIKE!");
                            Console.WriteLine("Rezultat za frame " + counter + " iznosi " + (sum + firstthrow)); // ovde sam

                            help2 = 2;
                        }

                        sum += firstthrow + firstthrow + secondthrow; //dodaj jos jedan ft

                    }
                    else if (help2 == 2)
                    {
                        Console.WriteLine("Unesi broj srusenih kegli pri prvom bacanju");
                        firstthrow = Convert.ToInt32(Console.ReadLine());

                        if (firstthrow != 10)
                        {
                            Console.WriteLine("Unesi broj srusenih kegli pri drugom bacanju");
                            secondthrow = Convert.ToInt32(Console.ReadLine());


                            if (firstthrow + secondthrow == 10)
                            {
                                Console.WriteLine("SPARE!");
                                Console.WriteLine("Rezultat za frame " + counter + " iznosi " + (firstthrow + secondthrow + sum));

                                help2 = 1;
                            }
                            else
                            {
                                Console.WriteLine("Rezultat za frame " + (counter) + " iznosi " + (firstthrow + secondthrow + sum));
                                Console.WriteLine("Rezultat za frame " + (counter + 1) + " iznosi " + (firstthrow + secondthrow + firstthrow + secondthrow + sum));




                                help2 = 0;
                            }
                        }
                        else
                        {

                            Console.WriteLine("STRIKE!");
                            Console.WriteLine("Rezultat za frame " + counter + " iznosi " + (firstthrow + secondthrow + sum));
                            help2 = 2;
                        }

                        sum += firstthrow + secondthrow + firstthrow + secondthrow;

                    }
                }


                counter++;

                Console.WriteLine();

                //Console.WriteLine(sum);

                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine("Konacna suma za korisnika " + names + " je " + sum);



        }
    }
}