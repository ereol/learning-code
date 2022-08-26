using System;
using System.Linq;

namespace BDOMenu
    {
        class MainClass
            {
                public static void Main(string[] args)
                {
                    while(true)  
                        {   
                            DateTime dt = DateTime.UtcNow;
                            DateTime setTime = new System.DateTime(01,01,01);
                            string dtUtc = dt.ToString("HH:mm"); 
                            int Date = Convert.ToInt32(dt.DayOfWeek);
                            var SystemTime = DateTime.Now.ToString("HH:mm");
                            string SystemDay = DateTime.UtcNow.Date.ToString("dd/MM/yyyy");
                            string SystemHour = DateTime.UtcNow.ToString("HH:mm");
                            logo();
                            Console.WriteLine("Time now is: " + SystemTime);
                            Console.WriteLine(TimeTable(Date));
                            Console.WriteLine("Please choose an option...\n1. Calculate BDO Marketplace List\n2. Refresh\n3. Exit Program");
                            string selectionstr = Console.ReadLine();
                            int selection;
                            Int32.TryParse(selectionstr, out selection);
                            switch(selection)
                                {
                                    case 1:
                                    Console.Clear();
                                    marketplace();
                                    break;

                                    case 2:
                                    Console.Clear();
                                    continue;

                                    case 3:
                                    Environment.Exit(0);
                                    break;

                                    default:
                                    Console.WriteLine("Entry not valid. Please press enter to continue.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    continue;
                                }
                        }   
                }
            


                static string TimeTable(int Date)
                    {
                        DateTime currentTime = DateTime.UtcNow;
                        string currentTimeHourToString = currentTime.ToString("HH");
                            int CTTI = Convert.ToInt32(currentTimeHourToString);
                        string currentTimeMinuteToString = currentTime.ToString("mm");
                            int CTMI = Convert.ToInt32(currentTimeMinuteToString);
                        string currentTimeSecondsToString = currentTime.ToString("ss");
                            int CTSI = Convert.ToInt32(currentTimeSecondsToString);
                        int ResultsH = 0;
                        int ResultsM = 0;
                        int ResultsS = 60 - CTSI;
                        int time = 0;
                        string Monster = "N/A";

                        switch(CTTI)
                        {
                            case var expresson when (17 > CTTI && CTTI >= 14):
                                ResultsH = (16 - CTTI);
                                ResultsM = (59 - CTMI);
                                time = 1;
                                break;
                            case var expresson when (21 > CTTI && CTTI >= 17):
                                ResultsH = 20 - CTTI;
                                ResultsM = 59 - CTMI;
                                time = 2;
                                break;
                            case var expresson when (24 > CTTI && CTTI >= 21):
                                ResultsH = 23 - CTTI;
                                ResultsM = 59 - CTMI;
                                time = 3;
                                break;
                            case var expresson when (03 > CTTI || CTTI >= 24):
                                ResultsH = 02 - CTTI;
                                ResultsM = 59 - CTMI;
                                time = 4;
                                break;
                            case var expresson when (04 > CTTI && CTTI >= 03):
                                ResultsH = 03 - CTTI;
                                ResultsM = (14 - CTMI);
                                    if (CTTI == 15)
                                    {
                                        time = 5;
                                        break;
                                    }

                                break;
                            case var expresson when (05 > CTTI && CTTI >= 04):
                                ResultsH = 04 - CTTI;
                                ResultsM = 14 - CTMI;
                                    if (CTTI == 15)
                                    {
                                        time = 6;
                                    }
                                break;
                            case var expresson when (07 > CTTI && CTTI >= 05):
                                ResultsH = 06 - CTTI;
                                ResultsM = 14 - CTMI;
                                    if (CTTI == 15)
                                    {
                                        time = 7;
                                    }
                                break;
                            case var expresson when (10 > CTTI && CTTI >= 07):
                                ResultsH = 09 - CTTI;
                                ResultsM = 59 - CTMI;
                                time = 8;
                                break;
                            case var expresson when (14 > CTTI && CTTI >= 10):
                                ResultsH = (13 - CTTI);
                                ResultsM = (59 - CTMI);
                                time = 0;
                                break;
                        }

                        switch(Date)
                        {
                            case 0:
                            switch(time)
                            {
                                case 0:
                                    Monster = "Nouver";
                                    break;
                                case 1:
                                    Monster = "Kzarka";
                                    break;
                                case 2:
                                    Monster = "Veil";
                                    break;
                                case 3:
                                    Monster = "Garmoth";
                                    break;
                                case 4:
                                    break;
                                case 5:
                                    break;
                                case 6:
                                    Monster = "Nouver/Kutum";
                                    break;
                                case 7:
                                    Monster = "Kzarka";
                                    break;
                                case 8:
                                    Monster = "Kutum";
                                    break;
                                default:
                                    break;
                            }
                            break;
                            case 1:
                            switch(time)
                            {
                                case 0:
                                    Monster = "Kzarka";
                                    break;
                                case 1:
                                    Monster = "Offin";
                                    break;
                                case 2:
                                    Monster = "Kutum";
                                    break;
                                case 3:
                                    Monster = "Nouver";
                                    break;
                                case 4:
                                    Monster = "Kzarka/Nouver";
                                    break;
                                case 5:
                                    break;
                                case 6:
                                    Monster = "Karanda/Kutum";
                                    break;
                                case 7:
                                    Monster = "Karanda";
                                    break;
                                case 8:
                                    Monster = "Kzarka";
                                    break;
                                default:
                                    break;
                            }
                            break;
                            case 2:
                            switch(time)
                            {
                                case 0:
                                    Monster = "Nouver";
                                    break;
                                case 1:
                                    Monster = "Kutum";
                                    break;
                                case 2:
                                    Monster = "Nouver";
                                    break;
                                case 3:
                                    Monster = "Karanda";
                                    break;
                                case 4:
                                    Monster = "Kzarka";
                                    break;
                                case 5:
                                    break;
                                case 6:
                                    Monster = "Karanda";
                                    break;
                                case 7:
                                    Monster = "Kutum";
                                    break;
                                case 8:
                                    Monster = "Kzarka";
                                    break;
                                default:
                                    break;
                            }
                            break;
                            case 3:
                            switch(time)
                            {
                                case 0:
                                    Monster = "Karanda";
                                    break;
                                case 1:
                                    Monster = "Nouver";
                                    break;
                                case 2:
                                    Monster = "Kutum/Offin";
                                    break;
                                case 3:
                                    Monster = "Vell";
                                    break;
                                case 4:
                                    Monster = "Garmoth";
                                    break;
                                case 5:
                                    break;
                                case 6:
                                    Monster = "Kzarka/Kutum";
                                    break;
                                case 7:
                                    Monster = "Karanda";
                                    break;
                                case 8:
                                    Monster = "Maintenance";
                                    break;
                                default:
                                    break;
                            }
                            break;
                            case 4:
                            switch(time)
                            {
                                case 0:
                                    Monster = "Kutum";
                                    break;
                                case 1:
                                    Monster = "Nouver";
                                    break;
                                case 2:
                                    Monster = "Kzarka";
                                    break;
                                case 3:
                                    Monster = "Kutum";
                                    break;
                                case 4:
                                    Monster = "Kzarka/Karanda";
                                    break;
                                case 5:
                                    Monster = "Quint/Muraka";
                                    break;
                                case 6:
                                    Monster = "Nouver";
                                    break;
                                case 7:
                                    Monster = "Kutum";
                                    break;
                                case 8:
                                    Monster = "Kzarka";
                                    break;
                                default:
                                    break;
                            }
                            break;
                            case 5:
                            switch(time)
                            {
                                case 0:
                                    Monster = "Kutum";
                                    break;
                                case 1:
                                    Monster = "Karanda";
                                    break;
                                case 2:
                                    Monster = "Nouver";
                                    break;
                                case 3:
                                    Monster = "Kzarka";
                                    break;
                                case 4:
                                    Monster = "Garmoth";
                                    break;
                                case 5:
                                    break;
                                case 6:
                                    Monster = "Karanda/Kzarka";
                                    break;
                                case 7:
                                    Monster = "Nouver";
                                    break;
                                case 8:
                                    Monster = "Karanda";
                                    break;
                                default:
                                    break;
                            }
                            break;
                            case 6:
                            switch(time)
                            {
                                case 0:
                                    Monster = "Kutum";
                                    break;
                                case 1:
                                    Monster = "Nouver";
                                    break;
                                case 2:
                                    Monster = "Quint/Muraka";
                                    break;
                                case 3:
                                    Monster = "Kzarka/Karanda";
                                    break;
                                case 4:
                                    Monster = "Kutum/Kzarka";
                                    break;
                                case 5:
                                    break;
                                case 6:
                                    Monster = "Karanda";
                                    break;
                                case 7:
                                    Monster = "Offin";
                                    break;
                                case 8:
                                    Monster = "Nouver";
                                    break;
                                default:
                                    break;
                            }
                            break;
                        }

                        var ResultsMString = ResultsM.ToString("00");
                        string output = ("Next boss is " + Monster + ".\nIt will appear in " + ResultsH + "h " + ResultsM + "m " + ResultsS +"s.");

                        if (ResultsM < 10)
                        {
                            output = ("Next boss is " + Monster + ".\nIt will appear in " + ResultsH + "h " + ResultsMString + "m " + ResultsS +"s.");
                        }
                        else if (ResultsM == 60)
                        {
                            output = ("Next boss is " + Monster + ".\nIt will appear in " + ResultsH + "h 00 m.");
                        }

                        return output;

                    }
                static void logo()
                    {
                        Console.WriteLine("$$$$$$$\\  $$$$$$$\\   $$$$$$\\        $$\\      $$\\ $$$$$$$$\\ $$\\   $$\\ $$\\   $$\\ \n$$  __$$\\ $$  __$$\\ $$  __$$\\       $$$\\    $$$ |$$  _____|$$$\\  $$ |$$ |  $$ |\n$$ |  $$ |$$ |  $$ |$$ /  $$ |      $$$$\\  $$$$ |$$ |      $$$$\\ $$ |$$ |  $$ |");
                        Console.WriteLine("$$$$$$$\\ |$$ |  $$ |$$ |  $$ |      $$\\$$\\$$ $$ |$$$$$\\    $$ $$\\$$ |$$ |  $$ |\n$$  __$$\\ $$ |  $$ |$$ |  $$ |      $$ \\$$$  $$ |$$  __|   $$ \\$$$$ |$$ |  $$ |\n$$ |  $$ |$$ |  $$ |$$ |  $$ |      $$ |\\$  /$$ |$$ |      $$ |\\$$$ |$$ |  $$ |");
                        Console.WriteLine("$$$$$$$  |$$$$$$$  | $$$$$$  |      $$ | \\_/ $$ |$$$$$$$$\\ $$ | \\$$ |\\$$$$$$  |\n\\_______/ \\_______/  \\______/       \\__|     \\__|\\________|\\__|  \\__| \\______/\n\n");
                    }
                static void marketplace()
                    {
                        Console.Write("Welcome to the Marketplace\nWhat is the price of your product?\n$ ");
                        double value = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("How much is being sold?");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        int valuepack;
                        value *= amount;
                        while(true)
                        {
                            Console.WriteLine("\nDo you have a value pack?\n1 - Yes\n2 - No");
                            string valuepackstr = Console.ReadLine();
                            Int32.TryParse(valuepackstr, out valuepack);
                            if (valuepack == 1)
                                {
                                    value *= 1.3;
                                    break;
                                }
                            else if ( valuepack == 2)
                                {
                                    value *= 1;
                                    break;
                                }
                            else
                                {
                                    Console.WriteLine("You have entered a wrong input. Please try again.");
                                }
                        }
                        value *= 0.65;
                        string output = String.Format("\nThe total price of your product is ${0:C2}\nPress any key to continue...", Convert.ToInt32(value));
                        Console.Write(output);
                        Console.ReadKey();
                        Console.Clear();

                    }
                
            }
        
    }
