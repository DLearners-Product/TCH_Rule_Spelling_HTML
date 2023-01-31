using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class dragmain : MonoBehaviour
{
    public static dragmain OBJ_dragmain;
    public int I_Qcount;
    public GameObject  G_final;
    public AudioSource AS_crt, AS_wrg;

   
    public void Start()
    {
        OBJ_dragmain = this;
        I_Qcount = -1;
        G_final.SetActive(false);
        GameObject drop = this.transform.GetChild(1).gameObject;
        for(int i=0;i<drop.transform.childCount;i++)
        {
            drop.transform.GetChild(i).transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
        }
    }
   
    public void THI_Correct()
    {
        AS_crt.Play();
    }
    
    public void THI_wrg()
    {
        AS_wrg.Play();
    }
    
   
   

    
}
