using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class pla: MonoBehaviour
{
    void Start()
    
    { }
       public string playerName;
    public int health;
    public static int playerCount;
    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++;
    }
  public  void heal(int amount)
    {
        health += amount;
        Debug.Log(health);
    }
  public  void OverHeal(bool fullHeal)
    {
        if (fullHeal)
        {
            health = 100;
            Debug.Log(health);

        }

    }
    public static void ShowPlayerCount()
    {
        Debug.Log(playerCount);
    }
   
}
