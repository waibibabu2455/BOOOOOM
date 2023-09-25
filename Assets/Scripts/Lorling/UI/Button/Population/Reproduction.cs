using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproduction : ButtonUIBase
{
    public override void Click()
    {
        if (PlayerAttribute.Instance.score >= PlayerAttribute.Instance.fat * 2)
        {
            PlayerAttribute.Instance.score -= PlayerAttribute.Instance.fat * 2;
            PlayerAttribute.Instance.number++;
        }
    }
}
