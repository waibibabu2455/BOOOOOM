using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentRound : TextUIBase
{
    RoundStateMachine stateMachine;

    private void Awake()
    {
        base.Awake();
        stateMachine = GameObject.Find("RoundManager").GetComponent<RoundStateMachine>();
    }

    protected override void DateUpdate()
    {
        string s = "";
        switch (stateMachine.GetCurrentRoundState())
        {
            case RoundState_Evil:
                s = "恶魔";
                break;
            case RoundState_End:
                s = "结束";
                break;
            case RoundState_Free:
                s = "自由";
                break;
            case RoundState_Initial:
                s = "初始";
                break;
            case RoundState_Produce:
                s = "生产";
                break;
            default :
                s = "过渡";
                break;
        }
        s += "阶段";
        text.text = s;
    }
}
