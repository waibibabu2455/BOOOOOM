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
            case 11:
                this.RoundStateMachine.Player.preyOn -= 3;
                return;
            case 12:
                this.RoundStateMachine.Player.number -= 1;
                return;
            case 13:
                this.RoundStateMachine.Player.preyOn += 3;
                return;
            case 14:
                this.RoundStateMachine.Player.compound -= 2;
                return;
            case 15:
                this.RoundStateMachine.Player.compound += 2;
                return;
            case 16:
                this.RoundStateMachine.Player.varconsume += 1;
                return;
            case 17:
                if (this.RoundStateMachine.Player.speed > 5) {
                    this.RoundStateMachine.Player.number -= 2;
                }
                this.RoundStateMachine.Player.number -= 3;
                return;
            case 18:
                this.RoundStateMachine.Player.number -=1;
                this.RoundStateMachine.Player.score += 10;
                return;
            case 19:
                this.RoundStateMachine.Player.number +=1;
                this.RoundStateMachine.Player.score -= 5;
                return;
            case 20:
                this.RoundStateMachine.Player.compound-=1;
                return;
            case 21:
                if (this.RoundStateMachine.Player.speed < 5)
                {
                    this.RoundStateMachine.Player.preyOn *= 0.5;
                }
                else {
                    this.RoundStateMachine.Player.preyOn *= 2;
                }
                return;
            case 22:
                this.RoundStateMachine.Player.compound *= 2;
                return;
            case 23:
                if (this.RoundStateMachine.Player.fat <= 10)
                {
                    this.RoundStateMachine.Player.compound /= 2;
                }
                else {
                    this.RoundStateMachine.Player.compound *= 2;
                }
                return;
            case 24:
                this.RoundStateMachine.Player.preyOn /= 2;
                this.RoundStateMachine.Player.compound /= 2;
                this.RoundStateMachine.Player.score += 20;
                return;
            case 25:
                this.RoundStateMachine.Player.preyOn /= 2;
                return;
            case 26:
                this.RoundStateMachine.Player.preyOn *= 2;
                return;
            case 27:
                this.RoundStateMachine.Player.number -= 5;
                if (this.RoundStateMachine.Player.number < 1) {
                    this.RoundStateMachine.Player.number = 1;
                }
                return;
            case 28:
                this.RoundStateMachine.Player.score += 10;
                return;
            case 29:
                this.RoundStateMachine.Player.score -= 10;
                this.RoundStateMachine.Player.preyOn *= 2;
                return;
            case 30:
                this.RoundStateMachine.Player.preyOn /= 2;
                this.RoundStateMachine.Player.number *= 1.1;
                return;
            case 31:
                this.RoundStateMachine.Player.number -= 1;
                if (this.RoundStateMachine.Player.number < 1) {
                    this.RoundStateMachine.Player.number = 1;
                }
                return;
            case 32:
                this.RoundStateMachine.Player.score *= 0.8;
                return;
            case 33:
                this.RoundStateMachine.Player.score *= 1.2;
                return;
            case 34:
                this.RoundStateMachine.Player.score *= 0.95;
                this.RoundStateMachine.Player.preyOn *= 2;
                return;
            case 35:
                this.RoundStateMachine.Player.score *= 0.9;
                this.RoundStateMachine.Player.number -= 1;
                return;
            case 36:
                if (this.RoundStateMachine.Player.speed > 5) {
                    this.RoundStateMachine.Player.score *= 0.9;
                }
                else {
                    this.RoundStateMachine.Player.score *= 0.8;
                }
                return;
            case 37:
                if (this.RoundStateMachine.Player.speed > 5)
                {
                    this.RoundStateMachine.Player.preyOn *= 2;
                }
                if (this.RoundStateMachine.Player.speed > 10) {
                    this.RoundStateMachine.Player.preyOn *= 4;
                }
                return;
            case 38:
                if (this.RoundStateMachine.Player.fat <= 5) {
                    this.RoundStateMachine.Player.preyOn = 0;
                }
                return;
            case 39:
                this.RoundStateMachine.Player.varconsume -= 5;
                return;
            case 40:
                this.RoundStateMachine.Player.varconsume += 5;
                return;
        }
    }
}
