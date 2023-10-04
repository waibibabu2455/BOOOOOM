using System.Collections;
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
        Organ neworgan = machine.OrganPool[Random.Range(0,machine.OrganPool.Count-1)];
        if (PlayerAttribute.Instance.organList.Contains(neworgan) == false)
        {
            PlayerAttribute.Instance.organList.Add(neworgan);
            neworgan.enable = true;
            neworgan.OrganEffect();
            Debug.Log(neworgan.OrganName);
        }
        else
        {
            Func();
        }
    }
}
