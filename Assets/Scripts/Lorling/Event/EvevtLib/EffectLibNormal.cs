using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectLibNormal : EffectLib
{
    public RoundStateMachine RoundStateMachine;
    public EffectLibNormal(RoundStateMachine roundStateMachine) : base(roundStateMachine)
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
                this.RoundStateMachine.Player.preyOn -= 3;
                Debug.Log("case1normal");
                return;
            case 2:
                this.RoundStateMachine.Player.preyOn *= 2;
                Debug.Log("case2normal");
                return;
            case 3:
                if (this.RoundStateMachine.Player.fat >= 20)
                {
                    this.RoundStateMachine.Player.number *=0.5;
                }
                else { 
                    this.RoundStateMachine.Player.number*=0.8;
                }
                Debug.Log("case3normal");
                return;
            case 4:

                Debug.Log("case4normal");
                return;
            case 5:
                this.RoundStateMachine.Player.number -= 1;
                Debug.Log("case5normal");
                return;
            case 6:
                this.RoundStateMachine.Player.number += 1;
                Debug.Log("case6normal");
                return;
            case 7:
                if (this.RoundStateMachine.Player.fat >= 10)
                {
                    this.RoundStateMachine.Player.number *=0.8;
                }
                else
                {
                    this.RoundStateMachine.Player.number *= 0.5;
                }
                Debug.Log("case7normal");
                return;
            case 8:
                this.RoundStateMachine.Player.number -= 1;
                Debug.Log("case8normal");
                return;
            case 9:
                this.RoundStateMachine.Player.score += 10;
                Debug.Log("case9normal");
                return;
            case 10:
                this.RoundStateMachine.Player.preyOn -= 3;
                Debug.Log("case10normal");
                return;
        }
    }
}
