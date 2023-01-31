using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class syntax : MonoBehaviour
{
    public static syntax OBJ_Syntax;
    public GameObject[] GA_Questions;
    public int I_Qcount,I_count;
    public GameObject G_Final,G_Next;
    public AudioSource AS_Correct, AS_Wrong;
    void Start()
    {
        OBJ_Syntax = this;
        G_Final.SetActive(false);
        I_Qcount = 0;
        THI_ShowQuestion();
        
    }
    public void THI_Correct()
    {
        AS_Correct.Play();
        I_count--;
        if(I_count==0)
        {
            G_Next.GetComponent<Button>().interactable = true;
            GA_Questions[I_Qcount].transform.GetChild(2).gameObject.SetActive(true);
            GA_Questions[I_Qcount].transform.GetChild(0).gameObject.SetActive(false);
            GA_Questions[I_Qcount].transform.GetChild(1).gameObject.SetActive(false);
        }
      
    }
    public void THI_Wrong()
    {
        AS_Wrong.Play();
    }
    public void BUT_Next()
    {
        if (I_Qcount < GA_Questions.Length - 1)
        {
            I_Qcount++;
            THI_ShowQuestion();
        }
        else
        {
            G_Final.SetActive(true);
        }
    }
    void THI_ShowQuestion()
    {
        for (int i = 0; i < GA_Questions.Length; i++)
        {
            GA_Questions[i].SetActive(false);
        }
        GA_Questions[I_Qcount].SetActive(true);
        GA_Questions[I_Qcount].transform.GetChild(2).gameObject.SetActive(false);
        G_Next.GetComponent<Button>().interactable = false;
        I_count = 3;
    }
}
