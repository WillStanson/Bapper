using UnityEngine;
using UnityEngine.Events;

public class EventTrigger : MonoBehaviour
{
    public UnityEvent OnEnter;
    public UnityEvent Destroyed;
    public UnityEvent OnExit;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnEnter.Invoke();
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        OnExit.Invoke();
    }

    private void OnDestroy()
    {
        Destroyed.Invoke();
    }
}
