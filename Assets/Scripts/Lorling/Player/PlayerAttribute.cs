using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttribute : MonoBehaviour
{
    public static PlayerAttribute Instance;
    [Header("种族名")]
    public string raceName;
    [Header("得分")]
    public int score;
    // 每回合消耗点数
    public int consume => evolutionCount * (speed / 2 + complexity);
    [Header("种族个体数量")]
    public int number;
    // 每回合获得分数
    public int getScore => evolutionCount * (preyOn + compound);
    [Header("捕食")]
    public int preyOn;
    [Header("化合")]
    public int compound;
    // 脂肪值
    public int fat => evolutionCount;
    [Header("器官数量")]
    public int organCount;
    // 复杂度
    public int complexity => organCount;
    [Header("速度")]
    public int speed;
    [Header("进化次数")]
    public int evolutionCount;

    private void Awake()
    {
        Instance = this;
        number = 1;
        preyOn = 0;
        compound = 1;
        score = 10;
        evolutionCount = 1;
        speed = 1;
        organCount = 0;
        raceName = "咕舟";
    }
}
