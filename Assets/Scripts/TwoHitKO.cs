using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TwoHitKO : Enemy
{
    // INHERITANCE

    
    // Start is called before the first frame update
    void Start()
    {
        hitPoints = 2;
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    private void OnTriggerEnter(Collider other)
    {
        // POLYMORPHISM
        DecreaseHealth(hitPoints);
        Destroy(other.gameObject);
    }
}
