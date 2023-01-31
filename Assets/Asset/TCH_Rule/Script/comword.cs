using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comword : MonoBehaviour
{
    public GameObject[] GA_Questions;
    int I_Qcount,I_count;
    public GameObject G_Final;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        I_Qcount = 0;
        THI_ShowQuestion();
    }

    void THI_ShowQuestion()
    {
        for (int i = 0; i < GA_Questions.Length; i++)
        {
            GA_Questions[i].SetActive(false);
        }
        GA_Questions[I_Qcount].SetActive(true);
        GA_Questions[I_Qcount].transform.GetChild(1).gameObject.SetActive(false);
        anim = GA_Questions[I_Qcount].transform.GetChild(0).transform.GetChild(0).GetComponent<Animator>();
    }
    public void BUT_Clicking()
    {
        anim.enabled = true;
        Invoke("THI_OnPic", 3f);
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

    void THI_OnPic()
    {
        GA_Questions[I_Qcount].transform.GetChild(1).gameObject.SetActive(true);
    }
}
