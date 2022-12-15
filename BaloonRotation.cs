using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaloonRotation : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(0.0f, 0.2f, 0.0f); 
    }
}
