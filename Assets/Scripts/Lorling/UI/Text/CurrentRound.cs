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
                s = "��ħ";
                break;
            case RoundState_End:
                s = "����";
                break;
            case RoundState_Free:
                s = "����";
                break;
            case RoundState_Initial:
                s = "��ʼ";
                break;
            case RoundState_Produce:
                s = "����";
                break;
            default :
                s = "����";
                break;
        }
        s += "�׶�";
        text.text = s;
    }
}
