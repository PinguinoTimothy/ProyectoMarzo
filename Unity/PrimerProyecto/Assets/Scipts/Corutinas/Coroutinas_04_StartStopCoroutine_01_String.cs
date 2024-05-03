using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinas_04_StartStopCoroutine_01_String : MonoBehaviour
{
    IEnumerator MiPrimeraCorutina(float t)
    {
        Debug.Log("La corutina, esperando " + t + " segundos");
        yield return new WaitForSeconds(t);
        Debug.Log("Hecho");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            StartCoroutine("MiPrimeraCorrutina", 2);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            StopCoroutine("MiPrimeraCorrutina");
        }
    }
}
