using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_De_Goma : Bloque_Base
{
    void Start()
    {
        Resistencia = 4;
    }
    public override void Rebotar_Bola()
    {
        base.Rebotar_Bola();
    }
}