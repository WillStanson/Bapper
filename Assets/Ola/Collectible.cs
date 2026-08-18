using UnityEngine;

public class Collectible : MonoBehaviour
{
    public string Tag;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

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
}
