using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("GrassTerrain");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
