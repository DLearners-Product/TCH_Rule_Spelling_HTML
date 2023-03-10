using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class soundgame : MonoBehaviour
{
    public Image IMAGE;
    public Sprite[] SPR_IMAGES;
    int I_IMGcount,I_Audiocount;
    public AudioSource AS_Empty;
    public AudioClip[] AC_Clips,AC_Answers;
    public GameObject G_Final;
    public TextMeshProUGUI TXT_Max, TXT_Current;
    public Button backButton;
    public Button nextButton;
    // Start is called before the first frame update
    void Start()
    {
        G_Final.SetActive(false);
        I_IMGcount = I_Audiocount = 0;
        THI_ShowImage();
        backButton.gameObject.SetActive(false);
        TXT_Max.text = SPR_IMAGES.Length.ToString();
    }
    void THI_ShowImage()
    {
        IMAGE.sprite = SPR_IMAGES[I_IMGcount];
        int Cnt = I_IMGcount + 1;
        TXT_Current.text = Cnt.ToString();
    }
    public void BUT_Answer()
    {
        AS_Empty.clip = AC_Answers[I_IMGcount];
        AS_Empty.Play();
    }
    public void BUT_Next()
    {
        if(I_Audiocount < AC_Clips.Length-1)
        {/*
            
            I_Audiocount++;
            if (I_Audiocount % 2 == 0)
            {*/
            AS_Empty.Stop();
            I_Audiocount++;
            I_IMGcount++;
                THI_ShowImage();
            BUT_Enabler();
            
        }
        else
        {
            G_Final.SetActive(true);
        }
    }
    public void BUT_Back()
    {
        if (I_Audiocount > 0)
        {
            /*AS_Empty.Stop();
            I_Audiocount--;
            if (I_Audiocount % 2 == 0)
            {*/
            I_Audiocount--;
            AS_Empty.Stop();
            I_IMGcount--;
                THI_ShowImage();
            BUT_Enabler();
            
        }
        else
        {
            G_Final.SetActive(true);
        }
    }
    public void BUT_Speaker()
    {
        AS_Empty.clip = AC_Clips[I_Audiocount];
        AS_Empty.Play();
    }

    public void BUT_Enabler()
    {
        if (I_Audiocount == 0)
        {
            backButton.gameObject.SetActive(false);
        }
        else if (I_Audiocount == AC_Clips.Length - 1)
        {
            nextButton.gameObject.SetActive(false);
        }
        else
        {
            backButton.gameObject.SetActive(true);
            nextButton.gameObject.SetActive(true);
        }
    }
}
