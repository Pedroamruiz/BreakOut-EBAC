using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Unity_Event : MonoBehaviour
{
    public UnityEvent Mi_evento_Unity;
    public void Evento_iniciado()
    {
        Debug.Log("Evento iniciado");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Mi_evento_Unity.Invoke();
        }
    }
}