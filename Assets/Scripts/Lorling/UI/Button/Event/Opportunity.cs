using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opportunity : ButtonUIBase
{
    public override void Click()
    {
        sure.GetComponent<Sure>().SetAction(Func);
    }

    void Func()
    {
        if (PlayerAttribute.Instance.canGoodEvent)
        {
            PlayerAttribute.Instance.canGoodEvent = false;
            PlayerAttribute.Instance.goodSchedule = 0;
            // TODO:好事件触发

        }
    }
}
