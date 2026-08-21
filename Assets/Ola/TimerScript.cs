using System.Collections;
using UnityEngine;
using TMPro;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    private int Timer = 0;
    public int SceneToLoad;

    public List<GameObject> SpawnList;
    public TextMeshProUGUI MyTextElement;

    RoombaListedMovement SpeedRef;

    // Fredrik post launch patch
    [SerializeField] private int ToySpawnInterval = 30;
    [SerializeField] private int GameLength = 280;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        StartCoroutine(IncreaseTimer());
        StartCoroutine(StartRandomSpawn());
        StartCoroutine(SpeedIncreaseTimer());
        SpeedRef = FindAnyObjectByType<RoombaListedMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        MyTextElement.text = Timer.ToString();
        if (Timer >= GameLength)
        {
            SceneManager.LoadSceneAsync(SceneToLoad);
        }
       
    }

    IEnumerator IncreaseTimer()
    {
        while (Timer < 310)
        {
            Timer += 1;
            print(Timer);
            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator StartRandomSpawn()
    {
        while (Timer < GameLength)
        {
            yield return new WaitForSeconds(ToySpawnInterval);
            SpawnList[Random.Range(0, 12)].SetActive(true);

        }
    }

    IEnumerator SpeedIncreaseTimer()
    {
        while (Timer < GameLength)
        {
            yield return new WaitForSeconds(5);
            SpeedRef.IncreaseSpeed();
        }
    }

  
}
