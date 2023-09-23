using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttribute : MonoBehaviour
{
    public static PlayerAttribute Instance;
    [Header("ÖÖ×åÃû")]
    public string raceName;
    [Header("得分")]
    public int score;
    [Header("ÏûºÄµãÊý")]
    public int consume; 
    [Header("种群数量")]
    public int number;
    public int getScore => preyOn + compound;
    [Header("²¶Ê³")]
    public int preyOn;
    [Header("»¯ºÏ")]
    public int compound;
    [Header("脂肪值")]
    public int fat;

    private void Awake()
    {
        Instance = this;
        number = 1;
        preyOn = 0;
        compound = 1;
        score = 10;
        fat = 1;
    }
}
