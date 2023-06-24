using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characters : MonoBehaviour
{
    public void setchar(int i)
    {
        PlayerPrefs.SetInt("Characters",i);
    }

   
}
