using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consume : TextUIBase
{
    protected override void DateUpdate()
    {
        text.text = "本回合预计消耗：" + PlayerAttribute.Instance.consume.ToString();
    }
}