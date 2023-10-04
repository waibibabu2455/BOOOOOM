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
        if (PlayerAttribute.Instance.organList.Count > 0)
        {
            foreach (Organ i in PlayerAttribute.Instance.organList)
            { 
                GameObject neworganbutton=Instantiate(neworganButton);
                neworganbutton.GetComponentInChildren<OrganButton>().Organ = i;
               
            }
        }
    }
}
