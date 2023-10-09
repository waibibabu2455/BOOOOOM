using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Replace : ButtonUIBase
{
    public GameObject neworganButton;
    public override void Click()
    {
        sure.GetComponent<Sure>().SetAction(Func);
    }
    void Func()
    {
        int y = 0;
        foreach (Organ i in machine.Player.organList) {
            GameObject showbutton = Instantiate(neworganButton);
            showbutton.SetActive(true);
            showbutton.GetComponentInChildren<OrganButtonSRC>().transform.SetPositionAndRotation(new Vector3(960, 200 + y * 80, 0), Quaternion.Euler(0, 0, 0));
            showbutton.GetComponentInChildren<Text>().text = i.OrganName;
            showbutton.GetComponentInChildren<OrganButtonSRC>().enabled = false;
            showbutton.GetComponentInChildren<Button>().enabled = false;
            y += 1;
        } 
    }
}
