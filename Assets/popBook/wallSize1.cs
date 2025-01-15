using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallSize1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Transform transform;
    public Vector3 maxScale =new Vector3 (2f,4f,0.29635f);
    void Update()
    {
         if(transform.localScale.y< 4f)
        
        {
            transform.localScale +=maxScale *Time.deltaTime/2;
        }
    }
}
