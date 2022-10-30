using System;

/**
* Example of the champion Seeker
*
* Ability 2: Boost everyones turn meter by 30% and takes an extra turn (3 turn cooldown)
*/

namespace Raid_ClanBoss_SpeedTune_Simulator
{
    public partial class Simulation
    {
        static int champion_2_A2_cooldown_max = 3;      // Cooldown of ability 2
        static int champion_2_A2_cooldown_delay = 0;    // Delay for ability 2
        static int champion_2_A3_cooldown_max = 9999;   // Champion doesn't have ability 3 so we can keep it at 9999
        static int champion_2_A3_cooldown_delay = 9999; // Champion doesn't have ability 3 so we can keep it at 9999


        public static void Champion_2_Turn()
        {
            // Let simulation know this champion has taken a turn
            champion_2_turns_per_cb_turn++;

            // Set turn meter back to 0
            champion_2_turn_meter = 0;

            // Lower champions buffs by 1 turn
            champion_2_unkillable_duration--;
            champion_2_block_debuffs_duration--;
            champion_2_increase_speed_duration--;
            champion_2_decrease_speed_duration--;
            champion_2_counter_attack_duration--;


            if (champion_2_A3_cooldown <= 0)
            {
                champion_2_A3_cooldown = champion_2_A3_cooldown_max;
                champion_2_A3_cooldown--;
                champion_2_A2_cooldown--;
                Champion_2_A3_Skill();
            }
            else if (champion_2_A2_cooldown <= 0)
            {
                champion_2_A2_cooldown = champion_2_A2_cooldown_max;
                champion_2_A3_cooldown--;
                champion_2_A2_cooldown--;
                Champion_2_A2_Skill();
            }
            else
            {
                champion_2_A3_cooldown--;
                champion_2_A2_cooldown--;
                Champion_2_Basic_Attack();
            }
        }



        public static void Champion_2_Basic_Attack()
        {
            /**
            * Basic attack
            */


        }



        public static void Champion_2_A2_Skill()
        {
            /**
            * Ability 2
            */

            // 30% turn meter boost
            // max_turn_meter = 1428.57;
            // 1428.57 / 100 * 30 = 428.571
            champion_1_turn_meter += 428.571f;
            champion_2_turn_meter += 428.571f;
            champion_3_turn_meter += 428.571f;
            champion_4_turn_meter += 428.571f;
            champion_5_turn_meter += 428.571f;

            // Take another turn
            Champion_2_Turn();
        }



        public static void Champion_2_A3_Skill()
        {
            /**
            * No ability
            */


        }
    }
}