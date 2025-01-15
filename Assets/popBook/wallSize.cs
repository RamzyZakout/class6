using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallSize : MonoBehaviour
{
    
    void Start()
    {}
    public Transform transform;
    

    public Vector3 maxScale =new Vector3 (0.49796f,0.49796f,0.49796f);
    void Update()
    {
        if( 
            transform.localScale.x<0.49796 &&
            transform.localScale.y<0.49796f &&
            transform.localScale.z<0.49796f){
       
        
            transform.localScale +=maxScale *Time.deltaTime/2;
        }
    }
}
