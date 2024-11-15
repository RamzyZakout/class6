using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : character

{
   
    public void Attak(character target,int damage){
        if (damage >0){
            target.Health-=damage;
        }if(damage<0){
            target.Health=0;
        }
        Debug.Log(target.Health+" "+target.Name);
    }
}

