using System;

namespace Raid_ClanBoss_SpeedTune_Simulator
{
    public partial class Simulation
    {
        static int champion_4_cooldown_max = 99;
        static int champion_4_cooldown_delay = 99;


        public static void Champion_4_Turn()
        {
            champion_4_turns_per_cb_turn++;
            champion_4_turn_meter = 0;
            champion_4_unkillable_duration--;
            champion_4_block_debuffs_duration--;
            champion_4_increase_speed_duration--;
            champion_4_decrease_speed_duration--;
            champion_4_counter_attack_duration--;

            if (champion_4_cooldown <= 0)
            {
                champion_4_cooldown = champion_4_cooldown_max;
                Champion_4_Boost();
            }
            else
            {
                Champion_4_Attack();
            }

            champion_4_cooldown--;
        }


        public static void Champion_4_Attack()
        {

        }


        public static void Champion_4_Boost()
        {
            // 30% boost: champion_1_turn_meter += 428.571f;
            // 20% boost: champion_1_turn_meter += 285.714f;
            // 15% boost: champion_1_turn_meter += 214.2855f;
            // 10% boost: champion_1_turn_meter += 142.857f;
            // SpeedBuff(2);


        }
    }
}