using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectLibGood : EffectLib
{
    public RoundStateMachine RoundStateMachine;
    public EffectLibGood(RoundStateMachine roundStateMachine) : base(roundStateMachine)
    {
        this.RoundStateMachine = roundStateMachine;
    }
    // Start is called before the first frame update
    public override void effect(int id)
    {
        switch (id)
        {

            case 0:
                return;
            case 1:
                Debug.Log("case1");
                return;
            case 2:
                RoundStateMachine.Player.score += 50;
                Debug.Log("case2");
                return;
            case 3:
                RoundStateMachine.Player.preyOn *= 4;
                Debug.Log("case3");
                return;
            case 4:
                RoundStateMachine.Player.compound *= 4;
                Debug.Log("case4");
                return;
            case 5:
                RoundStateMachine.Player.number *= 2;
                Debug.Log("case5");
                return;
            case 6:
                for (int i = 1; i <= 5; i++) {
                    Organ organ = RoundStateMachine.OrganPool[Random.Range(0, RoundStateMachine.OrganPool.Count - 1)];
                    RoundStateMachine.Player.organList.Add(organ);
                }
                return;
            case 7:
                RoundStateMachine.Player.number += 10;
                return;
            case 8:
                RoundStateMachine.Player.preyOn += 8;
                return;
            case 9:
                RoundStateMachine.Player.compound += 8;
                return;
            case 10:
                RoundStateMachine.Player.score += 20;
                return;
        }     

    }
}
