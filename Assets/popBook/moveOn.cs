using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed =1f;
    public float maxPos=39.00005f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<maxPos){
            transform.position+= Vector3.up *speed *Time.deltaTime;
        }
        
        
    }
}
