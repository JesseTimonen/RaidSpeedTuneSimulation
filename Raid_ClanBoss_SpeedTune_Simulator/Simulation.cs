using System;

namespace Raid_ClanBoss_SpeedTune_Simulator
{
    public partial class Simulation
    {
        static Random random = new Random();
        static string lowest_total_speeds_message = "No speed tuned speeds found";
        static bool running;
        static bool SpeedTuned;
        static float max_turn_meter = 1428.57f;
        static float clan_boss_speed = 190;
        static float clan_boss_turn_meter;
        static float champion_1_turn_meter;
        static float champion_2_turn_meter;
        static float champion_3_turn_meter;
        static float champion_4_turn_meter;
        static float champion_5_turn_meter;
        static int clan_boss_turns_taken;
        static int champion_1_turns_per_cb_turn;
        static int champion_2_turns_per_cb_turn;
        static int champion_3_turns_per_cb_turn;
        static int champion_4_turns_per_cb_turn;
        static int champion_5_turns_per_cb_turn;
        static int champion_1_increase_speed_duration;
        static int champion_2_increase_speed_duration;
        static int champion_3_increase_speed_duration;
        static int champion_4_increase_speed_duration;
        static int champion_5_increase_speed_duration;
        static int champion_1_decrease_speed_duration;
        static int champion_2_decrease_speed_duration;
        static int champion_3_decrease_speed_duration;
        static int champion_4_decrease_speed_duration;
        static int champion_5_decrease_speed_duration;
        static int champion_1_block_debuffs_duration;
        static int champion_2_block_debuffs_duration;
        static int champion_3_block_debuffs_duration;
        static int champion_4_block_debuffs_duration;
        static int champion_5_block_debuffs_duration;
        static int champion_1_unkillable_duration;
        static int champion_2_unkillable_duration;
        static int champion_3_unkillable_duration;
        static int champion_4_unkillable_duration;
        static int champion_5_unkillable_duration;
        static int champion_1_counter_attack_duration;
        static int champion_2_counter_attack_duration;
        static int champion_3_counter_attack_duration;
        static int champion_4_counter_attack_duration;
        static int champion_5_counter_attack_duration;
        static int champion_1_A2_cooldown;
        static int champion_1_A3_cooldown;
        static int champion_2_A2_cooldown;
        static int champion_2_A3_cooldown;
        static int champion_3_A2_cooldown;
        static int champion_3_A3_cooldown;
        static int champion_4_A2_cooldown;
        static int champion_4_A3_cooldown;
        static int champion_5_A2_cooldown;
        static int champion_5_A3_cooldown;
        static float champion_1_speed_with_increase_speed;
        static float champion_2_speed_with_increase_speed;
        static float champion_3_speed_with_increase_speed;
        static float champion_4_speed_with_increase_speed;
        static float champion_5_speed_with_increase_speed;
        static float champion_1_speed_with_increase_and_decrease_speed;
        static float champion_2_speed_with_increase_and_decrease_speed;
        static float champion_3_speed_with_increase_and_decrease_speed;
        static float champion_4_speed_with_increase_and_decrease_speed;
        static float champion_5_speed_with_increase_and_decrease_speed;
        static float champion_1_speed_with_decrease_speed;
        static float champion_2_speed_with_decrease_speed;
        static float champion_3_speed_with_decrease_speed;
        static float champion_4_speed_with_decrease_speed;
        static float champion_5_speed_with_decrease_speed;


