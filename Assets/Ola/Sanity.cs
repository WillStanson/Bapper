using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class Sanity : MonoBehaviour
{
    public float SanityMeter, MaxSanity;
    public int SceneToLoad;
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
        if (SanityMeter <= 0)
        {
            SceneManager.LoadSceneAsync(SceneToLoad);
        }
    }

    IEnumerator DecreaseSanity()
    {
        while (SanityMeter > 0)
        {
            SetSanity(-1.8f);
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

    public void RoombaLoss()
    {
        SceneManager.LoadSceneAsync(SceneToLoad);
    }
}
