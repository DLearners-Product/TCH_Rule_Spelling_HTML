using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundgame : MonoBehaviour
{
    public Image IMAGE;
    public Sprite[] SPR_IMAGES;
    int I_IMGcount,I_Audiocount;
    public AudioSource AS_Empty;
    public AudioClip[] AC_Clips,AC_Answers;
    public GameObject G_Final;
    // Start is called before the first frame update
    void Start()
    {
        G_Final.SetActive(false);
        I_IMGcount = I_Audiocount = 0;
        THI_ShowImage();
    }
    void THI_ShowImage()
    {
        IMAGE.sprite = SPR_IMAGES[I_IMGcount];
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
            I_Audiocount++;
            AS_Empty.Stop();
            I_IMGcount--;
                THI_ShowImage();
            
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
}
