using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class witchgame : MonoBehaviour
{
    public GameObject G_Witch;
    public GameObject[] GA_Movementareas, GA_Questions;
    public int I_Qcount;
    GameObject G_Selected;
    public AudioSource AS_Correct, AS_Wrong;
    bool B_CanLerp, B_CanClick;
    public GameObject G_Final,G_Next;
    public AudioSource AS_Empty;
    public AudioClip[] AC_Clips;
    // Start is called before the first frame update
    void Start()
    {
        I_Qcount = 0;
        THI_ShowQuestion();
        G_Final.SetActive(false);
    }
    /*private void Update()
    {
        if(B_CanLerp)
        {
            G_Witch.transform.position = Vector3.Lerp(G_Witch.transform.position, GA_Movementareas[I_Qcount].transform.position, 1f);
           
        }
    }*/

    void THI_ShowQuestion()
    {
        for(int i=0;i<GA_Questions.Length;i++)
        {
            GA_Questions[i].SetActive(false);
        }
        GA_Questions[I_Qcount].SetActive(true);
        GA_Questions[I_Qcount].transform.GetChild(1).gameObject.SetActive(false);
       
        G_Next.GetComponent<Button>().interactable = false;
        if (I_Qcount == 2 || I_Qcount == 6) { G_Witch.transform.localScale = new Vector2(-1, 1); }
        else
          if (I_Qcount == 4) { G_Witch.transform.localScale = new Vector2(1, 1); }
    }
    public void BUT_Speaker()
    {
        AS_Empty.clip = AC_Clips[I_Qcount];
        AS_Empty.Play();
        B_CanClick = true;
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
    public void BUT_Clicking()
    {
        if(B_CanClick)
        {
            G_Selected = EventSystem.current.currentSelectedGameObject;
            if (G_Selected.tag == "answer")
            {
                // B_CanLerp = true;
                G_Witch.GetComponent<Animator>().SetInteger("Cond", I_Qcount + 1);
                G_Selected.transform.GetChild(0).GetComponent<Image>().color = Color.green;
                GA_Questions[I_Qcount].transform.GetChild(0).gameObject.SetActive(false);
                GA_Questions[I_Qcount].transform.GetChild(1).gameObject.SetActive(true);
                AS_Correct.Play();
                B_CanClick = false;
               Invoke("OFF_Lerp", 2f);
            }
            else
            {
                G_Selected.transform.GetChild(0).GetComponent<Image>().color = Color.red;
                Invoke("Offred", 1f);
                AS_Wrong.Play();
            }
        }

    }

    void OFF_Lerp()
    {        
        G_Next.GetComponent<Button>().interactable = true;
    }
    void Offred()
    {
        G_Selected.transform.GetChild(0).GetComponent<Image>().color = Color.grey;
    }

}
