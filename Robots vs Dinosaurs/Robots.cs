﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    public class Robots
    {
        public string roboName;
        public int roboHealth;
        public int roboPowerLevel;
        public int roboWeapon;
        public string roboWeaponType;

    
        public Robots(string roboName, int roboHealth, int roboPowerLevel, int roboWeapon, string roboWeaponType, int roboAttackPower)
        {
            this.roboName = roboName;
            this.roboHealth = roboHealth;
            this.roboPowerLevel = roboPowerLevel;
            this.roboWeapon = roboWeapon;
            this.roboWeaponType = roboWeaponType;
        }
        

    } 
}









