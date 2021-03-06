﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        FindObjectOfType<LivesDisplay>().TakeLife();
        var attacker = otherCollider.GetComponent<Attacker>();
        Debug.LogError(attacker);
        Destroy(attacker);
    }    
}
