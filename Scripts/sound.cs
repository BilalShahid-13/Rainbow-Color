using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    [SerializeField] AudioSource idle, hit,win;

    private void Awake()
    {
        if (PlayerPrefs.GetInt("Sound") == 0)
        {
            PlayerPrefs.SetInt("Sound", 2);
        }
    }
    private void Start()
    {
        if (PlayerPrefs.GetInt("Sound") == 2)
        {
            idle.Play();
        }
        else
        {
            idle.Pause();
        }
    }
    private void Update()
    {
        
    }

    public void sound_on()
    {
        PlayerPrefs.SetInt("Sound", 2);
        idle.Play();
        Debug.Log("on");
    }
    public void sound_off()
    {
        PlayerPrefs.SetInt("Sound", 1);
        idle.Pause();
        Debug.Log("off");
    }
}
