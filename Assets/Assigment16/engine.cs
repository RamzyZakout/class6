using System.Collections;
using System.Collections.Generic;
using Assigment18;
using UnityEngine;

public class engine : MonoBehaviour
{

    void Start()
    {
        Officer officer = new Officer("ramzy", 100, new Position(1f, 2f, 1f));
        Soldier soldier = new Soldier();
        Character[] characters = { officer, soldier };

       for (int i = 0; i < characters.Length; i++){
          characters[i].DisplayInfo();;
       }
       officer.Attack(20,soldier,"shoot");
    }


    void Update()
    {

    }
}
