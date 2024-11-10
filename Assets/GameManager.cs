using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    
    void Start()
    {
        Player player1=new Player();
        Player player2=new Player();

         player1.InitializePlayer("ramzy",50);
        player1.heal(30);
        player1.OverHeal(true);
         player2.InitializePlayer("ali",90);
        player2.heal(30);
        player2.OverHeal(false);
        Player.ShowPlayerCount();
    }

    void Update()
    {
        
    }
}
