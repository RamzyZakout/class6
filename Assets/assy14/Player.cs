using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : character
{
       public Player(string name, int health) : base(name, health)
    {
    }
    public void heal(int amount) {
        if(amount>0){
            Health +=amount;
        } if(Health>100){
            Health=100;
        }
        Debug.Log(Name +" "+Health);
    }
}
