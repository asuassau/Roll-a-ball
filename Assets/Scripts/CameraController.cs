using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    
    public GameObject player;
    private Vector3 offset;

    //Calcula la distancia inicial entre la camara y el jugador
    void Start()
    {
        offset = transform.position - player.transform.position;

    }

    //Actualiza la posicion de la camara despues de que el jugador se haya movido
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;

    }
}
