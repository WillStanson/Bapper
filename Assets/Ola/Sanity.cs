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
       
    }

    IEnumerator DecreaseSanity()
    {
        while (SanityMeter > 0)
        {
            SetSanity(-2f);
            print(SanityMeter);
            yield return new WaitForSeconds(1);
        }

        Debug.Log("finished");
    }

    public void IncreaseSanity()
    {
        SanityMeter += 60f;
    }

    public void SetSanity(float SanityChange)
    {
        SanityMeter += SanityChange;
        SanityMeter = Mathf.Clamp(SanityMeter, 0, MaxSanity);
        SanityBar.SetSanity(SanityMeter);
    }
}
