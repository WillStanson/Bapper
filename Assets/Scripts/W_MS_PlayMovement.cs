using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class W_MS_PlayMovement : MonoBehaviour
{

    [SerializeField] private KeyCode leftButton;
    [SerializeField] private KeyCode rightButton;
    [SerializeField] private KeyCode forwardButton;
    [SerializeField] private KeyCode backwardButton;

    private Rigidbody rb;
    private float movementX;
    private float movementY;
    [SerializeField] private float speed = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

}
