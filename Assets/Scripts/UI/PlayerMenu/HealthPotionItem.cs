using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotionItem : Item
{
    // Start is called before the first frame update
    
    public HealthManager hlb;
    public float life;
    public override void use()
    {
        hlb.addLife(life);
    }
    
    
}
