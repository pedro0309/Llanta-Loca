using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCar : MonoBehaviour
{
    public float speed = 5f;  // Velocidad del auto
    public float wheelRotationSpeed = 300f; // Velocidad de giro de las ruedas
    public Transform[] wheels; // Array para las ruedas

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Obtener el Rigidbody del auto
    }

    void FixedUpdate()
    {
        // Mover el auto hacia adelante
        rb.MovePosition(rb.position + transform.forward * speed * Time.fixedDeltaTime);

        // Rotar las ruedas
        RotateWheels();
    }

    void RotateWheels()
    {
        foreach (Transform wheel in wheels)
        {
            wheel.Rotate(Vector3.right * wheelRotationSpeed * Time.fixedDeltaTime);
        }
    }
}
