using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class color_chooser : MonoBehaviour
{
    public Color[] color;
   
    public void sel(int btn)
    {
        if (btn == 1)
        {
            PlayerPrefs.SetString("color1", ColorToHex(color[0]));
            PlayerPrefs.SetString("color2", ColorToHex(color[1]));
            PlayerPrefs.SetString("color3", ColorToHex(color[2]));
            PlayerPrefs.SetString("color4", ColorToHex(color[3]));
        }
        else if(btn == 2)
        {
            PlayerPrefs.SetString("color1", ColorToHex(color[4]));
            PlayerPrefs.SetString("color2", ColorToHex(color[5]));
            PlayerPrefs.SetString("color3", ColorToHex(color[6]));
            PlayerPrefs.SetString("color4", ColorToHex(color[7]));
        }
        else if(btn == 3)
        {
            PlayerPrefs.SetString("color1", ColorToHex(color[8]));
            PlayerPrefs.SetString("color2", ColorToHex(color[9]));
            PlayerPrefs.SetString("color3", ColorToHex(color[10]));
            PlayerPrefs.SetString("color4", ColorToHex(color[11]));
        }
        else if (btn == 4)
        {
            PlayerPrefs.SetString("color1", ColorToHex(color[12]));
            PlayerPrefs.SetString("color2", ColorToHex(color[13]));
            PlayerPrefs.SetString("color3", ColorToHex(color[14]));
            PlayerPrefs.SetString("color4", ColorToHex(color[15]));
        }
        else if (btn == 5)
        {
            PlayerPrefs.SetString("color1", ColorToHex(color[16]));
            PlayerPrefs.SetString("color2", ColorToHex(color[17]));
            PlayerPrefs.SetString("color3", ColorToHex(color[18]));
            PlayerPrefs.SetString("color4", ColorToHex(color[19]));
        }

    }
    string ColorToHex(Color32 color)
    {
        string hex = color.r.ToString("X2") + color.g.ToString("X2") + color.b.ToString("X2");
        return hex;
    }
    Color HexToColor(string hex)
    {
        byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
        byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
        byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
        return new Color32(r, g, b, 255);
    }
}
