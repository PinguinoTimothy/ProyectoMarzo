using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinas_03_Yield_Example_02_null : MonoBehaviour
{
    IEnumerator Start()
    {
        Debug.Log("Frame actual: " + Time.frameCount);
        yield return null;
        Debug.Log("Frame actual: " + Time.frameCount);
    }
}
