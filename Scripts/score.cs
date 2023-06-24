using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI lvl_txt, score_txt;

    private void Start()
    {
        lvl_txt.text = "Level 0" + PlayerPrefs.GetInt("Current Level");
        score_txt.text = PlayerPrefs.GetInt("Score txt").ToString();
        score_txt.text = "0" + score_txt.text;
    }
}
