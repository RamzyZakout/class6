using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Vector3 vector3 =new Vector3 (0.51209f,0.3866549f,1.483556f);
    // Update is called once per frame
    void Update()
    {
        if(transform.lossyScale.z <1.483556f)
        {
            transform.localScale +=vector3 * Time.deltaTime /2;
        }
    }
}
