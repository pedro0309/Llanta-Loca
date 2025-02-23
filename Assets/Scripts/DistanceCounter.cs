using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DistanceCounter : MonoBehaviour
{
    public Transform player; //Referencia al Player
    public TextMeshProUGUI distanceText;
    private float startZ; //Posicion inicial en el eje Z

    void Start()
    {
        if (player != null)
        {
            startZ = player.position.z; //Guarda la posicion inicial
        }
    }

    void Update()
    {
        if (player != null && distanceText != null)
        {
            float distance = player.position.z - startZ; // Calcula la distancia recorrida
            distanceText.text = $"Distancia: {Mathf.FloorToInt(distance)} m"; // Actualiza la UI
        }
    }
}
