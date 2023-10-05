using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class RoundStateMachine : StateMachine
{
    [SerializeField] RoundState[] states;
    public PlayerAttribute Player;
    public List<Event> EventListGood;
    public List<Event> EventListBad;
    public List<Event> EventListNormal;
    public List<Event> EffectedEvent;
    public List<Organ> OrganPool;
    public Text infotext;

    private void Awake()
    {
        stateTable = new Dictionary<System.Type, RoundState>(states.Length);

        foreach (var state in states)
        {
            state.Initialize(this);
            stateTable.Add(state.GetType(), state);
        }

        //事件池生成
        EffectLibNormal effectLibNormal = new EffectLibNormal(this);
        for (int i = 1; i <= ReadCsv("Assets/Resources/Database/Normal.csv").Count - 1; i++)
        {
            string[] eventstring = ReadCsv("Assets/Resources/Database/Normal.csv")[i];
            Event GeneratedEvent = new Event(System.Int32.Parse(eventstring[0]), eventstring[1], eventstring[2], effectLibNormal, System.Int32.Parse(eventstring[4]));
            EventListNormal.Add(GeneratedEvent);
        }
        EffectLibGood effectLibGood = new EffectLibGood(this);
        for (int i = 1; i <= ReadCsv("Assets/Resources/Database/Good.csv").Count - 1; i++)
        {
            string[] eventstring = ReadCsv("Assets/Resources/Database/Good.csv")[i];
            Event GeneratedEvent = new Event(System.Int32.Parse(eventstring[0]), eventstring[1], eventstring[2], effectLibGood, System.Int32.Parse(eventstring[4]));
            EventListGood.Add(GeneratedEvent);
        }
        EffectLibBad effectLibBad = new EffectLibBad(this);
        for (int i = 1; i <= ReadCsv("Assets/Resources/Database/Bad.csv").Count - 1; i++)
        {
            string[] eventstring = ReadCsv("Assets/Resources/Database/Bad.csv")[i];
            Event GeneratedEvent = new Event(System.Int32.Parse(eventstring[0]), eventstring[1], eventstring[2], effectLibBad, System.Int32.Parse(eventstring[4]));
            EventListBad.Add(GeneratedEvent);
        }
        OrganLib organLib = new OrganLib();
        for (int i = 1; i <= ReadCsv("Assets/Resources/Database/Organ.csv").Count - 1; i++)
        {
            string[] eventstring = ReadCsv("Assets/Resources/Database/Organ.csv")[i];
            Organ organ=new Organ(System.Int32.Parse(eventstring[0]), eventstring[1], System.Int32.Parse(eventstring[2]), eventstring[3], System.Int32.Parse(eventstring[5]),organLib);
            OrganPool.Add(organ);

        }
    }

    private void Start()
    {
        SwitchOn(stateTable[typeof(RoundState_Initial)]);
 
    }

    public void NextRound()
    {
        currentState.Exit();
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(400, 10, 250, 30), currentState.ToString());
    }

    public bool IsFree()
    {
        return currentState == stateTable[typeof(RoundState_Free)];
    }

    public void SetButton(ButtonUIBase button)
    {
        currentState.SetButton(button);
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
