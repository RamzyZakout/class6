using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class character 
{
  private string name;
  private int health;
  public string Name {
    get {return name;}
    set {name= value;}

  }
  public int Health{
    get{return health;}
    set{ health= value;
    
    } 
  }
  public character(string name,int health){
     Name=name;
    Health=health;

   }


}
