using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;

    void Start()
    {

        mainMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (mainMenu.activeSelf)
            {
                HideMenu();
            }
            else
            {
                ShowMenu();
            }
        }
    }

    public void ShowMenu()
    {

        mainMenu.SetActive(true);
        Time.timeScale = 0f; 
    }

    public void HideMenu()
    {
        mainMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void StartGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1f;
    }

    public void LoadLevel1()
    {
        StartGame("Level1");
    }

    public void LoadLevel2()
    {
        StartGame("Level2");
    }

    public void LoadLevel3()
    {
        StartGame("Level3");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
