using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScore : TextUIBase
{
    protected override void DateUpdate()
    {
        text.text = "���غ�Ԥ�����룺" + PlayerAttribute.Instance.getScore.ToString();
    }
}