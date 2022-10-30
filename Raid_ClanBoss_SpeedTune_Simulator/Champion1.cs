using System;

/**
* Example of the champion Krisk
*
* Ability 2: Extends all buffs by 1 turn (3 turn cooldown)
* Ability 3: Places increase speed buff on every ally for 2 turns (3 turn cooldown)
*/

namespace Raid_ClanBoss_SpeedTune_Simulator
{
    public partial class Simulation
    {
        static int champion_1_A2_cooldown_max = 3;      // Cooldown of ability 2
        static int champion_1_A2_cooldown_delay = 1;    // Delay for ability 2
        static int champion_1_A3_cooldown_max = 3;      // Cooldown of ability 3
        static int champion_1_A3_cooldown_delay = 0;    // Delay for ability 3


        public static void Champion_1_Turn()
        {
            // Let simulation know this champion has taken a turn
            champion_1_turns_per_cb_turn++;

            // Set turn meter back to 0
            champion_1_turn_meter = 0;

            // Lower champions buffs by 1 turn
            champion_1_unkillable_duration--;
            champion_1_block_debuffs_duration--;
            champion_1_increase_speed_duration--;
            champion_1_decrease_speed_duration--;
            champion_1_counter_attack_duration--;


            if (champion_1_A3_cooldown <= 0)
            {
                champion_1_A3_cooldown = champion_1_A3_cooldown_max;
                champion_1_A3_cooldown--;
                champion_1_A2_cooldown--;
                Champion_1_A3_Skill();
            }
            else if (champion_1_A2_cooldown <= 0)
            {
                champion_1_A2_cooldown = champion_1_A2_cooldown_max;
                champion_1_A3_cooldown--;
                champion_1_A2_cooldown--;
                Champion_1_A2_Skill();
            }
            else
            {
                champion_1_A3_cooldown--;
                champion_1_A2_cooldown--;
                Champion_1_Basic_Attack();
            }
        }



        public static void Champion_1_Basic_Attack()
        {
            /**
            * Basic attack doesn't do anything special
            */


        }



        public static void Champion_1_A2_Skill()
        {
            /**
            * Extends all buffs by 1 turn
            */

            ExtendBuffs(1);
        }



        public static void Champion_1_A3_Skill()
        {
            /**
            * Places increase speed buff on every ally for 2 turns (does not place buff on himself)
            * This skill also places increase defence on this champion, but that is not important for the speed tune, so we can ignore it
            */

            // Get this champions current speed buff duration
            int current_speed_buff = champion_1_increase_speed_duration;

            // Place speed buff on every ally
            SpeedBuff(2);

            // Set this champions speed buff duration to the state it was before calling speed buff on everyone
            champion_1_increase_speed_duration = current_speed_buff;
        }
    }
}