using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_02_InputMouse : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("He pulsado el bot�n izquierdo del rat�n");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("He soltado el bot�n izquierdo del rat�n");
        }
    }

    private void OnGUI()
    {
        GUI.color = Color.yellow;
        GUILayout.Label("Bot�n izquierdo : " + Input.GetMouseButton(0));
        GUILayout.Label("Posici�n del rat�n: " + Input.mousePosition);
    }
}