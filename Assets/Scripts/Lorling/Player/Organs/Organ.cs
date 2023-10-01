using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Organ : MonoBehaviour
{
    public int Organid;
    public string OrganName;
    public int Complexity;
    public string Description;
    public int Refund;
    public OrganLib organLib;
    public bool enable;
    public Organ(int Organid, string OrganName, int Complexity, string Description, int Refund, OrganLib organLib) { 
        this.Organid = Organid; 
        this.OrganName = OrganName;
        this.Complexity = Complexity;
        this.Description = Description;
        this.Refund = Refund;
        this.organLib = organLib;
        this.enable = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void OrganEffect() {
        if (enable)
        {
            organLib.effect(this.Organid);
        }
    }
    
}
