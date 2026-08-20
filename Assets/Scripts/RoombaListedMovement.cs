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
    private int ListIndex = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentPoint = points[ListIndex];
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //ForwardMovement(1);
        transform.position = Vector3.MoveTowards(transform.position, CurrentPoint.position, Speed *Time.deltaTime);

        if (Vector3.Distance(transform.position, CurrentPoint.position) < 0.5f)
        {
            ListIndex++;
            if (ListIndex >= points.Count)
                ListIndex = 0;

            

            CurrentPoint = points[ListIndex];
        }
    }

    void ForwardMovement(int movementDirection)
    {
        float movementAmount = Speed * movementDirection * Time.deltaTime;

        rb.linearVelocity = transform.forward * Speed * movementDirection;

    }
}
