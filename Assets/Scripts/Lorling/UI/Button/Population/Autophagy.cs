using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autophagy : ButtonUIBase
{
    public override void Click()
    {
        if(PlayerAttribute.Instance.number > 1)
        {
            PlayerAttribute.Instance.number--;
            PlayerAttribute.Instance.score += PlayerAttribute.Instance.fat;
        }
    }
}