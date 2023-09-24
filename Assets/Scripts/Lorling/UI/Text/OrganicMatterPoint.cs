using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganicMatterPoint : TextUIBase
{
    protected override void DateUpdate()
    {
        text.text = "有机质点数：" + PlayerAttribute.Instance.score.ToString();
    }
}
