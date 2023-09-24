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
    // ���ĵ���
    public int consume => evolutionCount * (speed / 2 + complexity);
    [Header("��������")]
    public int number;
    // ÿ�غϻ�õ��л��ʵ���
    public int getScore => evolutionCount * (preyOn + compound);
    [Header("��ʳ")]
    public int preyOn;
    [Header("����")]
    public int compound;
    // ֬��
    public int fat => evolutionCount;
    [Header("��������")]
    public int organCount;
    // ���Ӷ�
    public int complexity => organCount;
    [Header("�ٶ�")]
    public int speed;
    [Header("��������")]
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
        raceName = "����";
    }
}
