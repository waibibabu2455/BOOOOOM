using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganicMatterPoint : TextUIBase
{
    protected override void DateUpdate()
    {
        text.text = "�л��ʵ�����" + PlayerAttribute.Instance.score.ToString();
    }
}
