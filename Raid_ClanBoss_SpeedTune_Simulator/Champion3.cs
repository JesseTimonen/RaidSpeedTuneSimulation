using System;

namespace Raid_ClanBoss_SpeedTune_Simulator
{
    public partial class Simulation
    {
        static int champion_3_A2_cooldown_max = 9999;
        static int champion_3_A2_cooldown_delay = 9999;
        static int champion_3_A3_cooldown_max = 9999;
        static int champion_3_A3_cooldown_delay = 9999;


        public static void Champion_3_Turn()
        {
            // Let simulation know this champion has taken a turn
            champion_3_turns_per_cb_turn++;

            // Set turn meter back to 0
            champion_3_turn_meter = 0;

            // Lower champions buffs by 1 turn
            champion_3_unkillable_duration--;
            champion_3_block_debuffs_duration--;
            champion_3_increase_speed_duration--;
            champion_3_decrease_speed_duration--;
            champion_3_counter_attack_duration--;


            if (champion_3_A3_cooldown <= 0)
            {
                champion_3_A3_cooldown = champion_3_A3_cooldown_max;
                champion_3_A3_cooldown--;
                champion_3_A2_cooldown--;
                Champion_3_A3_Skill();
            }
            else if (champion_3_A2_cooldown <= 0)
            {
                champion_3_A2_cooldown = champion_3_A2_cooldown_max;
                champion_3_A3_cooldown--;
                champion_3_A2_cooldown--;
                Champion_3_A2_Skill();
            }
            else
            {
                champion_3_A3_cooldown--;
                champion_3_A2_cooldown--;
                Champion_3_Basic_Attack();
            }
        }



        public static void Champion_3_Basic_Attack()
        {
            /**
            * Basic attack
            */


        }



        public static void Champion_3_A2_Skill()
        {
            /**
            * Ability 2
            */


        }



        public static void Champion_3_A3_Skill()
        {
            /**
            * Ability 3
            */


        }
    }
}