        public static bool Run_Simulation(string difficulty, float champion_1_speed, float champion_2_speed, float champion_3_speed, float champion_4_speed, float champion_5_speed)
        {
            if (champion_1_speed + champion_2_speed + champion_3_speed + champion_4_speed + champion_5_speed > lowest_total_speeds) { return false; }

            if (difficulty == "unm")
            {
                clan_boss_speed = 190;
            }
            else if (difficulty == "nm")
            {
                clan_boss_speed = 170;
            }
            else if(difficulty == "brutal")
            {
                clan_boss_speed = 160;
            }

            running = true;
            SpeedTuned = true;


            clan_boss_turn_meter = 0f;
            champion_1_turn_meter = 0f;
            champion_2_turn_meter = 0f;
            champion_3_turn_meter = 0f;
            champion_4_turn_meter = 0f;
            champion_5_turn_meter = 0f;

            champion_1_A2_cooldown = champion_1_A2_cooldown_delay;
            champion_1_A3_cooldown = champion_1_A3_cooldown_delay;
            champion_2_A2_cooldown = champion_2_A2_cooldown_delay;
            champion_2_A3_cooldown = champion_2_A3_cooldown_delay;
            champion_3_A2_cooldown = champion_3_A2_cooldown_delay;
            champion_3_A3_cooldown = champion_3_A3_cooldown_delay;
            champion_4_A2_cooldown = champion_4_A2_cooldown_delay;
            champion_4_A3_cooldown = champion_4_A3_cooldown_delay;
            champion_5_A2_cooldown = champion_5_A2_cooldown_delay;
            champion_5_A3_cooldown = champion_5_A3_cooldown_delay;

            clan_boss_turns_taken = 0;
            champion_1_turns_per_cb_turn = 0;
            champion_2_turns_per_cb_turn = 0;
            champion_3_turns_per_cb_turn = 0;
            champion_4_turns_per_cb_turn = 0;
            champion_5_turns_per_cb_turn = 0;

            champion_1_speed_with_increase_speed = champion_1_speed * 1.3f;
            champion_2_speed_with_increase_speed = champion_2_speed * 1.3f;
            champion_3_speed_with_increase_speed = champion_3_speed * 1.3f;
            champion_4_speed_with_increase_speed = champion_4_speed * 1.3f;
            champion_5_speed_with_increase_speed = champion_5_speed * 1.3f;
            champion_1_speed_with_increase_and_decrease_speed = champion_1_speed * 1.15f;
            champion_2_speed_with_increase_and_decrease_speed = champion_2_speed * 1.15f;
            champion_3_speed_with_increase_and_decrease_speed = champion_3_speed * 1.15f;
            champion_4_speed_with_increase_and_decrease_speed = champion_4_speed * 1.15f;
            champion_5_speed_with_increase_and_decrease_speed = champion_5_speed * 1.15f;
            champion_1_speed_with_decrease_speed = champion_1_speed * 0.85f;
            champion_2_speed_with_decrease_speed = champion_2_speed * 0.85f;
            champion_3_speed_with_decrease_speed = champion_3_speed * 0.85f;
            champion_4_speed_with_decrease_speed = champion_4_speed * 0.85f;
            champion_5_speed_with_decrease_speed = champion_5_speed * 0.85f;

            champion_1_increase_speed_duration = 0;
            champion_2_increase_speed_duration = 0;
            champion_3_increase_speed_duration = 0;
            champion_4_increase_speed_duration = 0;
            champion_5_increase_speed_duration = 0;
            champion_1_decrease_speed_duration = 0;
            champion_2_decrease_speed_duration = 0;
            champion_3_decrease_speed_duration = 0;
            champion_4_decrease_speed_duration = 0;
            champion_5_decrease_speed_duration = 0;
            champion_1_block_debuffs_duration = 0;
            champion_2_block_debuffs_duration = 0;
            champion_3_block_debuffs_duration = 0;
            champion_4_block_debuffs_duration = 0;
            champion_5_block_debuffs_duration = 0;
            champion_1_unkillable_duration = 0;
            champion_2_unkillable_duration = 0;
            champion_3_unkillable_duration = 0;
            champion_4_unkillable_duration = 0;
            champion_5_unkillable_duration = 0;
            champion_1_counter_attack_duration = 0;
            champion_2_counter_attack_duration = 0;
            champion_3_counter_attack_duration = 0;
            champion_4_counter_attack_duration = 0;
            champion_5_counter_attack_duration = 0;


            // Run simulation
            while (running)
            {
                // Add turn meter to champions and clan boss
                clan_boss_turn_meter += clan_boss_speed;
                if (champion_1_increase_speed_duration > 0 && champion_1_decrease_speed_duration > 0) { champion_1_turn_meter += champion_1_speed_with_increase_and_decrease_speed; }
                else if (champion_1_increase_speed_duration > 0 && champion_1_decrease_speed_duration <= 0) { champion_1_turn_meter += champion_1_speed_with_increase_speed; }
                else if (champion_1_increase_speed_duration <= 0 && champion_1_decrease_speed_duration > 0) { champion_1_turn_meter += champion_1_speed_with_decrease_speed; }
                else { champion_1_turn_meter += champion_1_speed; }
                if (champion_2_increase_speed_duration > 0 && champion_2_decrease_speed_duration > 0) { champion_2_turn_meter += champion_2_speed_with_increase_and_decrease_speed; }
                else if (champion_2_increase_speed_duration > 0 && champion_2_decrease_speed_duration <= 0) { champion_2_turn_meter += champion_2_speed_with_increase_speed; }
                else if (champion_2_increase_speed_duration <= 0 && champion_2_decrease_speed_duration > 0) { champion_2_turn_meter += champion_2_speed_with_decrease_speed; }
                else { champion_2_turn_meter += champion_2_speed; }
                if (champion_3_increase_speed_duration > 0 && champion_3_decrease_speed_duration > 0) { champion_3_turn_meter += champion_3_speed_with_increase_and_decrease_speed; }
                else if (champion_3_increase_speed_duration > 0 && champion_3_decrease_speed_duration <= 0) { champion_3_turn_meter += champion_3_speed_with_increase_speed; }
                else if (champion_3_increase_speed_duration <= 0 && champion_3_decrease_speed_duration > 0) { champion_3_turn_meter += champion_3_speed_with_decrease_speed; }
                else { champion_3_turn_meter += champion_3_speed; }
                if (champion_4_increase_speed_duration > 0 && champion_4_decrease_speed_duration > 0) { champion_4_turn_meter += champion_4_speed_with_increase_and_decrease_speed; }
                else if (champion_4_increase_speed_duration > 0 && champion_4_decrease_speed_duration <= 0) { champion_4_turn_meter += champion_4_speed_with_increase_speed; }
                else if (champion_4_increase_speed_duration <= 0 && champion_4_decrease_speed_duration > 0) { champion_4_turn_meter += champion_4_speed_with_decrease_speed; }
                else { champion_4_turn_meter += champion_4_speed; }
                if (champion_5_increase_speed_duration > 0 && champion_5_decrease_speed_duration > 0) { champion_5_turn_meter += champion_5_speed_with_increase_and_decrease_speed; }
                else if (champion_5_increase_speed_duration > 0 && champion_5_decrease_speed_duration <= 0) { champion_5_turn_meter += champion_5_speed_with_increase_speed; }
                else if (champion_5_increase_speed_duration <= 0 && champion_5_decrease_speed_duration > 0) { champion_5_turn_meter += champion_5_speed_with_decrease_speed; }
                else { champion_5_turn_meter += champion_5_speed; }

                // Check turns
                if (clan_boss_turn_meter >= max_turn_meter || champion_1_turn_meter >= max_turn_meter || champion_2_turn_meter >= max_turn_meter || champion_3_turn_meter >= max_turn_meter || champion_4_turn_meter >= max_turn_meter || champion_5_turn_meter >= max_turn_meter)
                {
                    if (champion_1_turn_meter >= clan_boss_turn_meter && champion_1_turn_meter >= champion_2_turn_meter && champion_1_turn_meter >= champion_3_turn_meter && champion_1_turn_meter >= champion_4_turn_meter && champion_1_turn_meter >= champion_5_turn_meter)
                    {
                        Champion_1_Turn();
                    }
                    else if (champion_2_turn_meter >= clan_boss_turn_meter && champion_2_turn_meter >= champion_1_turn_meter && champion_2_turn_meter >= champion_3_turn_meter && champion_2_turn_meter >= champion_4_turn_meter && champion_2_turn_meter >= champion_5_turn_meter)
                    {
                        Champion_2_Turn();
                    }
                    else if (champion_3_turn_meter >= clan_boss_turn_meter && champion_3_turn_meter >= champion_1_turn_meter && champion_3_turn_meter >= champion_2_turn_meter && champion_3_turn_meter >= champion_4_turn_meter && champion_3_turn_meter >= champion_5_turn_meter)
                    {
                        Champion_3_Turn();
                    }
                    else if (champion_4_turn_meter >= clan_boss_turn_meter && champion_4_turn_meter >= champion_1_turn_meter && champion_4_turn_meter >= champion_2_turn_meter && champion_4_turn_meter >= champion_3_turn_meter && champion_4_turn_meter >= champion_5_turn_meter)
                    {
                        Champion_4_Turn();
                    }
                    else if (champion_5_turn_meter >= clan_boss_turn_meter && champion_5_turn_meter >= champion_1_turn_meter && champion_5_turn_meter >= champion_2_turn_meter && champion_5_turn_meter >= champion_3_turn_meter && champion_5_turn_meter >= champion_4_turn_meter)
                    {
                        Champion_5_Turn();
                    }
                    else if (clan_boss_turn_meter >= champion_1_turn_meter && clan_boss_turn_meter >= champion_2_turn_meter && clan_boss_turn_meter >= champion_3_turn_meter && clan_boss_turn_meter >= champion_4_turn_meter && clan_boss_turn_meter >= champion_5_turn_meter)
                    {
                        clan_boss_turns_taken++;
                        clan_boss_turn_meter = 0;
                        ClanBoss();

                        if (enable_debuffs && (clan_boss_turns_taken - 2) % 3 == 0)
                        {
                            if (random.Next(0, 11) < 7 && champion_1_block_debuffs_duration <= 0)
                            {
                                champion_1_decrease_speed_duration = 2;
                            }
                            if (random.Next(0, 11) < 7 && champion_2_block_debuffs_duration <= 0)
                            {
                                champion_2_decrease_speed_duration = 2;
                            }
                            if (random.Next(0, 11) < 7 && champion_3_block_debuffs_duration <= 0)
                            {
                                champion_3_decrease_speed_duration = 2;
                            }
                            if (random.Next(0, 11) < 7 && champion_4_block_debuffs_duration <= 0)
                            {
                                champion_4_decrease_speed_duration = 2;
                            }
                            if (random.Next(0, 11) < 7 && champion_5_block_debuffs_duration <= 0)
                            {
                                champion_5_decrease_speed_duration = 2;
                            }
                        }

                        if (clan_boss_turns_taken % clan_boss_check_turns_at == 0)
                        {
                            if ((clan_boss_turns_taken - speed_tuned_after_cb_attack) > 0)
                            {
                                ClanBossCheckTurns();
                            }

                            champion_1_turns_per_cb_turn = 0;
                            champion_2_turns_per_cb_turn = 0;
                            champion_3_turns_per_cb_turn = 0;
                            champion_4_turns_per_cb_turn = 0;
                            champion_5_turns_per_cb_turn = 0;
                        }

                        if (clan_boss_turns_taken > speed_tuned_after_cb_attack + speed_tuned_turns)
                        {
                            running = false;
                        }
                    }
                }
            }

            return SpeedTuned;
        }


