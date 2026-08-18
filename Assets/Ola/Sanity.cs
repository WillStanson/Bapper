using UnityEngine;
using System.Collections;
public class Sanity : MonoBehaviour
{
    public int SanityMeter = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
}
