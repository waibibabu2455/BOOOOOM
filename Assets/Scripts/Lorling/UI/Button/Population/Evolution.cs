using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Evolution : ButtonUIBase
{
    string s;
    public override void Click()
    {
        sure.GetComponent<Sure>().SetAction(Func);
        s = "";
        s += "进化为：";
        switch (PlayerAttribute.Instance.evolutionCount)
        {
            case 1:
                s += "多细胞生物\n";
                break;
            case 2:
                s += "脊壳生物\n";
                break;
            case 3:
                s += "智慧生物\n";
                break;
        }
        s += "花费" + PlayerAttribute.Instance.evolutionScore.ToString();
        info.text = s;
        info.gameObject.SetActive(true);
    }

    void Func()
    {
        info.gameObject.SetActive(false);
        if (PlayerAttribute.Instance.score < PlayerAttribute.Instance.evolutionScore) return;
        PlayerAttribute.Instance.score -= PlayerAttribute.Instance.evolutionScore;
        PlayerAttribute.Instance.evolutionCount++;
        PlayerAttribute.Instance.evolutionScore *= 5;
        PlayerAttribute.Instance.complexityMax *= 2;
        PlayerAttribute.Instance.baseComplexityMax *= 2;
    }
}
