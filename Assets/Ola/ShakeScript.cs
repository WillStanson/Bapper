using System.Collections;
using UnityEngine;

public class ShakeScript : MonoBehaviour
{
    public float Duration = 1f;
    public AnimationCurve Curve;
    private bool IsShaking;
    public Transform CameraTarget;
    TimerScript RefTimer;
    void Start()
    {
        RefTimer = FindAnyObjectByType<TimerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = CameraTarget.rotation;

        if (IsShaking == true)
            return;

        transform.position = CameraTarget.position;

        

        if (RefTimer.Timer == 60 || RefTimer.Timer == 120 || RefTimer.Timer == 180 || RefTimer.Timer == 240)
        {
            StartCoroutine(Shake());
        }
    }

    IEnumerator Shake()
    {
        IsShaking = true;
        
        float elapsedTime = 0f;

        while (elapsedTime < Duration)
        {
            elapsedTime += Time.deltaTime;
            float strength = Curve.Evaluate(elapsedTime / Duration);
            transform.position = CameraTarget.position + Random.insideUnitSphere * strength;
            yield return null;
        }

        IsShaking = false;
    }
}
