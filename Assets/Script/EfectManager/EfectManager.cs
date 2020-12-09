using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectManager : MonoBehaviour
{
    public float x, y, z = 0f;
    
    void Update()
    {
        transform.Rotate(new Vector3(x, y, z));
    }
}
