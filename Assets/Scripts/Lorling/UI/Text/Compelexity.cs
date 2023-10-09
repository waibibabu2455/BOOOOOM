using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compelexity : TextUIBase
{
    protected override void DateUpdate()
    {
        text.text = "生物复杂度：" + PlayerAttribute.Instance.complexity.ToString();
    }
}
