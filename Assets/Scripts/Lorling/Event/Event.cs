using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    public int id;
    public string description;
    public EffectLib effectLib;

    public Event(int id, string description, EffectLib effectlib)
    {
        this.id = id;
        this.description = description;
        this.effectLib = effectlib;
    }

    public void effect() {
        effectLib.effect(id);
    }
}
