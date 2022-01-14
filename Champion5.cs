using System;

namespace Raid_ClanBoss_SpeedTune_Simulator
{
    public partial class Simulation
    {
        static int champion_5_cooldown_max = 99;
        static int champion_5_cooldown_delay = 99;


        public static void Champion_5_Turn()
        {
            champion_5_turns_per_cb_turn++;
            champion_5_turn_meter = 0;
            champion_5_unkillable_duration--;
            champion_5_block_debuffs_duration--;
            champion_5_increase_speed_duration--;
            champion_5_decrease_speed_duration--;
            champion_5_counter_attack_duration--;

            if (champion_5_cooldown <= 0)
            {
                champion_5_cooldown = champion_5_cooldown_max;
                Champion_5_Boost();
            }
            else
            {
                Champion_5_Attack();
            }

            champion_5_cooldown--;
        }


        public static void Champion_5_Attack()
        {

        }


        public static void Champion_5_Boost()
        {
            // 30% boost: champion_1_turn_meter += 428.571f;
            // 20% boost: champion_1_turn_meter += 285.714f;
            // 15% boost: champion_1_turn_meter += 214.2855f;
            // 10% boost: champion_1_turn_meter += 142.857f;
            // SpeedBuff(2);


        }
    }
}