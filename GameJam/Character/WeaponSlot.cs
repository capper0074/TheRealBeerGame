﻿using GameJam.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Character
{
    public static class WeaponSlot
    {
        private static bool isInitialize;

        private static List<Weapon> weapons;

        public static void Initialize()
        {
            if (isInitialize)
            {
                return;
            }

            weapons = new List<Weapon>();

            if (!isInitialize)
            {
                Weapon TestVåben = new Weapon("TestVåben", 5, 10);
                weapons.Add(TestVåben);
                isInitialize = true;
            }

        }

        public static void SwitchWeapon(Weapon weapon)
        {

            bool state = true;

            while (state == true)
            {
                Console.Clear();
                Console.WriteLine("Congrats you just found a new weapon");
                Console.WriteLine("you found: " + weapon.Name + " And it's stats are: " + weapon.WeaponAttack);
                Console.WriteLine("your current weapon is: " + weapons[0].Name + " And it's stats are: " + weapons[0].WeaponAttack);
                Console.WriteLine("Do you want to switch Yes / No");
                string playerChoice = Console.ReadLine();

                if (playerChoice.ToLower() == "yes")
                {
                    weapons.Remove(weapons[0]);
                    weapons.Add(weapon);
                    Console.WriteLine("You just switched your weapon :)");
                }
                else if (playerChoice.ToLower() == "no")
                {
                    state = false;
                    Console.Clear();
                }

            }

        }

        public static void DisplayCurrentWeapon()
        {
            Console.WriteLine("This is your current weapon: " + weapons[0].Name + " And it's stats are: " + weapons[0].WeaponAttack);
        }

        public static string DisplayName()
        {
            return weapons[0].Name;
        }

        public static int DisplayStat()
        {
            return weapons[0].WeaponAttack;
        }








    }
}
