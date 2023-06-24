using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Color = UnityEngine.Color;

public class movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] int force;
    [SerializeField] GameObject player_obj, particle_obj,square_end;
    [SerializeField] Color c1_, c2_, c3_, c4_;
    [SerializeField] Animator particle;
    [SerializeField] GameObject[] changer;
    [SerializeField] Sprite[] character;
    [SerializeField] Image player;
    [SerializeField] Image player_img,img_default;
    [SerializeField] TextMeshProUGUI lvl_txt,lvl_complete_txt,score_txt;
    [SerializeField] AudioSource idle,hit,win;

    Color c1, c2, c3, c4;
    string a, b_, c, d;
    bool b = true;
    string current_color,c_lvl;
    int i=0, count_, count_lvl = 1,ch;
    

    private void Awake()
    {
         a = PlayerPrefs.GetString("color1");
         b_ = PlayerPrefs.GetString("color2");
         c = PlayerPrefs.GetString("color3");
         d = PlayerPrefs.GetString("color4");
        ch = PlayerPrefs.GetInt("Characters");
        if ((a == string.Empty) && (b_ == string.Empty) && (c == string.Empty) && (d == string.Empty))
        {
            c1 = c1_;
            c2 = c2_;
            c3 = c3_;
            c4 = c4_;
            player_img.GetComponent<Image>().sprite = img_default.sprite;
        }
       
        else
        {
            c1 = HexToColor(PlayerPrefs.GetString("color1"));
            c2 = HexToColor(PlayerPrefs.GetString("color2"));
            c3 = HexToColor(PlayerPrefs.GetString("color3"));
            c4 = HexToColor(PlayerPrefs.GetString("color4"));
            getchar(ch);
        }
        lvl_txt.text = "Level 0" + PlayerPrefs.GetInt("Current Level");
        score_txt.text = PlayerPrefs.GetInt("Score txt").ToString();


    }

    private void Start()
    {
        square_end.SetActive(false);    

        if (PlayerPrefs.GetInt("Sound") == 2)
        {
            idle.enabled = true;
            hit.enabled = true;
            win.enabled = true;
            idle.Play();
        }
        else
        {
            /*idle.Pause();
            hit.Pause();
            win.Pause();*/
            idle.enabled = false;
            hit.enabled = false;
            win.enabled = false;
        }
        SetRandomColor();
    }

    private void FixedUpdate()
    {

        particle_obj.transform.position = player_obj.transform.position;
        player_movement();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag == current_color)
        {
            
        }
        else if (collision.tag == "changer")
        {
            Debug.Log("changer");
            SetRandomColor();
            i++;
            getdisp(i);
            count();
        }
        else if (collision.tag == "ending")
        {
            count_lvl = PlayerPrefs.GetInt("Current Level",1);
            Debug.Log(count_lvl);
            count_lvl = count_lvl + 1;//2
            Debug.Log("end");
            PlayerPrefs.SetInt("bool ending", 1);
            PlayerPrefs.SetInt("Current Level", count_lvl);
            Debug.Log(count_lvl);
            PlayerPrefs.SetInt("levels", count_lvl);
            StartCoroutine(Particles(true));
            
        }
        else
        {
            //hit.Play();
            PlayerPrefs.SetInt("bool ending", 0); // fail
            StartCoroutine(Particles(false));
        }  

    }

   void SetRandomColor()
    {
        int index = UnityEngine.Random.Range(0, 4);

        switch (index)
        {
            case 0:
                player.GetComponent<Image>().color = c1;
                lvl_txt.color = c1;
                lvl_complete_txt.color = c1;
                current_color = "color 1";
                break;
            case 1:
                player.GetComponent<Image>().color = c2;
                lvl_txt.color = c2;
                lvl_complete_txt.color = c2;
                current_color = "color 2";
                break;
            case 2:
                player.GetComponent<Image>().color = c3;
                lvl_txt.color = c3;
                lvl_complete_txt.color = c3;
                current_color = "color 3";
                break;
            case 3:
                player.GetComponent<Image>().color = c4;
                lvl_txt.color = c4;
                lvl_complete_txt.color = c4;
                current_color = "color 4";
                break;
        }
    }

    void player_movement()
    {
        if (b == true)
        {

            if (Input.touchCount == 1 || Input.GetMouseButton(0))
            {
                rb.velocity = Vector2.up * force;
                b = false;
            }
        }
        else
        {
            if (Input.touchCount == 0)
            {
                b = true;
            }
        }
    }

    void getchanger()
    {
        changer = GameObject.FindGameObjectsWithTag("changer");
    }
    void getdisp(int i)
    {
        i = i - 1;
        Debug.Log(i);
        changer[i].SetActive(false);
    }

    void count()
    {
        count_ = PlayerPrefs.GetInt("Score txt");
        count_++;
        PlayerPrefs.SetInt("Score txt", count_);
        score_txt.text = PlayerPrefs.GetInt("Score txt").ToString();
    }
    void gameover()
    {
        SceneManager.LoadScene("gameover");
    }
    IEnumerator Particles(bool b)
    {
         if(b == true)
         {
             square_end.SetActive(true);
             win.Play();
             yield return new WaitForSeconds(1.5f);
             particle_obj.SetActive(true);
             particle.enabled = true;
             particle.Play("Particles");
             Invoke("gameover", 0.4f);
             b = true;
         }
         else
         {
            square_end.SetActive(false);
            hit.Play();
             yield return new WaitForSeconds(.3f);
             particle_obj.SetActive(true);
             particle.enabled = true;
             particle.Play("Particles");
             player_obj.SetActive(false);
             Invoke("gameover", 0.4f);
            b = true;
         }
    }
    public void getchar(int ch)
    {
        switch (ch)
        {
            case 0:
                player_img.sprite = character[0];
                break;

            case 1:
                player_img.sprite = character[1];
                break;

            case 2:
                player_img.sprite = character[2];
                break;

            case 3:
                player_img.sprite = character[3];
                break;

            case 4:
                player_img.sprite = character[4];
                break;

            case 5:
                player_img.sprite = character[5];
                break;

            case 6:
                player_img.sprite = character[6];
                break;


        }
    }
    Color HexToColor(string hex)
    {
        byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
        byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
        byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
        return new Color32(r, g, b, 255);
    }
}
