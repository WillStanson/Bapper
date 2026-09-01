using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoombaListedMovement : MonoBehaviour
{
    [SerializeField] private List<Transform> points;
    public float Speed = 5;
    private Transform CurrentPoint;
    private Vector3 CurrentDir;
    private Rigidbody rb;
    private int ListIndex = 0;

    TimerScript TimerRef;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentPoint = points[ListIndex];
        rb = GetComponent<Rigidbody>();
        TimerRef = FindAnyObjectByType<TimerScript>();
        StartCoroutine(SpeedIncreaseTimer());
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

    public void IncreaseSpeed()
    {
        Speed += Speed * 0.1f;
    }

    IEnumerator SpeedIncreaseTimer()
    {
        while (TimerRef.Timer < 280)
        {
            yield return new WaitForSeconds(60);
            IncreaseSpeed();
        }
    }
}
