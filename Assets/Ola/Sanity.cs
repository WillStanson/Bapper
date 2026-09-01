using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Sanity : MonoBehaviour
{
    public float SanityMeter, MaxSanity;
    public int SceneToLoad;

    public Image SanityImage;
    public AudioSource Heartbeat;
    public GameUIHandler SanityBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SanityBar.SetMaxSanity(MaxSanity);
        SanityImage.color = new Color(0.2127827f, 0.5345911f, 0.05211414f);
        StartCoroutine(DecreaseSanity());
    }

    // Update is called once per frame
    void Update()
    {
        if (SanityMeter <= 0)
        {
            SceneManager.LoadSceneAsync(SceneToLoad);
        }

        if (SanityMeter <= 66f && SanityMeter >= 33)
        {
            Heartbeat.pitch = 1;
            SanityImage.color = new Color(0.6352201f, 0.538301f, 0.09787969f);
        }

        else if (SanityMeter < 33)
        {
            Heartbeat.pitch = 1.3f;
            SanityImage.color = new Color(0.3144653f, 0.09196623f, 0.135443f);
        }

        else
        {
            Heartbeat.pitch = 0.7f;
            SanityImage.color = new Color(0.2127827f, 0.5345911f, 0.05211414f);
        }
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
        SanityMeter += 40f;
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
