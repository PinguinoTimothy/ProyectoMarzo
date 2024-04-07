using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiComponente : MonoBehaviour
{
    public int numero;
    public float peso;
    public string nombre;
    public Transform unTransform;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Debug.Log("Destruido un enemigo");
        }
        else if (collision.gameObject.CompareTag("Friend"))
        {
            Debug.Log("Hola bola amiga " + collision.gameObject.name);
        }
    }

    
}
