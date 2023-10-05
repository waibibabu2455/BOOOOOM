using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "RoundState_Initial", menuName = "Data/StateMachine/RoundState/RoundState_Initial")]
public class RoundState_Initial : RoundState
{
    int eventCount;
    int random;

    private void Start()
    {
        
    }
    public override void Enter()
    {

        // TODO::从事件池中读取事件
        random = Random.Range(0, 100);
        if (random<=20) {
            eventCount = 1;
        }
        if (random>20 && random<=80) {
            eventCount = 2;    
        }
        if (random > 80) { 
            eventCount = 3;
        }
        while (eventCount>0) {
            int randomid = Random.Range(0, stateMachine.EventListNormal.Count() - 1);
            if (stateMachine.EffectedEvent.Contains(stateMachine.EventListNormal[randomid]) == false)
            {
                Event normalevent=stateMachine.EventListNormal[randomid];
                stateMachine.EffectedEvent.Add(normalevent);
                stateMachine.infotext.text = normalevent.eventname + ": " + normalevent.description;
                stateMachine.infotext.gameObject.SetActive(true);
            }
            eventCount-=1;
        }

    }

    public override void Exit()
    {

        stateMachine.SwitchState(typeof(RoundState_Evil));
    }

}