﻿using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerAttribute : MonoBehaviour
{
    public static PlayerAttribute Instance;
    [Header("种族名")]
    public string raceName = "咕舟";
    [Header("有机质点数")]
    public double score = 10;
    [Header("个体数量")]
    public double number = 10;
    [Header("捕食")]
    public double preyOn = 1;
    [Header("化合")]
    public double compound = 1;
    [Header("器官数量")]
    public int organCount = 0;
    [Header("器官")]
    public List<Organ> organList = new List<Organ>();
    [Header("速度")]
    public int speed = 1;
    [Header("进化次数")]
    public int evolutionCount = 1;
    [Header("好事件充能进度")]
    public int goodSchedule = 0;
    // 进化消耗
    public int evolutionScore = 20;
    // 复杂度最大上限
    public int complexityMax = 20;
    // 基础复杂度上限
    public int baseComplexityMax
    {
        set
        {
            baseComplexityMax = math.min(baseComplexityMax, complexityMax);
        }
        get
        {
            return baseComplexityMax;
        }
    }

    // 好事件是否充能完毕
    public bool canGoodEvent = false;
    // 每回合获得的有机质点数
    public double getScore => evolutionCount * (preyOn + compound);
    // 消耗点数
    public double consume => ((evolutionCount+1) * ((double)speed + complexity))/2 + varconsume;
    // 复杂度
    public int complexity;
    // 脂肪
    public int fat => evolutionCount+ varfat;
    // 回合数
    public int roundCount = 0;

    public int varfat;
    public int varconsume;
    public double reproductionvalue = 0;
    public double reproductionValue => Math.Max(number, fat) + reproductionvalue;

    private void Awake()
    {
        Instance = this;

        DontDestroyOnLoad(this);
    }

    public void Reset()
    {
        raceName = "咕舟";
        score = 10;
        number = 10;
        preyOn = 1;
        compound = 1;
        organCount = 0;
        organList.Clear();
        speed = 1;
        evolutionCount = 1;
        goodSchedule = 0;
        evolutionScore = 20;
        complexityMax = 20;
        canGoodEvent = false;
    }
}
