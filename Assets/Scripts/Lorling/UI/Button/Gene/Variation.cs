﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variation : ButtonUIBase
{
    public override void Click()
    {
        sure.GetComponent<Sure>().SetAction(Func);
    }

    void Func()
    {
        if (GameObject.FindObjectsOfType<OrganButtonSRC>() != null)
        {
            foreach (OrganButtonSRC o in GameObject.FindObjectsOfType<OrganButtonSRC>())
            {
                o.gameObject.SetActive(false);
            }
        }
        Organ neworgan = machine.OrganPool[Random.Range(0,machine.OrganPool.Count-1)];
        PlayerAttribute.Instance.organList.Add(neworgan);
        neworgan.enable = true;

        PlayerAttribute.Instance.complexity += neworgan.Complexity;
        PlayerAttribute.Instance.score -= 5;
            
        neworgan.OrganEffect();
            
        machine.infotext.text = "获得"+neworgan.OrganName+": \n"+neworgan.Description;
        machine.infotext.gameObject.SetActive(true);
        Debug.Log(neworgan.OrganName);

    }
}
