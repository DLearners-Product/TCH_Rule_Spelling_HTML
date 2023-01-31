using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Newdrag : MonoBehaviour, IDragHandler, IEndDragHandler
{
    Vector2 mousePos;
    public Vector2 initalPos;

    bool isdrag;
    GameObject otherGameObject;

    Camera mainCam;

    private void Awake()
    {
        mainCam = Camera.main;
    }

    private void Start()
    {
        //initalPos = this.GetComponent<RectTransform>().position;
        initalPos = this.transform.position;
    }


    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = mousePos;
        //Debug.Log("Drag");
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        // Debug.Log("End Drag");
        if (otherGameObject != null)
        {
            if (this.gameObject.name == otherGameObject.name)
            {
                this.transform.position = otherGameObject.transform.position;
                syntax.OBJ_Syntax.THI_Correct();
                this.GetComponent<Newdrag>().enabled = false;
            }
            else
            {
                syntax.OBJ_Syntax.THI_Wrong();
                //dragmain.OBJ_dragmain.THI_wrg();
                this.transform.position = initalPos;
            }
        }
        else
        {
            this.transform.position = initalPos;
        }

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.transform.parent.name == "Drop")
            otherGameObject = other.gameObject;
       //  Debug.Log("Name :" + otherGameObject.name);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.parent.name == "Drop")
            otherGameObject = null;


    }
    
}
