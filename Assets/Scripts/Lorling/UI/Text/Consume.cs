using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consume : TextUIBase
{
    protected override void DateUpdate()
    {
        text.text = "���غ�Ԥ�����ģ�" + PlayerAttribute.Instance.consume.ToString();
    }
}