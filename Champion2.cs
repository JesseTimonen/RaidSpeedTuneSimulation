using System;

namespace Raid_ClanBoss_SpeedTune_Simulator
{
    public partial class Simulation
    {
        static int champion_2_cooldown_max = 99;
        static int champion_2_cooldown_delay = 99;


        public static void Champion_2_Turn()
        {
            champion_2_turns_per_cb_turn++;
            champion_2_turn_meter = 0;
            champion_2_unkillable_duration--;
            champion_2_block_debuffs_duration--;
            champion_2_increase_speed_duration--;
            champion_2_decrease_speed_duration--;
            champion_2_counter_attack_duration--;

            if (champion_2_cooldown <= 0)
            {
                champion_2_cooldown = champion_2_cooldown_max;
                Champion_2_Boost();
            }
            else
            {
                Champion_2_Attack();
            }

            champion_2_cooldown--;
        }


        public static void Champion_2_Attack()
        {

        }


        public static void Champion_2_Boost()
        {
            // 30% boost: champion_1_turn_meter += 428.571f;
            // 20% boost: champion_1_turn_meter += 285.714f;
            // 15% boost: champion_1_turn_meter += 214.2855f;
            // 10% boost: champion_1_turn_meter += 142.857f;
            // SpeedBuff(2);


        }
    }
}