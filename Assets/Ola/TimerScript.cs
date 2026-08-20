using System.Collections;
using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class TimerScript : MonoBehaviour
{
    private int Timer = 0;

    public List<GameObject> SpawnList;
    public TextMeshProUGUI MyTextElement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        StartCoroutine(IncreaseTimer());
        StartCoroutine(StartRandomSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        MyTextElement.text = Timer.ToString();

       
    }

    IEnumerator IncreaseTimer()
    {
        while (Timer < 301)
        {
            Timer += 1;
            print(Timer);
            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator StartRandomSpawn()
    {
        while (Timer < 301)
        {
            yield return new WaitForSeconds(30);
            SpawnList[Random.Range(0, 5)].SetActive(true);
        }
    }

  
}
