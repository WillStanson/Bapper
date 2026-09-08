using System.Collections;
using UnityEngine;
using TMPro;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public int Timer = 0;
    public int SceneToLoad;
    [SerializeField] private AudioSource Clock;
    public AudioClip Clip;

    public List<GameObject> SpawnList;
    public TextMeshProUGUI MyTextElement;

    public static TimerScript Instance;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
    }


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
        if (Timer >= 300)
        {
            SceneManager.LoadSceneAsync(SceneToLoad);
        }

        if (Timer == 60 || Timer == 120 || Timer == 180 || Timer == 240)
        {
            Clock.PlayOneShot(Clip);
            StartCoroutine(ChangeTextColour());
        }

        else
        MyTextElement.color = new Color(1, 1, 1);



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
        while (Timer < 285)
        {
            yield return new WaitForSeconds(10);
            SpawnList[Random.Range(0, 12)].SetActive(true);

        }
    }

    IEnumerator ChangeTextColour()
    {
        MyTextElement.color = new Color(0.2127827f, 0.5345911f, 0.05211414f);
        yield return null;
    }
  
}
