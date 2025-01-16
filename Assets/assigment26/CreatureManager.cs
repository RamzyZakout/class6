using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        interfaces.Kangaroo kangaroo= new interfaces.Kangaroo();
        interfaces.Duck duck=new interfaces.Duck();
         List<interfaces.Creature> creatures = new List<interfaces.Creature> { kangaroo, duck };
         List<interfaces.IRunnable> runnables =new List<interfaces.IRunnable>();
         List<interfaces.IJumpable> jumpables=new List<interfaces.IJumpable>();
         List<interfaces.ISwimmable> swimmables=new List<interfaces.ISwimmable>();

         runnables.Add((interfaces.IRunnable)kangaroo);
         jumpables.Add((interfaces.IJumpable)kangaroo);
         runnables.Add((interfaces.IRunnable)duck);
         swimmables.Add((interfaces.ISwimmable)duck);

        foreach(var cre in creatures){
            cre.Speak();
        }
        foreach(var cre in runnables ){
            cre.Run();
        }
        
        foreach(var cre in jumpables ){
            cre.Jump();
        }
        foreach(var cre in swimmables ){
            cre.Swim();
        }


    // Update is called once per frame
    void Update()
    {
        
        
    }
}
}