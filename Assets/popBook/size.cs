using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class size : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    
    {
        
    }
    public Transform transform;
   
      public float speed = 5f;
    public float upperLimit = 10f; 
    
    void Update()
    {
         if (transform.position.y < upperLimit)
        {
            
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
    }
}
    
     
