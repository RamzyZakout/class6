using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class camera : MonoBehaviour
{
    public GameObject gameObject;
    public Color color;
    Renderer renderer;
     Material material ;
     Color startColor=Color.blue;
     Color endColor=Color.red;
    float timer=0;
    void Start()
    {
         renderer=GetComponent<Renderer>();
         material = renderer.material;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        material.color= Color.Lerp(startColor,endColor,timer/4);
                    transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
