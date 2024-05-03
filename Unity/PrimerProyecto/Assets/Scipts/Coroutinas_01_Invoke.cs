using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinas_01_Invoke : MonoBehaviour
{
    void Start()
    {
        InvokeRepeating("SayHi", 5f, 1f);
    }

    public void SayHi()
    {
        Debug.Log("Hola");
    }
}
