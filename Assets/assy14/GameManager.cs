using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
                 
             Player playe=new Player("subhi",44);
        playe.heal(22);
        Enemy enemy =new Enemy ();
        enemy.Attak(playe,50);
    }

    }

    
 
