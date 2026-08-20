using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class RoombaListedMovement : MonoBehaviour
{
    [SerializeField] private List<Transform> points;
    [SerializeField] private float Speed = 5;
    private Transform CurrentPoint;
    private Vector3 CurrentDir;
    private Rigidbody rb;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentPoint = points[1];
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ForwardMovement(1);
        CurrentDir = CurrentPoint.X - rb.transform.x;
    }

    void ForwardMovement(int movementDirection)
    {
        float movementAmount = Speed * movementDirection * Time.deltaTime;

        rb.linearVelocity = transform.forward * Speed * movementDirection;

    }
}
