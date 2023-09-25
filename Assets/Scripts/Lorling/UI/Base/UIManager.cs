using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    private Transform canvasTf;
    private Dictionary<string, UIBase> uiTable;
    [SerializeField]
    UIBase[] uIBases;

    UIBase uiTemp;

    void Awake()
    {
        Instance = this;

        uiTable = new Dictionary<string, UIBase>();

        for(int i = 0; i < uIBases.Length; i++)
        {
            uiTable.Add(uIBases[i].name, uIBases[i]);
        }
    }

    // 显示 UI
    public void ShowUI<T>(string uiName) where T : UIBase
    {
        if (!uiTable.ContainsKey(uiName))
        {
            GameObject obj =  Instantiate(Resources.Load("Assets/Resources/Prefabs/UI/" + uiName),canvasTf,transform) as GameObject;
            
            obj.name = uiName;
            uiTemp = obj.AddComponent<UIBase>();

            uiTable.Add(uiName, uiTemp);
        }
        else uiTemp = uiTable[uiName];
        uiTemp.Show();
    }

    public void HideUI(string uiName)
    {
        if(uiTable.ContainsKey(uiName))
        {
            uiTable[uiName].Hide();
        }
    }

    public void CloseUI(string uiName)
    {
        if (uiTable.ContainsKey(uiName))
        {
            uiTable[uiName].Close();
        }
    }
}
