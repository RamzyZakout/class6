using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
namespace Assigment18 {
public struct Position
{
        private float x;
    private float y;
    private float z;

   
    public float X
    {
        get { return x; }
        set { x = value; }
    }

    public float Y
    {
        get { return y; }
        set { y = value; }
    }

    public float Z
    {
        get { return z; }
        set { z = value; }
    }

    
    public Position(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public void printPosition(){
        Debug.Log(X+" "+Y+" "+Z);
    }
}       

}