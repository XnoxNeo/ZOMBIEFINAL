using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIMenus : MonoBehaviour
{
    public void Play()
    {
        
        SceneManager.LoadScene("MainMenuStage");
    }
    public void level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
