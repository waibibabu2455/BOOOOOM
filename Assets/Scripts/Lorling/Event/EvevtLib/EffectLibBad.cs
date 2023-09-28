using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectLibBad : EffectLib
{
    public RoundStateMachine RoundStateMachine;
    public EffectLibBad(RoundStateMachine roundStateMachine) : base(roundStateMachine) {
        this.RoundStateMachine = roundStateMachine;
    }
    // Start is called before the first frame update
    public void Start() {
    }

    public override void effect(int id)
    {
        switch (id)
        {

            case 0:
                return;
            case 1:
                foreach (Organ i in RoundStateMachine.Player.organList) {
                    if (i.OrganName=="叶绿体") {

                    } 
                }
                Debug.Log("case1bad");
                return;
            case 2:
                RoundStateMachine.Player.compound*=0;
                Debug.Log("case2bad");
                return;
            case 3:
                RoundStateMachine.Player.preyOn *= 0;
                Debug.Log("case3bad");
                return;
            case 4:
                RoundStateMachine.Player.score = 0;
                Debug.Log("case4bad");
                return;
            case 5:
                Debug.Log("case5bad");
                return;
        }
    }
}
