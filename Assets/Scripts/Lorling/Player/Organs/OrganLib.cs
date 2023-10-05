using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganLib : MonoBehaviour
{
    public void effect(int id)
    {
        switch (id)
        {
            case 0:
                return;
            case 1:
                PlayerAttribute.Instance.speed += 1;
                return;
            case 2:
                PlayerAttribute.Instance.speed += 2;
                return;
            case 3:
                PlayerAttribute.Instance.preyOn += 1;
                PlayerAttribute.Instance.compound += 1;
                return;
            case 4:
                PlayerAttribute.Instance.compound += 1;
                return;
            case 5:
                PlayerAttribute.Instance.compound += 1;
                PlayerAttribute.Instance.varfat += 1;
                return;
            case 6:
                PlayerAttribute.Instance.compound += 1;
                return;
            case 7:
                PlayerAttribute.Instance.varfat += 1;
                return;
            case 8:   
                PlayerAttribute.Instance.preyOn += 1;
                return;
            case 9:
                PlayerAttribute.Instance.compound += 1;
                PlayerAttribute.Instance.varfat += 1;
                return;
            case 10:
                PlayerAttribute.Instance.varfat += 1;
                return;
            case 11:
                PlayerAttribute.Instance.preyOn += 2;
                return;
            case 12:
                PlayerAttribute.Instance.reproductionvalue += -1;
                return;
            case 13:
                PlayerAttribute.Instance.complexityMax += 5;
                return;
            case 14:
                PlayerAttribute.Instance.preyOn += 1;
                PlayerAttribute.Instance.compound += 1;
                return;
            case 15:
                PlayerAttribute.Instance.complexityMax += 5;
                return;
            case 16:
                PlayerAttribute.Instance.preyOn += 1;
                PlayerAttribute.Instance.speed += 1;
                return;
            case 17:
                PlayerAttribute.Instance.compound += 4;
                PlayerAttribute.Instance.preyOn += 4;
                return;
            case 18:
                PlayerAttribute.Instance.compound += 8;
                return;
            case 19:
                PlayerAttribute.Instance.preyOn += 8;
                return;
            case 20:
                PlayerAttribute.Instance.compound += 2;
                PlayerAttribute.Instance.preyOn += 2;
                PlayerAttribute.Instance.speed += 2;
                return;
            case 21:
                PlayerAttribute.Instance.complexityMax += 10;
                return;
            case 22:
                PlayerAttribute.Instance.complexityMax += 10;
                return;
            case 23:
                PlayerAttribute.Instance.preyOn += PlayerAttribute.Instance.organList.Count;
                return;
            case 24:
                PlayerAttribute.Instance.compound += 4;
                PlayerAttribute.Instance.varfat += 4;
                return;
            case 25:
                PlayerAttribute.Instance.varfat += 4;
                PlayerAttribute.Instance.preyOn += 4;
                return;
            case 26:
                PlayerAttribute.Instance.preyOn += 4;
                return;
            case 27:
                PlayerAttribute.Instance.preyOn += PlayerAttribute.Instance.organList.Count;
                return;
            case 28:
                PlayerAttribute.Instance.speed += 4;
                PlayerAttribute.Instance.varfat += 4;
                return;
            case 29:
                PlayerAttribute.Instance.compound += 8;
                return;
            case 30:
                PlayerAttribute.Instance.preyOn += 4;
                PlayerAttribute.Instance.compound += 4;
                return;
            case 31:
                PlayerAttribute.Instance.compound += PlayerAttribute.Instance.organList.Count;
                return;
        }
    }
}
