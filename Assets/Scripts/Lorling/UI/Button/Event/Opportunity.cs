using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opportunity : ButtonUIBase
{
    public override void Click()
    {
        sure.GetComponent<Sure>().SetAction(Func);
        if (!PlayerAttribute.Instance.canGoodEvent)
        {
            info.text = "你现在还不能召唤天使骰子";
        }
        else
        {
            info.text = "你确定要现在召唤天使骰子吗？";
        }
    }

    void Func()
    {
        if (PlayerAttribute.Instance.canGoodEvent)
        {
            PlayerAttribute.Instance.canGoodEvent = false;
            PlayerAttribute.Instance.goodSchedule = 0;
            // TODO:好事件触发
            int randomid = Random.Range(0, machine.EventListGood.Count - 1);
            Event goodevent = machine.EventListGood[randomid];
            machine.EffectedEvent.Add(goodevent);
            machine.infotext.text = goodevent.eventname + ": " + goodevent.description;
            machine.infotext.gameObject.SetActive(true);
        }
    }
}
