using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotat1 : MonoBehaviour
{
    public Transform transform;
    private float currentAngle = 0f;
    public float speed=20f;
    void Start()
    {
    
    }   

    
    // Update is called once per frame
    void Update()
    {
         if (currentAngle < 180f)
        {
            
            float angleToAdd = speed * Time.deltaTime*3;

            
            if (currentAngle + angleToAdd > 180f)
            {
                angleToAdd = 180f - currentAngle;
            }

           
            currentAngle += angleToAdd;

            
            transform.rotation = Quaternion.Euler(0, 0, currentAngle);
        }
    }
}

