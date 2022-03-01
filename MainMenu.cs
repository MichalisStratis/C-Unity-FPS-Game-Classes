using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int nextscene=1;

    public void PlayGame()
    {
        SceneManager.LoadScene(nextscene);

    }
    public void QuitGame()
    {
       
        Application.Quit();

    }
}
