using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level_interactable : MonoBehaviour
{
    [SerializeField] Button[] buttons = null;
    int lvlreached;
    private void Start()
    {
        lvlreached = PlayerPrefs.GetInt("levels",1);

        for(int i=0; i<buttons.Length; i++)
        {
            if(i+1 > lvlreached)
            {
                buttons[i].interactable = false;
            }
            
        }
    }

    public void back()
    {
        SceneManager.LoadScene("Starting");
    }
    public void lvl(string lvl)
    {
        SceneManager.LoadScene("Starting");
    }
}
