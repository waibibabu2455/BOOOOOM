using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttribute : MonoBehaviour
{
    public static PlayerAttribute Instance;
    [Header("������")]
    [HideInInspector]
    public string raceName = "����";
    [Header("�л��ʵ���")]
    [HideInInspector]
    public int score = 10;
    [Header("��������")]
    [HideInInspector]
    public int number = 1;
    [Header("��ʳ")]
    [HideInInspector]
    public int preyOn = 1;
    [Header("����")]
    [HideInInspector]
    public int compound = 1;
    [Header("��������")]
    [HideInInspector]
    public int organCount = 0;
    [Header("�ٶ�")]
    [HideInInspector]
    public int speed = 1;
    [Header("��������")]
    [HideInInspector]
    public int evolutionCount = 1;
    // ���¼����ܽ���
    [HideInInspector]
    public int goodSchedule = 0;
    public bool canGoodEvent = false;
    // ÿ�غϻ�õ��л��ʵ���
    public int getScore => evolutionCount * (preyOn + compound);
    // ���ĵ���
    public int consume => evolutionCount * (speed / 2 + complexity);
    // ���Ӷ�
    public int complexity => organCount;
    // ֬��
    public int fat => evolutionCount;

    private void Awake()
    {
        Instance = this;

        DontDestroyOnLoad(this);
    }
}
