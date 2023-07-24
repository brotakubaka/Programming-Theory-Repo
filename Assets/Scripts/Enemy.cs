using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // ENCAPSULATION
    public int hitPoints { get; set; }
    

    public void DecreaseHealth(int healthPoints)
    {
        hitPoints = healthPoints;
        hitPoints--;
        if(hitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    
}
