using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crabs : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 endPosition;
    public float step;
    private float progress;

    void Start()
    {
        transform.position = startPosition;
    }

    // Нужно доработать кнопку Hook
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(startPosition, endPosition, progress);
        progress += step;
    }
}
