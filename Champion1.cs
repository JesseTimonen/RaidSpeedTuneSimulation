using System;

namespace Raid_ClanBoss_SpeedTune_Simulator
{
    public partial class Simulation
    {
        static int champion_1_cooldown_max = 99;
        static int champion_1_cooldown_delay = 99;


        public static void Champion_1_Turn()
        {
            champion_1_turns_per_cb_turn++;
            champion_1_turn_meter = 0;
            champion_1_unkillable_duration--;
            champion_1_block_debuffs_duration--;
            champion_1_increase_speed_duration--;
            champion_1_decrease_speed_duration--;
            champion_1_counter_attack_duration--;

            if (champion_1_cooldown <= 0)
            {
                champion_1_cooldown = champion_1_cooldown_max;
                Champion_1_Boost();
            }
            else
            {
                Champion_1_Attack();
            }

            champion_1_cooldown--;
        }


        public static void Champion_1_Attack()
        {

        }


        public static void Champion_1_Boost()
        {
            // 30% boost: champion_1_turn_meter += 428.571f;
            // 20% boost: champion_1_turn_meter += 285.714f;
            // 15% boost: champion_1_turn_meter += 214.2855f;
            // 10% boost: champion_1_turn_meter += 142.857f;
            // SpeedBuff(2);


        }
    }
}