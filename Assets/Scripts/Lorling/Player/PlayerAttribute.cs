using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttribute : MonoBehaviour
{
    public static PlayerAttribute Instance;
    [Header("种族名")]
    [HideInInspector]
    public string raceName = "咕舟";
    [Header("有机质点数")]
    [HideInInspector]
    public int score = 10;
    [Header("个体数量")]
    [HideInInspector]
    public int number = 1;
    [Header("捕食")]
    [HideInInspector]
    public int preyOn = 1;
    [Header("化合")]
    [HideInInspector]
    public int compound = 1;
    [Header("器官数量")]
    [HideInInspector]
    public int organCount = 0;
    [Header("速度")]
    [HideInInspector]
    public int speed = 1;
    [Header("进化次数")]
    [HideInInspector]
    public int evolutionCount = 1;
    // 好事件充能进度
    [HideInInspector]
    public int goodSchedule = 0;
    public bool canGoodEvent = false;
    // 每回合获得的有机质点数
    public int getScore => evolutionCount * (preyOn + compound);
    // 消耗点数
    public int consume => evolutionCount * (speed / 2 + complexity);
    // 复杂度
    public int complexity => organCount;
    // 脂肪
    public int fat => evolutionCount;

    private void Awake()
    {
        Instance = this;

        DontDestroyOnLoad(this);
    }
}
