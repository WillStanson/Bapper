using System.Collections;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    private int Timer = 0;
    public TextMeshProUGUI MyTextElement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        StartCoroutine(IncreaseTimer());
    }

    // Update is called once per frame
    void Update()
    {
        MyTextElement.text = Timer.ToString();
    }

    IEnumerator IncreaseTimer()
    {
        while (Timer < 300)
        {
            Timer += 1;
            print(Timer);
            yield return new WaitForSeconds(1);
        }
    }

  
}
