using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject characters, colors;
    [SerializeField] TextMeshProUGUI score_txt;

    private void Awake()
    {
        characters.SetActive(false);
        colors.SetActive(false);
    }

    private void Start()
    {
            score_txt.text = PlayerPrefs.GetInt("Score txt").ToString();
            score_txt.text = "0" + score_txt.text;
    }
    public void colors_()
    {
        colors.SetActive(true);
        characters.SetActive(false);
    }
    public void character()
    {
        characters.SetActive(true);
        colors.SetActive(false);    
    }

}
