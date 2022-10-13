using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZoneFire : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider Player) 
    {
        Health.currentHealth--;
    }

    // void damageTicks() 
    // {
    //     Health.currentHealth--;
    // }
}
