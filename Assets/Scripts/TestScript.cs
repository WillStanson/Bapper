using UnityEngine;

public class TestScript : MonoBehaviour
{
    
    private float health = 100;


    private void Start()
    {
        while (health>0)
        {
            print("health i more than 0");
            health--;
        }
    }
    void Update()
    {
        
    }
}
