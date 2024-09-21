using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Base : MonoBehaviour
{
    public int Resistencia = 1;
    void Update()
    {
        if (Resistencia <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    public virtual void Rebotar_Bola()
    {

    }
}