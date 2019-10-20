using System;

namespace TreeehouseDefense
{
    class Game
    {
        static void Main()
        {
            Map map = new Map(8,5);
            try 
            {
                //Level 1
                Path path1 = new RandomPath(map);

                Console.WriteLine(map.DisplayMap(path1, map));
                Console.WriteLine("\nAbove is the map. P denotes the path the invaders take. M denotes a space you can put a Tower");

                IInvader[] invaders1 =
                {
                    new BasicInvader(path1),
                    new BasicInvader(path1),
                    new BasicInvader(path1)
                };

                Console.WriteLine("\nYou can choose where to put your towers.");

                Tower[] towers1 = 
                {
                    new Tower(new MapLocation(0, 0, map)),
                    new Tower(new MapLocation(0, 0, map)),
                    new Tower(new MapLocation(0, 0, map))
                };

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("\nValues for tower " + (i + 1));
                    Console.WriteLine("\nEnter an X value: ");
                    int x = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("\nEnter a Y value: ");
                    int y = Int32.Parse(Console.ReadLine());
                    towers1[i] = new Tower(
                        new MapLocation(x, y, map)
                        );
                    Console.WriteLine("Tower created at point ("+x+","+y+")");
                }


                Level level1 = new Level(invaders1)
                {
                    Towers = towers1
                };

                bool playerWon1 = level1.Play();
                Console.WriteLine("Player " + (playerWon1? "won!" : "lost!"));
                //end of level 1

                bool playerWon2 = false;
                if (playerWon1)
                {
                    //Level2
                    Path path2 = new RandomPath(map);

                    Console.WriteLine(map.DisplayMap(path2, map));
                    Console.WriteLine("\nAbove is the map. P denotes the path the invaders take. M denotes a space you can put a Tower");

                    IInvader[] invaders2 =
                    {
                    new BasicInvader(path2),
                    new BasicInvader(path2),
                    new StrongInvader(path2),
                    new ShieldedInvader(path2)
                    };

                    Console.WriteLine("\nYou can choose where to put your towers.");

                    Tower[] towers2 =
                    {
                    new Tower(new MapLocation(0, 0, map)),
                    new Tower(new MapLocation(0, 0, map)),
                    new PowerfulTower(new MapLocation(0, 0, map)),
                    new SniperTower(new MapLocation(0, 0, map))
                    };
                    //letting user create both 
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine("\nValues for tower " + (i + 1));
                        Console.WriteLine("\nEnter an X value: ");
                        int x = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nEnter a Y value: ");
                        int y = Int32.Parse(Console.ReadLine());
                        towers2[i] = new Tower(
                            new MapLocation(x, y, map)
                            );
                        Console.WriteLine("Tower created at point (" + x + "," + y + ")");
                    }
                    //letting user create the powerful tower
                    Console.WriteLine("\nValues for powerful tower ");
                    Console.WriteLine("\nEnter an X value: ");
                    int xP = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("\nEnter a Y value: ");
                    int yP = Int32.Parse(Console.ReadLine());
                    towers2[2] = new PowerfulTower(
                        new MapLocation(xP, yP, map)
                    );
                    Console.WriteLine("Powerful Tower created at point (" + xP + "," + yP + ")");

                    //letting user create the sniper tower
                    Console.WriteLine("\nValues for sniper tower ");
                    Console.WriteLine("\nEnter an X value: ");
                    int xS = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("\nEnter a Y value: ");
                    int yS = Int32.Parse(Console.ReadLine());
                    towers2[2] = new SniperTower(
                        new MapLocation(xS, yS, map)
                    );
                    Console.WriteLine("Sniper Tower created at point (" + xS + "," + yS + ")");


                    Level level2 = new Level(invaders2)
                    {
                        Towers = towers2
                    };

                    playerWon2 = level2.Play();
                    Console.WriteLine("Player " + (playerWon2 ? "won!" : "lost!"));
                }
                //end of level 2

