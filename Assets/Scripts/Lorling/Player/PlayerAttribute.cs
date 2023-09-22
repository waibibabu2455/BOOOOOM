using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttribute : MonoBehaviour
{
    public static PlayerAttribute Instance;
    [Header("种族名")]
    public string raceName;
    [Header("有机质点数")]
    public int score;
    [Header("消耗点数")]
    public int consume; 
    [Header("个体数量")]
    public int number;
    public int getScore => preyOn + compound;
    [Header("捕食")]
    public int preyOn;
    [Header("化合")]
    public int compound;
    [Header("脂肪")]
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
