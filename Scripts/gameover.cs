using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{
    int bol;
    [SerializeField] GameObject pass, fail;
    void Start()
    {
        bol = PlayerPrefs.GetInt("bool ending");

        if(bol == 0)
        {
            fail.SetActive(true);
            pass.SetActive(false);
        }
        else
        {
            fail.SetActive(false);
            pass.SetActive(true);
        }
    }

   
}