        public static void Cleanse()
        {
            champion_1_decrease_speed_duration = 0;
            champion_2_decrease_speed_duration = 0;
            champion_3_decrease_speed_duration = 0;
            champion_4_decrease_speed_duration = 0;
            champion_5_decrease_speed_duration = 0;
        }


        public static void Unkillable(int duration)
        {
            if (champion_1_unkillable_duration < duration) { champion_1_unkillable_duration = duration; }
            if (champion_2_unkillable_duration < duration) { champion_2_unkillable_duration = duration; }
            if (champion_3_unkillable_duration < duration) { champion_3_unkillable_duration = duration; }
            if (champion_4_unkillable_duration < duration) { champion_4_unkillable_duration = duration; }
            if (champion_5_unkillable_duration < duration) { champion_5_unkillable_duration = duration; }
        }


        public static void BlockDebuffs(int duration)
        {
            if (champion_1_block_debuffs_duration < duration) { champion_1_block_debuffs_duration = duration; }
            if (champion_2_block_debuffs_duration < duration) { champion_2_block_debuffs_duration = duration; }
            if (champion_3_block_debuffs_duration < duration) { champion_3_block_debuffs_duration = duration; }
            if (champion_4_block_debuffs_duration < duration) { champion_4_block_debuffs_duration = duration; }
            if (champion_5_block_debuffs_duration < duration) { champion_5_block_debuffs_duration = duration; }
        }


