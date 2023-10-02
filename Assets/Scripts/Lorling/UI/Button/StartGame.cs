using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : ButtonUIBase
{
    [SerializeField] GameObject currentCanvas;
    public override void Click()
    {
        currentCanvas.SetActive(false);
        canvas.SetActive(true);
    }
}