                //level 3
                Map map2 = new Map(9,5);
                if (playerWon2) 
                { 
                    Path path3 = new RandomPath(map2);

                    Console.WriteLine(map2.DisplayMap(path3, map2));
                    Console.WriteLine("\nAbove is the map. P denotes the path the invaders take. M denotes a space you can put a Tower");

                    IInvader[] invaders3 =
                    {
                        new BasicInvader(path3),
                        new BasicInvader(path3),
                        new StrongInvader(path3),
                        new StrongInvader(path3),
                        new ShieldedInvader(path3),
                        new ResurrectingInvader(path3)
                        };

                    Console.WriteLine("\nYou can choose where to put your towers.");

                    Tower[] towers3 =
                    {
                        new Tower(new MapLocation(0, 0, map2)),
                        new Tower(new MapLocation(0, 0, map2)),
                        new PowerfulTower(new MapLocation(0, 0, map2)),
                        new PowerfulTower(new MapLocation(0, 0, map2)),
                        new SniperTower(new MapLocation(0, 0, map2)),
                        new LongRangeTower(new MapLocation(0, 0, map2))
                        };
                    //letting user create both basic towers
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine("\nValues for tower " + (i + 1));
                        Console.WriteLine("\nEnter an X value: ");
                        int x = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nEnter a Y value: ");
                        int y = Int32.Parse(Console.ReadLine());
                        towers3[i] = new Tower(
                            new MapLocation(x, y, map2)
                            );
                        Console.WriteLine("Tower created at point (" + x + "," + y + ")");
                    }

                    //letting user create both powerful towers
                    for (int i = 2; i < 4; i++)
                    {
                        Console.WriteLine("\nValues for powerful tower " + (i - 1));
                        Console.WriteLine("\nEnter an X value: ");
                        int x = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nEnter a Y value: ");
                        int y = Int32.Parse(Console.ReadLine());
                        towers3[i] = new PowerfulTower(
                            new MapLocation(x, y, map2)
                            );
                        Console.WriteLine("Powerful Tower created at point (" + x + "," + y + ")");
                    }

                    //letting user create the sniper tower
                    Console.WriteLine("\nValues for sniper tower ");
                    Console.WriteLine("\nEnter an X value: ");
                    int xS = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("\nEnter a Y value: ");
                    int yS = Int32.Parse(Console.ReadLine());
                    towers3[4] = new SniperTower(
                        new MapLocation(xS, yS, map2)
                    );
                    Console.WriteLine("Sniper Tower created at point (" + xS + "," + yS + ")");

                    //letting user create the long range tower
                    Console.WriteLine("\nValues for long range tower ");
                    Console.WriteLine("\nEnter an X value: ");
                    int xLR = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("\nEnter a Y value: ");
                    int yLR = Int32.Parse(Console.ReadLine());
                    towers3[5] = new LongRangeTower(
                        new MapLocation(xLR, yLR, map2)
                    );
                    Console.WriteLine("Long Range Tower created at point (" + xLR + "," + yLR + ")");


                    Level level3 = new Level(invaders3)
                    {
                        Towers = towers3
                    };

                    bool playerWon3 = level3.Play();
                    Console.WriteLine("Player " + (playerWon3 ? "won!" : "lost!"));
                    if (playerWon3)
                    {
                        Console.WriteLine("\nCongratulations! You beat the game!!!!! Here's your cake:\n\n");
                        Console.WriteLine("             ,   ,   ,   ,             ");
                        Console.WriteLine("           , |_,_|_,_|_,_| ,           ");
                        Console.WriteLine("       _,-=|;  |,  |,  |,  |;=-_       ");
                        Console.WriteLine("     .-_| , | , | , | , | , |  _-.     ");
                        Console.WriteLine("     |:  -|:._|___|___|__.|:=-  :|     ");
                        Console.WriteLine("     ||*:  :    .     .    :  |*||     ");
                        Console.WriteLine("     || |  | *  |  *  |  * |  | ||     ");
                        Console.WriteLine(" _.-=|:*|  |    |     |    |  |*:|=-._ ");
                        Console.WriteLine("-    `._:  | *  |  *  |  * |  :_.'    -");
                        Console.WriteLine(" =_      -=:.___:_____|___.: =-     _= ");
                        Console.WriteLine("    - . _ __ ___  ___  ___ __ _ . -    ");
                    }
                }



            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TreehouseDefenseException)
            {
                Console.WriteLine("Unhandled Treehouse Defense Exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled exception" + ex);
            }

        }
    }
}
