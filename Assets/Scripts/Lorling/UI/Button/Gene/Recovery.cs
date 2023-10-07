using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recovery: ButtonUIBase
{
    public GameObject neworganButton;
    public override void Click()
    {
        sure.GetComponent<Sure>().SetAction(Func);
    }

    void Func()
    {
        if (GameObject.FindObjectsOfType<OrganButtonSRC>()!= null)
        {
            foreach(OrganButtonSRC o in GameObject.FindObjectsOfType<OrganButtonSRC>()) { 
                o.gameObject.SetActive(false);
            }
        }
        int y = 1;
        if (PlayerAttribute.Instance.organList.Count > 0)
        {
            foreach (Organ i in PlayerAttribute.Instance.organList)
            { 
                GameObject neworganbutton=Instantiate(neworganButton);
                neworganbutton.GetComponentInChildren<OrganButtonSRC>().transform.SetPositionAndRotation(new Vector3(550,200+y*30,0),Quaternion.Euler(0,0,0));
                neworganbutton.GetComponentInChildren<OrganButtonSRC>().Organ = i;
                neworganbutton.GetComponentInChildren<Text>().text = i.OrganName;
                y += 1;
            }
        }
    }
}
