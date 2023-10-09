using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganButtonSRC : ButtonUIBase
{
    public Organ Organ;
    public OrganButtonSRC(Organ organ) { 
        this.Organ = organ;
    }
    public override void Click() {
        func();
    }
    public void func()
    {
        Organ.OrganreverseEffect();
        PlayerAttribute.Instance.organList.Remove(Organ);
        PlayerAttribute.Instance.complexity -= Organ.Complexity;
        PlayerAttribute.Instance.score += Organ.Refund;
        Debug.Log("organ" + Organ.OrganName + "has been removed");
        Destroy(canvas);
    }
}
