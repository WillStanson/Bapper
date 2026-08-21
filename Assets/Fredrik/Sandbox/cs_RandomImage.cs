using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class cs_RandomImage : MonoBehaviour
{

    public List<Sprite> listNameddsd = new List<Sprite>();
    private Image m_Image;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_Image = GetComponent<Image>();
        m_Image.sprite = listNameddsd[Random.Range(0,3)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
