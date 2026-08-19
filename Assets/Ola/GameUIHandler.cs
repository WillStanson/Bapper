using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class GameUIHandler : MonoBehaviour
{
    public float Sanity, MaxSanity, Width, Height;
    [SerializeField] private RectTransform SanityBar;

    public void SetMaxSanity(float maxSanity)
    {
        MaxSanity = maxSanity;
    }

    public void SetSanity(float sanity)
    {
        Sanity = sanity;
        float newWidth = (Sanity / MaxSanity) * Width;

        SanityBar.sizeDelta = new Vector2(newWidth, Height);
    }

}
