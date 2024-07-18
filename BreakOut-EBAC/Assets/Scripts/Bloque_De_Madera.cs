using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_De_Madera : Bloque_Base
{
    void Start()
    {
        Resistencia = 3;
    }
    public override void Rebotar_Bola()
    {
        base.Rebotar_Bola();
    }
}
