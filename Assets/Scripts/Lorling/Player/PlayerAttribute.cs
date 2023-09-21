using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttribute : MonoBehaviour
{
    public static PlayerAttribute Instance;
    public string raceName { get { return Instance.raceName; } }
    public int score;
    public int consume;
    public int number;
    public int getScore = 1;

    private void Awake()
    {
        Instance = this; 
    }


}
