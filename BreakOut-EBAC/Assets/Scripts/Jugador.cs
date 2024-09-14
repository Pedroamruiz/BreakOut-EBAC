using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] public int limiteX = 23;
    [SerializeField] public float VelocidadPaddle = 20.0f;
    Vector3 mousePos2D;
    Vector3 mousePos3D;
    private void Update()
    {
        //mousePos2D = Input.mousePosition;
        //mousePos2D.z = -Camera.main.transform.position.z;
        //mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        //pos.x = mousePos3D.x;

        transform.Translate(Input.GetAxis("Horizontal") * Vector3.down * VelocidadPaddle * Time.deltaTime);

        Vector3 pos = transform.position;
        if (pos.x < -limiteX)
        {
            pos.x = -limiteX;
        }
        else if (pos.x > limiteX)
        {
            pos.x = limiteX;
        }
        transform.position = pos;
    }
}
