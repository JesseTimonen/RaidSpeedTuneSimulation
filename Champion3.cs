using System;

namespace Raid_ClanBoss_SpeedTune_Simulator
{
    public partial class Simulation
    {
        static int champion_3_cooldown_max = 99;
        static int champion_3_cooldown_delay = 99;


        public static void Champion_3_Turn()
        {
            champion_3_turns_per_cb_turn++;
            champion_3_turn_meter = 0;
            champion_3_unkillable_duration--;
            champion_3_block_debuffs_duration--;
            champion_3_increase_speed_duration--;
            champion_3_decrease_speed_duration--;
            champion_3_counter_attack_duration--;

            if (champion_3_cooldown <= 0)
            {
                champion_3_cooldown = champion_3_cooldown_max;
                Champion_3_Boost();
            }
            else
            {
                Champion_3_Attack();
            }

            champion_3_cooldown--;
        }


        public static void Champion_3_Attack()
        {

        }


        public static void Champion_3_Boost()
        {
            // 30% boost: champion_1_turn_meter += 428.571f;
            // 20% boost: champion_1_turn_meter += 285.714f;
            // 15% boost: champion_1_turn_meter += 214.2855f;
            // 10% boost: champion_1_turn_meter += 142.857f;
            // SpeedBuff(2);


        }
    }
}