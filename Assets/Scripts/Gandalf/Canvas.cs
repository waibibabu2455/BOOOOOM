using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{
    // Start is called before the first frame update
    public Text ConsumeValue;
    public Text ComplexValue;
    public Text NutritionValue;
    public Text Number;
    public Text CatchEfficiency;
    public Text CombinationEfficiency;
    public Player Player;
    void Start()
    {
        ConsumeValue.text= Player.ConsumeValue.ToString();
        ComplexValue.text = Player.ComplexValue.ToString();
        NutritionValue.text = Player.NutritionValue.ToString();
        Number.text = Player.Number.ToString();
        CatchEfficiency.text = Player.CatchEfficiency.ToString();
        CombinationEfficiency.text = Player.CombinationEfficiency.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateText(Text text, float value)
    {
        text.text = value.ToString();
    }
}
