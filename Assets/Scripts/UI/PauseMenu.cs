using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool isPauseMenuOn = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&&isPauseMenuOn==false)
        {
            Pause();
        }
    }

    public void Pause()
    {
        isPauseMenuOn = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Continue()
    {
        isPauseMenuOn=false;
        Time.timeScale = 1.0f;
        pauseMenu.SetActive(false);
    }

    public void MainMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MainMenu");
    }
}
