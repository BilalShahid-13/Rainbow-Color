using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enimies_color_changer : MonoBehaviour
{
    GameObject[] g_c1, g_c2, g_c3, g_c4;
    GameObject[] c_cngr1, c_cngr2, c_cngr3, c_cngr4;
    [SerializeField] Color c1_, c2_, c3_, c4_;
    Color c1, c2, c3, c4;
    string a, b, c, d;
    private void Awake()
    {
         a = PlayerPrefs.GetString("color1");
         b = PlayerPrefs.GetString("color2");
         c = PlayerPrefs.GetString("color3");
         d = PlayerPrefs.GetString("color4");
        if ((a == string.Empty) || (b == string.Empty) || (c == string.Empty) || (d == string.Empty))
        {
            c1 = c1_;
            c2 = c2_;
            c3 = c3_;
            c4 = c4_;
        }
        else
        {
            get_PlayerPrefs_colrs();
        }
        
        getcolor();
        dsp_color();
    }
    void getcolor()
    {
        g_c1 = GameObject.FindGameObjectsWithTag("color 1");
        g_c2 = GameObject.FindGameObjectsWithTag("color 2");
        g_c3 = GameObject.FindGameObjectsWithTag("color 3");
        g_c4 = GameObject.FindGameObjectsWithTag("color 4");

        c_cngr1 = GameObject.FindGameObjectsWithTag("color changer 1");
        c_cngr2 = GameObject.FindGameObjectsWithTag("color changer 2");
        c_cngr3 = GameObject.FindGameObjectsWithTag("color changer 3");
        c_cngr4 = GameObject.FindGameObjectsWithTag("color changer 4");

    }
    private void dsp_color()
    {
        for (int i = 0; i < g_c1.Length; i++)
        {
            g_c1[i].GetComponent<Image>().color = c1;
            g_c2[i].GetComponent<Image>().color = c2;
            g_c3[i].GetComponent<Image>().color = c3;
            g_c4[i].GetComponent<Image>().color = c4;
        }
        for (int i = 0; i < c_cngr1.Length; i++)
        {
            c_cngr1[i].GetComponent<Image>().color = c1;
            c_cngr2[i].GetComponent<Image>().color = c2;
            c_cngr3[i].GetComponent<Image>().color = c3;
            c_cngr4[i].GetComponent<Image>().color = c4;
        }
    }

    private void get_PlayerPrefs_colrs()
    {
        c1 = HexToColor(PlayerPrefs.GetString("color1"));
        c2 = HexToColor(PlayerPrefs.GetString("color2"));
        c3 = HexToColor(PlayerPrefs.GetString("color3"));
        c4 = HexToColor(PlayerPrefs.GetString("color4"));
    }
    Color HexToColor(string hex)
    {
        byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
        byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
        byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
        return new Color32(r, g, b, 255);
    }

}
