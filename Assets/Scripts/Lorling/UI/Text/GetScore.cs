using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScore : TextUIBase
{
    protected override void DateUpdate()
    {
        text.text = "本回合预计收入：" + PlayerAttribute.Instance.getScore.ToString();
    }
}