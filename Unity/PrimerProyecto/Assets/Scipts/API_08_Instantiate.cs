using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_08_Instantiate : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 newPosition;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Instantiate(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, newPosition, Quaternion.identity);
        }

   
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10f;
            Vector3 worlPos = Camera.main.ScreenToWorldPoint(mousePos);
            Instantiate(prefab, worlPos, Quaternion.identity);
        }
    }
}