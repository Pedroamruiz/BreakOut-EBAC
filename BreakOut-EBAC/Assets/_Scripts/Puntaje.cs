using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    public Transform transformPuntajeMaximo;
    public Transform transformPuntajeActual;
    public TMP_Text textoPuntajeMaximo;
    public TMP_Text textoActual;
    public Guardado PuntajeMaximoSO;
    public int puntosActuales = 0;

    void Start()
    {
        transformPuntajeActual = GameObject.Find("PuntajeActual").transform;
        transformPuntajeMaximo = GameObject.Find("PuntajeMaximo").transform;
        textoActual = transformPuntajeActual.GetComponent<TMP_Text>();
        textoPuntajeMaximo = transformPuntajeMaximo.GetComponent<TMP_Text>();
        PuntajeMaximoSO.CargarPuntaje();
        textoPuntajeMaximo.text = $"Puntaje Maximo : {PuntajeMaximoSO.puntajeMaximo}";
    }

    void Update()
    {
     textoActual.text = $"Puntaje actual : {puntosActuales}";
     if (puntosActuales > PuntajeMaximoSO.puntajeMaximo)
        {
            PuntajeMaximoSO.puntajeMaximo = puntosActuales;
            textoPuntajeMaximo.text = $"Puntaje Maximo : {PuntajeMaximoSO.puntajeMaximo}";
            PuntajeMaximoSO.GuardarDatos();
        }
     if (Input.GetKeyDown(KeyCode.Space))
        {
            puntosActuales += 100;
        }
    }
}
