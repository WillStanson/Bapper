using System.Collections;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public string Tag;
    

    Sanity SanityLink;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SanityLink = FindAnyObjectByType<Sanity>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag(Tag))
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        
        SanityLink.IncreaseSanity();
    }

    IEnumerator SanityMessage()
    {
        GameObject.Find("Message").SetActive(true);
        yield return new WaitForSeconds(3);
        GameObject.Find("Message").SetActive(false);
    }
}
