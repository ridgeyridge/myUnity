using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0, 5f)]
    float currentSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.left *  currentSpeed * Time.deltaTime);
    }

    public void SetMovmentSpeed (float speed)
    {
        currentSpeed = speed;
    }

}
