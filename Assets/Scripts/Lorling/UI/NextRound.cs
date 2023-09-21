using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextRound : ButtonUIBase
{
    public override void Click()
    {
        PlayerAttribute.Instance.score += PlayerAttribute.Instance.getScore;
    }
}
