using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assigment26{
public class interfaces 
{
    public interface IRunnable{
  void Run();
   }
     

    
public interface IJumpable{  
    void Jump();
}
public interface ISwimmable{ 
    void Swim();
}
   
    public class Kangaroo : Creature , IRunnable, IJumpable{
        public void Run(){
            Debug.Log("Kangaroo runs.");
        }
        public void Jump(){
            Debug.Log("Kangaroo jumps.");
            
        }
        public override void Speak (){
            Debug.Log("Kangaroo says: Hop!");
        }
    }
    public class Duck : Creature ,IRunnable,ISwimmable{
        public void Run(){
            Debug.Log("Duck runs.");
        }public void Swim(){
            Debug.Log("Duck swims.");
        }
        public override void Speak(){
            Debug.Log("Duck says: Quack!");
        }
        
    }
    
    public class Creature 
{
    // Start is called before the first frame update
   public virtual void Speak()
   {
    Debug.Log("A creature makes a sound");
   }
    
}
}
}