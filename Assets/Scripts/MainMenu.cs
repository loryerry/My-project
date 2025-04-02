using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private ScreenFader screenFader;

    void Start()
    {
        screenFader = FindObjectOfType<ScreenFader>();
    }

    public void StartGame()
    {
        MenuMusic music = FindObjectOfType<MenuMusic>();
        if (music != null)
        {
            music.FadeOutMusic(2.0f);
        }

        if (screenFader != null)
        {
            screenFader.FadeToScene("SampleScene");
        }
        else
        {
            SceneManager.LoadScene("GameScene");
        }
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Игра закрылась!");
    }
}
