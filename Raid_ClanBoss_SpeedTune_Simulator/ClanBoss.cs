using System;

namespace Raid_ClanBoss_SpeedTune_Simulator
{
    public partial class Simulation
    {
        public static void ClanBossCheckTurns()
        {
            /* Check how many turns champions have taken compared to clan boss (how often this is called depends on your settings in config file) */
            // Make sure every champion takes atleast 2 turns for every clan boss turn
            if (champion_1_turns_per_cb_turn < 2 ||
                champion_2_turns_per_cb_turn < 2 ||
                champion_3_turns_per_cb_turn < 2 ||
                champion_4_turns_per_cb_turn < 2 ||
                champion_5_turns_per_cb_turn < 2
            )
            {
                SpeedTuned = false;
                running = false;
            }



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
            // Custom Checks for valid runs (called every clan boss turn)
            // ====================================================================================



            // ====================================================================================
        }
    }
}