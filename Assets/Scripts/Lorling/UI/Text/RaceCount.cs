using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceCount : TextUIBase
{
    protected override void DateUpdate()
    {
        text.text = "种族个体数量：" + PlayerAttribute.Instance.number.ToString();
    }
}