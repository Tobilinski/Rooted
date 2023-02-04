using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    
    public void Play()
    {
        SceneManager.LoadScene("MAZE"); 
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Restart()
    {
        SceneManager.LoadScene("MAZE"); 
    }
    public void Main()
    {
        SceneManager.LoadScene("Main");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

}
