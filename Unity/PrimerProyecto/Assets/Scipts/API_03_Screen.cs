using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_03_Screen : MonoBehaviour
{
    int currentRes = 0;

    private void Start()
    {
        Debug.Log("Resoluci�n: " + Screen.currentResolution.ToString());
        Debug.Log("DPI: " + Screen.dpi);
        foreach (var r in Screen.resolutions)
        {
            Debug.Log("Resoluci�n: " + r.ToString());
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Screen.fullScreen = !Screen.fullScreen;
        }

        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            currentRes++;
            currentRes %= Screen.resolutions.Length;
            Screen.SetResolution(Screen.resolutions[currentRes].width, Screen.resolutions[currentRes].height, Screen.fullScreen);
        }

    }
}