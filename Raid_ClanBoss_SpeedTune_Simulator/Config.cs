namespace Raid_ClanBoss_SpeedTune_Simulator
{
    public partial class Simulation
    {
        /**
         * Determines how detailed the search will be:
         * 1  =  Search every possible speed
         * 2  =  Quicker search (16x faster), can miss some speed tunes
         * 3  =  Really quick search (81x faster), can easily miss some speed tunes
         * 4+ =  Unreliable search, but can be used to speed up massive simulations
        */
        static int search_detail = 2;


        /**
         * Speed ranges [min, max]
         * Only speeds between these ranges will be tested
        */
        static int[] champion_1_speed_range = { 301, 301 };
        static int[] champion_2_speed_range = { 300, 300 };
        static int[] champion_3_speed_range = { 252, 252 };
        static int[] champion_4_speed_range = { 251, 251 };
        static int[] champion_5_speed_range = { 250, 250 };



        /**
         * If total speed is higher than this number the simulation will be invalid
        */
        static float lowest_total_speeds = 9999;



        /**
         * Speed tune must be synchronized after clan buss turn x
         * Speed tune must last until for x turns
        */
        static int speed_tuned_after_cb_attack = 6;
        static int speed_tuned_turns = 15;



        /**
         * Clan boss
        */
        static bool enable_debuffs = false;



        /**
         * Checks champions' turns when clan boss does it's turn
         * 1 = Every turn
         * 3 = Every stun
         * 6 = Every second stun
        */
        static int clan_boss_check_turns_at = 1;
    }
}