using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttribute : MonoBehaviour
{
    public static PlayerAttribute Instance;
    [Header("������")]
    public string raceName;
    [Header("�л��ʵ���")]
    public int score;
    [Header("���ĵ���")]
    public int consume; 
    [Header("��������")]
    public int number;
    public int getScore => preyOn + compound;
    [Header("��ʳ")]
    public int preyOn;
    [Header("����")]
    public int compound;
    [Header("֬��")]
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
