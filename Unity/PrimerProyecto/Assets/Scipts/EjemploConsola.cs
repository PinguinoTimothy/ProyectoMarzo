using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploConsola : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mensaje de informacion");
            Debug.LogWarning("Una advertencia");
        Debug.LogError("Error catastrofico");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
