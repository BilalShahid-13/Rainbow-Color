using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class level_selector : MonoBehaviour
{
    string t;

   
    public void lvl_prefs(int lvl)
    {
        PlayerPrefs.SetInt("Current Level", lvl);
        SceneManager.LoadScene("Level 0" + lvl); 
    }

    public void back(string back)
    {
        SceneManager.LoadScene(back);
    }

    public void retry()
    {
        t = "Level 0" + PlayerPrefs.GetInt("Current Level");
        SceneManager.LoadScene(t);
    }

    public void next()
    {
        t = "Level 0" + PlayerPrefs.GetInt("Current Level");
        SceneManager.LoadScene(t);
    }


    public void Quit()
    {
        Application.Quit();
    }

}
