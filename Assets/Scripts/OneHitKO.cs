using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneHitKO : Enemy
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        hitPoints = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        DecreaseHealth(hitPoints);
        Destroy(other.gameObject);
    }
}
