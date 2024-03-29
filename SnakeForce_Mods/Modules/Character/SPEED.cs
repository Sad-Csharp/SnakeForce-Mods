﻿using UnityEngine;
using SnakeForce_Mods;
using BepInEx.Configuration;


namespace SnakeForce_Mods.Modules.Character
{
    public class SPEED
    {
        public static ConfigEntry<KeyCode> keycodeSpeed;
        public static ConfigEntry<int> speedSpeed;

        public static void Update()
        {
            if (Input.GetKeyDown(keycodeSpeed.Value))
            {
                Main.PlayerSearch();
                Main.FollowSearch();
                Main.P_Control.speed = speedSpeed.Value;
                Main.P_Control.maxSpeed = speedSpeed.Value;
                Debug.Log("Speed Mod Applied!");
            }
        }
    }
}