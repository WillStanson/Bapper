using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Sanity : MonoBehaviour
{
    public float SanityMeter, MaxSanity;
    public GameUIHandler SanityBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SanityBar.SetMaxSanity(MaxSanity);
        StartCoroutine(DecreaseSanity());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            SetSanity(-20f);
        }

        if (Input.GetKey("e"))
        {
            SetSanity(20f);
        }
    }

    IEnumerator DecreaseSanity()
    {
        while (SanityMeter > 0)
        {
            SanityMeter--;
            print(SanityMeter);
            yield return new WaitForSeconds(1);
        }

        Debug.Log("finished");
    }

    public void IncreaseSanity()
    {
        SanityMeter =+ 5;
    }

    public void SetSanity(float SanityChange)
    {
        SanityMeter += SanityChange;
        SanityMeter = Mathf.Clamp(SanityMeter, 0, MaxSanity);
        SanityBar.SetSanity(SanityMeter);
    }
}
