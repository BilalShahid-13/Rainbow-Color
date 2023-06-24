using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loading : MonoBehaviour
{
    [SerializeField] GameObject loadingscreen,lesh;
    [SerializeField] Slider slider;
    [SerializeField] Gradient gradient;
    [SerializeField] Image fill;
    private void Awake()
    {
        lesh.SetActive(true);
        Invoke("Loading", 6f);
    }
    void Loading()
    {
        lesh.SetActive(false);
        loadingscreen.SetActive(true);
        Invoke("starting",8f);
    }

    void starting()
    {
        SceneManager.LoadScene("Starting");
    }


}
