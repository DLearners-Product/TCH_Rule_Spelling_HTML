using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class visualactivity : MonoBehaviour
{
    public GameObject[] GA_Questions;
    public int I_Qcount;
    public GameObject G_Final,G_Selected;
    public AudioSource AS_Correct, AS_Wrong;
    bool B_CanClick;
    // Start is called before the first frame update
    void Start()
    {
        G_Final.SetActive(false);
        I_Qcount = 0;
        THI_ShowQuestion();
    }
    public void BUT_Next()
    {
        if(I_Qcount<GA_Questions.Length-1)
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
        for(int i=0;i<GA_Questions.Length;i++)
        {
            GA_Questions[i].SetActive(false);
        }
        GA_Questions[I_Qcount].SetActive(true);
        B_CanClick = true;
    }
    public void BUT_Clicking()
    {
        if(B_CanClick)
        {
            G_Selected = EventSystem.current.currentSelectedGameObject;
           
            if (G_Selected.tag == "answer")
            {
                B_CanClick = false;
                G_Selected.transform.GetChild(0).GetComponent<Image>().color = Color.green;
                AS_Correct.Play();
            }
            else
            {
                B_CanClick = false;
                G_Selected.transform.GetChild(0).GetComponent<Image>().color = Color.red;
                AS_Wrong.Play();
                Invoke("THI_Off", 1f);
            }
        }
       
    }    

    void THI_Off()
    {
        B_CanClick = true;
        G_Selected.transform.GetChild(0).GetComponent<Image>().color = Color.gray;
    }
}
