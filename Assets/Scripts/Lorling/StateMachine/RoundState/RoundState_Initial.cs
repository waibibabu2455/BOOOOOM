using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[CreateAssetMenu(fileName = "RoundState_Initial", menuName = "Data/StateMachine/RoundState/RoundState_Initial")]
public class RoundState_Initial : RoundState
{
    int eventCount;
    int random;

    public override void Enter()
    {
        random = Mathf.Abs((int)Random.value % 100);
        if (random < 20) eventCount = 1;
        else if (random < 80) eventCount = 2;
        else eventCount = 3;

        // TODO::从事件池中读取事件

        EffectLibNormal effectLib = new EffectLibNormal();
        int randomid = Random.Range(1, ReadCsv("Assets/Resources/Database/Normal.csv").Count);
        string[] eventstring = ReadCsv("Assets/Resources/Database/Normal.csv")[randomid];
        Event GeneratedEvent = new Event(System.Int32.Parse(eventstring[0]), eventstring[1], effectLib);
        GeneratedEvent.effect();
    }

    public override void Exit()
    {
        stateMachine.SwitchState(typeof(RoundState_Evil));
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