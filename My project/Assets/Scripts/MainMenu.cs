using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Scoretext Scorescript;
    public RandomSpawner spawner;
    public Image Icon;
    public Sprite ResumeImage;
    public Sprite PauseImage;

    public void PlayGame()
    {

        SceneManager.LoadScene(1);

    }
    public void QuitGame()
    {

        Application.Quit();

    }
    public void WinGame() 
    {
        if(Scorescript.score>=5)
        SceneManager.LoadScene(2);
    }

    public void PauseGame() 
    {

        if (Time.timeScale == 0)
        {
            
            Icon.sprite = PauseImage;
            Time.timeScale = 1;
        }
        else 
        {
            Icon.sprite = ResumeImage;
            Time.timeScale = 0;
        }
            
    }
}
