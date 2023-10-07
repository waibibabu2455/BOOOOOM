using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    public int id;
    public string eventname;
    public string description;
    public EffectLib effectLib;
    public int maintainedround;

    public Event(int id, string eventname,string description, EffectLib effectlib, int maintainedround)
    {
        this.id = id;
        this.eventname = eventname;
        this.description = description;
        this.effectLib = effectlib;
        this.maintainedround = maintainedround;
    }

    public void effect() {
        effectLib.effect(id);
    }
}
