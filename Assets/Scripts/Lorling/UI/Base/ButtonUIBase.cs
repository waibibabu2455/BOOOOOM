using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonUIBase : UIBase
{
    protected Button button;
    [SerializeField] protected GameObject canvas;
    [SerializeField] protected RoundStateMachine machine;
    protected GameObject sure;

    protected virtual void Awake()
    {
        button = GetComponent<Button>();
        sure = GameObject.FindWithTag("Sure");
    }

    public virtual void Click()
    {
        if (machine.IsFree())
        {
            machine.SetButton(this);
            canvas.SetActive(true);
        }
        
    }

    public virtual void Exit()
    {
        canvas.SetActive(false);
    }
}
