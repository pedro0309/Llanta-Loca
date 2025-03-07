using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIfFar : MonoBehaviour
{
    public Transform player;  // Referencia al Player
    public float delay = 5f;  // Tiempo antes de destruir el objeto
    private bool isBehind = false; // Controla si el obst�culo ya est� detr�s

    void Update()
    {
        // Verifica si el obst�culo ya qued� atr�s del Player
        if (!isBehind && transform.position.z < player.position.z)
        {
            isBehind = true; // Marca que el obst�culo ya est� detr�s
            StartCoroutine(DestroyAfterDelay()); // Inicia la cuenta regresiva
        }
    }

    IEnumerator DestroyAfterDelay()
    {
        yield return new WaitForSeconds(delay); // Espera 5 segundos
        Destroy(gameObject); // Destruye el obst�culo
    }
}
