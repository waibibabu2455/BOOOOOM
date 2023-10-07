using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autophagy : ButtonUIBase
{
    public override void Click()
    {
        sure.GetComponent<Sure>().SetAction(Func);
        string s = "种群数量减1\n";
        s += "有机质点数增加";
        s += PlayerAttribute.Instance.fat.ToString();
        info.text = s;
    }

    public void Func()
    {
        if (PlayerAttribute.Instance.number > 1)
        {
            if (PlayerAttribute.Instance.fat >= PlayerAttribute.Instance.number)
            {
                PlayerAttribute.Instance.number -= 1;
                PlayerAttribute.Instance.score += PlayerAttribute.Instance.number;
            }
            else {
                PlayerAttribute.Instance.number -= 1;
                PlayerAttribute.Instance.score += PlayerAttribute.Instance.fat;
            }
        }
    }
}
