using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
[CreateAssetMenu(fileName ="PuntajeMaximo",menuName ="Herramientas/PuntajeMaximo", order = 0)]
public class Guardado : ScriptableObject
{
    public int puntajeMaximo = 0;
    private string filepath;

    private void OnEnable()
    {
        filepath = Path.Combine(Application.persistentDataPath, "puntajeMaximo");

        CargarPuntaje();
    }
    public void GuardarDatos()
    {
        string jsonData = JsonUtility.ToJson(this,true);
        File.WriteAllText(filepath, jsonData);
    }
    public void CargarPuntaje()
    {
        if (File.Exists(filepath))
        {
            string jsonData = File.ReadAllText(filepath);
            JsonUtility.FromJsonOverwrite(jsonData,this);
        }
    }
}
