using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vnaDamme : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int counter = 0;
        while (counter < 20)
        {
            int x = Random.Range(1, 21);
            Debug.Log(x); counter++;
            if (x == 5)
            {
                break;
                Debug.Log("kabssa");



            }

            
        } while (counter < 20)
        {
            int v = Random.Range(1, 21);
            Debug.Log(v); counter++;
            if (v == 5)
            {
                Debug.Log(v);
                continue;
                Debug.Log("kabssa"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
    }
}