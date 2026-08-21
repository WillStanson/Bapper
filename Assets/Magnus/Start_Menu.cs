using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Bapper_Level");
    }

    public void MenuGame()
    {
        SceneManager.LoadSceneAsync("Start");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
