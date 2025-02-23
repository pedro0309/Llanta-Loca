using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float moveInputX;
    [SerializeField]
    float moveSpeed;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); //Obtener el Animator del GO
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        //Horizontal
        moveInputX = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * moveInputX * moveSpeed * Time.deltaTime);

        //Movimiento hacia delante perpetuo
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // Control de animaciones
        if (moveInputX < 0) // Movimiento a la izquierda
        {
            animator.SetBool("isMovingLeft", true);
            animator.SetBool("isMovingRight", false);
        }
        else if (moveInputX > 0) // Movimiento a la derecha
        {
            animator.SetBool("isMovingLeft", false);
            animator.SetBool("isMovingRight", true);
        }
        else // No hay movimiento
        {
            animator.SetBool("isMovingLeft", false);
            animator.SetBool("isMovingRight", false);
        }
    }
}
