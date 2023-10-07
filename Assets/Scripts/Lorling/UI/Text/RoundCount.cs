using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundCount : TextUIBase
{
    protected override void DateUpdate()
    {
        string s = "回合：";
        s += PlayerAttribute.Instance.roundCount.ToString();
        text.text = s;
    }
}
