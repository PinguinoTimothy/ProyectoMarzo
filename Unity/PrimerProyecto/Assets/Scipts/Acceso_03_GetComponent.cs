using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceso_03_GetComponent : MonoBehaviour
{
    void Start()
    {
        Enemy e = GetComponent<Enemy>();
        if (e != null)
        {
            print("Encontrado componente: " + e.name);
        }
        else
        {
            print("Error, no tenemos componente Enemy!");
        }
    }
}