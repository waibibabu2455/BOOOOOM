using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float ConsumeValue;
    public float ComplexValue;
    public float NutritionValue;
    public float Number;
    public float CatchEfficiency;
    public float CombinationEfficiency;
    public float OrganicValue;
    public string Name;
    public Player player;
    public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void UpdateConsumeValue(float value)
    {
        this.ConsumeValue = value;
        this.canvas.UpdateText(canvas.ConsumeValue, value);


    }
    void UpdateComplexValue(float value)
    {
        this.ComplexValue = value;
        this.canvas.UpdateText(canvas.ComplexValue, value);
    }
    void UpdateNutritionValue(float value)
    {
        this.ComplexValue = value;
        this.canvas.UpdateText(canvas.ComplexValue, value);
    }
    void UpdateNumber(float value)
    {
        this.Number = value;
        this.canvas.UpdateText(canvas.Number, value);
    }
    void UpdateCatchEfficiency(float value)
    {
        this.CatchEfficiency = value;
        this.canvas.UpdateText(canvas.CatchEfficiency, value);
    }
    void UpdateCombinationEfficiency(float value)
    {
        this.CombinationEfficiency = value;
        this.canvas.UpdateText(canvas.CombinationEfficiency, value);
    }
    private void UpdateOrganicValue(float value)
    {
        this.OrganicValue = value;
        this.canvas.UpdateText(canvas.OrganicValue, value);
    }
}
