using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Enemyinfo
{
    public int vida;
    public int fuerza;
}

public class MiPrimerComponente : MonoBehaviour
{
    public int vida = 3;

    [HideInInspector]
    public float fuerza = 10.0f;

    public Enemyinfo info;
    public Transform enemyTransform;

    [SerializeField]
    private string playerName = "Ian";

    void Start()
    {
        print(gameObject.name);
    }
}