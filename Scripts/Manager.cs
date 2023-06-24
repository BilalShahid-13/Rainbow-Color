using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

/*
  Quit_Dialog_Box_obj: 53-64
    * when button pressed animation play and wait for 1sec then false
  Sound_popup_obj: 61
    * when button pressed animation play and wait for 1sec then false
  sound_poping_chk: 31-46
    * when clicking in setting button open and close animation popup sound button whill show
  quit_dialog_bool; 50-64
    * in invoke we include two obj quit,sound so i choose bool for quit of quit true so quit will false
    and sound will not false
  Sound_popup & setting:
    * in inspector soundpopup & setting will false
 */
public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] GameObject Quit_Dialog_Box_obj,Sound_popup_obj;
    bool sound_poping_chk = true,quit_dialog_bool;
    public Animator Sound_popup,setting;

    private void Awake()
    {
        Sound_popup.enabled = false;
        setting.enabled = false;    
    }
    public void sound_popup()
    {
        setting.enabled = true;
        Sound_popup.enabled = true;
        
        if(sound_poping_chk == true)
        {
            Sound_popup.Play("sound pop up opening");
            sound_poping_chk = false;
        }
        else
        {
            Sound_popup.Play("sound pop up closing");
            sound_poping_chk = true;
            quit_dialog_bool = false;
            Invoke("wait",1f);
        }
    }
    public void Quit_Dialog_Box_close(Animator Quit_Dialog_Box_close)
    {
        Quit_Dialog_Box_close.Play("quit dialog box closing");
        quit_dialog_bool = true;
        Invoke("wait",1f);
    }
    void wait()
    {
        if(quit_dialog_bool == true)
        {
            Quit_Dialog_Box_obj.SetActive(false);
        }
        else
        {
            Sound_popup_obj.SetActive(false);
        }
        
    }
   

}
