using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    protected IState currentState;

    protected Dictionary<System.Type, IState> stateTable;

    private void Update()
    {
        currentState.Update();
    }

    protected void SwitchOn(IState newState)
    {
        currentState = newState;
        currentState.Enter();
    }

    protected void SwitchState(IState newState)
    {
        SwitchOn(newState);
    }

    public void SwitchState(System.Type newState)
    {
        SwitchState(stateTable[newState]);
    }
}