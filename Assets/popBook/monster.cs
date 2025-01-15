using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class monster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Vector3 maxScl= new Vector3 (0.0f,0f,0f);
   
    // Update is called once per frame
    void Update()
    {
        if(transform.localScale.y< 1f){
            transform.localScale +=maxScl *Time.deltaTime/2 ;
        }
    }
}
