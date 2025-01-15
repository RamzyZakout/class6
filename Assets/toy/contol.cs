using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        
        
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        
        // Change the background color to green
        Camera.main.backgroundColor = Color.green;

    }
    public float moveSpeed = 2f;
    public float jamppower = 5f;
    public Vector3 scaleFactor = new Vector3(0.01f, 0.01f, 0.01f);
    

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.KeypadPlus))
        {

            transform.localScale += scaleFactor;
        }
        if (Input.GetKey(KeyCode.KeypadMinus))
        {

            transform.localScale -= scaleFactor;

        }
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        transform.position += new Vector3(moveX, 0, moveZ) * moveSpeed * Time.deltaTime;
    }
        

    
}
     
            
        
        
    










