using System;

namespace Raid_ClanBoss_SpeedTune_Simulator
{
    public partial class Simulation
    {
        public static void ClanBossCheckTurns()
        {
            /* Check champion turns every clan boss stun */
            if (champion_1_turns_per_cb_turn != 6 ||
                champion_2_turns_per_cb_turn != 6 ||
                champion_3_turns_per_cb_turn != 6 ||
                champion_4_turns_per_cb_turn != 6 ||
                champion_5_turns_per_cb_turn != 6
            )
            {
                SpeedTuned = false;
                running = false;
            }



            ///* Check champion turns every clan boss turn */
            //if (clan_boss_turns_taken % 3 == 0)
            //{
            //    /* Turn before stun */
            //    if (champion_1_turns_per_cb_turn != 1 ||
            //        champion_2_turns_per_cb_turn != 1 ||
            //        champion_3_turns_per_cb_turn != 1 ||
            //        champion_4_turns_per_cb_turn != 1 ||
            //        champion_5_turns_per_cb_turn != 1
            //    )
            //    {
            //        SpeedTuned = false;
            //        running = false;
            //    }
            //}
            //else if ((clan_boss_turns_taken - 2) % 3 == 0)
            //{
            //    /* Turn before second Aoe */
            //    if (champion_1_turns_per_cb_turn != 1 ||
            //        champion_2_turns_per_cb_turn != 1 ||
            //        champion_3_turns_per_cb_turn != 1 ||
            //        champion_4_turns_per_cb_turn != 1 ||
            //        champion_5_turns_per_cb_turn != 1
            //    )
            //    {
            //        SpeedTuned = false;
            //        running = false;
            //    }
            //}
            //else
            //{
            //    /* Turn before first aoe */
            //    if (champion_1_turns_per_cb_turn != 1 ||
            //        champion_2_turns_per_cb_turn != 1 ||
            //        champion_3_turns_per_cb_turn != 1 ||
            //        champion_4_turns_per_cb_turn != 1 ||
            //        champion_5_turns_per_cb_turn != 1
            //    )
            //    {
            //        SpeedTuned = false;
            //        running = false;
            //    }
            //}



        }


        public static void ClanBoss()
        {
            // Custom Checks for valid runs
            // ====================================================================================
     
            // ====================================================================================
        }
    }
}