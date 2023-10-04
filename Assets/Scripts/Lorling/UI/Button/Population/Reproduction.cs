using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproduction : ButtonUIBase
{
    public override void Click()
    {
        sure.GetComponent<Sure>().SetAction(Func);
    }

    void Func()
    {
        if (PlayerAttribute.Instance.score >= PlayerAttribute.Instance.number)
        {
            PlayerAttribute.Instance.score -= PlayerAttribute.Instance.number+PlayerAttribute.Instance.reproductionvalue;
            PlayerAttribute.Instance.number++;
        }
    }
}
