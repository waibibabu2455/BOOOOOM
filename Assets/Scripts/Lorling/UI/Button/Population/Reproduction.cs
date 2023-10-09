using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproduction : ButtonUIBase
{
    public override void Click()
    {
        sure.GetComponent<Sure>().SetAction(Func);
        string s = "繁衍花费" + PlayerAttribute.Instance.reproductionvalue.ToString();
        s += "\n种族数量增加1";
        info.text = s;
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
