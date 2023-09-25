using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[CreateAssetMenu(fileName = "RoundState_Evil", menuName = "Data/StateMachine/RoundState/RoundState_Evil")]
public class RoundState_Evil : RoundState
{
    bool isAppear;
    int random;

    public override void Enter()
    {   
        EffectLibBad effectLib= new EffectLibBad();
        random = Mathf.Abs((int)Random.value % 10);
        isAppear = (random == 0);

        // TODO::从事件池中读取事件
        if (isAppear) {
            int randomid= Random.Range(1, ReadCsv("Assets/Scripts/Lorling/Database/Bad.csv").Count);
            string[] eventstring = ReadCsv("Assets/Scripts/Lorling/Database/Bad.csv")[randomid];
            Event GeneratedEvent = new Event(System.Int32.Parse(eventstring[0]), eventstring[1], effectLib);
            GeneratedEvent.effect();
        }


    }

    public override void Exit()
    {
        stateMachine.SwitchState(typeof(RoundState_Produce));
    }
    private StreamReader Read(string path)
    {
        if (path == null)
            return null;
        if (!File.Exists(path))
            File.CreateText(path);
        return new StreamReader(path);
    }
    public List<string[]> ReadCsv(string path)
    {
        List<string[]> list = new List<string[]>();
        string line;
        StreamReader stream = Read(path);
        while ((line = stream.ReadLine()) != null)
        {
            list.Add(line.Split(','));
        }
        stream.Close();
        stream.Dispose();
        return list;
    }
}
