using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class pause_menu : MonoBehaviour
{
    [SerializeField] GameObject Popup;
    public void pause()
    {
        Popup.SetActive(true);
        Time.timeScale = 0.2f;
    }

    public void unpause()
    {
        Time.timeScale = 1f;
        Popup.SetActive(false);  
    }

    public void replay()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(PlayerPrefs.GetString("Current Level"));
    }

    public void starting()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Starting");
    }
}
