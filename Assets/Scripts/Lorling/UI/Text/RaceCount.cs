using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceCount : TextUIBase
{
    protected override void DateUpdate()
    {
        text.text = "�������������" + PlayerAttribute.Instance.number.ToString();
    }
}