        public static void CounterAttack(int duration)
        {
            if (champion_1_counter_attack_duration < duration) { champion_1_counter_attack_duration = duration; }
            if (champion_2_counter_attack_duration < duration) { champion_2_counter_attack_duration = duration; }
            if (champion_3_counter_attack_duration < duration) { champion_3_counter_attack_duration = duration; }
            if (champion_4_counter_attack_duration < duration) { champion_4_counter_attack_duration = duration; }
            if (champion_5_counter_attack_duration < duration) { champion_5_counter_attack_duration = duration; }
        }


        public static void SpeedBuff(int duration)
        {
            if (champion_1_increase_speed_duration < duration) { champion_1_increase_speed_duration = duration; }
            if (champion_2_increase_speed_duration < duration) { champion_2_increase_speed_duration = duration; }
            if (champion_3_increase_speed_duration < duration) { champion_3_increase_speed_duration = duration; }
            if (champion_4_increase_speed_duration < duration) { champion_4_increase_speed_duration = duration; }
            if (champion_5_increase_speed_duration < duration) { champion_5_increase_speed_duration = duration; }
        }


        public static void ExtendBuffs(int duration)
        {
            if (champion_1_unkillable_duration >= 1) { champion_1_unkillable_duration = champion_1_unkillable_duration + duration; }
            if (champion_1_block_debuffs_duration >= 1) { champion_1_block_debuffs_duration = champion_1_block_debuffs_duration + duration; }
            if (champion_1_increase_speed_duration >= 1) { champion_1_increase_speed_duration = champion_1_increase_speed_duration + duration; }
            if (champion_1_counter_attack_duration >= 1) { champion_1_counter_attack_duration = champion_1_counter_attack_duration + duration; }

            if (champion_2_unkillable_duration >= 1) { champion_2_unkillable_duration = champion_2_unkillable_duration + duration; }
            if (champion_2_block_debuffs_duration >= 1) { champion_2_block_debuffs_duration = champion_2_block_debuffs_duration + duration; }
            if (champion_2_increase_speed_duration >= 1) { champion_2_increase_speed_duration = champion_2_increase_speed_duration + duration; }
            if (champion_2_counter_attack_duration >= 1) { champion_2_counter_attack_duration = champion_2_counter_attack_duration + duration; }

            if (champion_3_unkillable_duration >= 1) { champion_3_unkillable_duration = champion_3_unkillable_duration + duration; }
            if (champion_3_block_debuffs_duration >= 1) { champion_3_block_debuffs_duration = champion_3_block_debuffs_duration + duration; }
            if (champion_3_increase_speed_duration >= 1) { champion_3_increase_speed_duration = champion_3_increase_speed_duration + duration; }
            if (champion_3_counter_attack_duration >= 1) { champion_3_counter_attack_duration = champion_3_counter_attack_duration + duration; }

            if (champion_4_unkillable_duration >= 1) { champion_4_unkillable_duration = champion_4_unkillable_duration + duration; }
            if (champion_4_block_debuffs_duration >= 1) { champion_4_block_debuffs_duration = champion_4_block_debuffs_duration + duration; }
            if (champion_4_increase_speed_duration >= 1) { champion_4_increase_speed_duration = champion_4_increase_speed_duration + duration; }
            if (champion_4_counter_attack_duration >= 1) { champion_4_counter_attack_duration = champion_4_counter_attack_duration + duration; }

            if (champion_5_unkillable_duration >= 1) { champion_5_unkillable_duration = champion_5_unkillable_duration + duration; }
            if (champion_5_block_debuffs_duration >= 1) { champion_5_block_debuffs_duration = champion_5_block_debuffs_duration + duration; }
            if (champion_5_increase_speed_duration >= 1) { champion_5_increase_speed_duration = champion_5_increase_speed_duration + duration; }
            if (champion_5_counter_attack_duration >= 1) { champion_5_counter_attack_duration = champion_5_counter_attack_duration + duration; }
        }
    }
}