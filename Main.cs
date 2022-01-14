using System;

namespace Raid_ClanBoss_SpeedTune_Simulator
{
    public partial class Simulation
    {
        static void Main(string[] args)
        {
            DateTime starting_time = DateTime.Now;

            for (int a = champion_1_speed_range[0]; a <= champion_1_speed_range[1]; a += search_detail)
            {
                for (float b = champion_2_speed_range[0]; b <= champion_2_speed_range[1]; b += search_detail)
                {
                    for (float c = champion_3_speed_range[0]; c <= champion_3_speed_range[1]; c += search_detail)
                    {
                        for (float d = champion_4_speed_range[0]; d <= champion_4_speed_range[1]; d += search_detail)
                        {
                            for (float e = champion_5_speed_range[0]; e <= champion_5_speed_range[1]; e += search_detail)
                            {


                                if (Run_Simulation("unm", a, b, c, d, e))
                                {
                                    if (lowest_total_speeds > (a + b + c + d + e))
                                    {
                                        lowest_total_speeds = a + b + c + d + e;
                                        lowest_total_speeds_message = "Fastest speed tuned team had speeds: " + a + ", " + b + ", " + c + ", " + d + ", " + e;
                                        Console.WriteLine("Fastest speed tuned team found so far had speeds: " + a + ", " + b + ", " + c + ", " + d + ", " + e);
                                    }
                                }


                            }
                        }
                    }
                }

                TimeSpan elapsed_time = DateTime.Now - starting_time;
                Console.WriteLine(Math.Round(100f / (champion_1_speed_range[1] - champion_1_speed_range[0] + 1) * (a + 1 - champion_1_speed_range[0])) + "% completed. (" + Math.Round(elapsed_time.TotalMinutes / (a + 1 - champion_1_speed_range[0]) * (champion_1_speed_range[1] - a)) + " mins left)");
            }

            Console.WriteLine("Simulation Completed");
            Console.WriteLine(lowest_total_speeds_message);
            Console.ReadKey();
        }
    }
}