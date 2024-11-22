using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assigment18
{
    public class Character
    {

        public string Name { get; set; }

        private int health;
        protected Position position;

        public int Health
        {
            get => health;
            set
            {
                if (value < 0)
                    health = 0;
                else if (value > 100)
                    health = 100;
                else
                    health = value;
            }
        }

        public Character(string name, int health, Position position)
        {
            Name = name;
            Health = health;
            this.position = position;
        }

        public Character() : this("", 44, new Position(0, 0, 0)) { }

        public virtual void DisplayInfo()
        {
            Debug.Log(Name+" "+Health);
            position.printPosition();
        }

        public void Attack(int damage, Character target)
        {
            if (damage > 0)
            {
                target.Health -= damage;
                
            }
            else
            {
                target.Health = 0;
                
            }
        }

        public void Attack(int damage, Character target, string attackType)
        {
            Debug.Log(attackType);
            Attack(damage, target);
        }
    }

}
