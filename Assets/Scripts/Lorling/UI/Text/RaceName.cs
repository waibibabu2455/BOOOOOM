using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceName : TextUIBase
{
    protected override void DateUpdate()
    {
        text.text = PlayerAttribute.Instance.raceName.ToString();
    }
}
