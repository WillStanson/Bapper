using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject PrefabToSpawn;
    public Quaternion SpawnRotation;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(PrefabToSpawn, transform.position, SpawnRotation);
        gameObject.SetActive(false);
    }

   
}
