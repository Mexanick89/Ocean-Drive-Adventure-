using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOffer : MonoBehaviour
{
    public Light FL;

    void Update()
    {
        if (Input.GetKeyDown (KeyCode.F))
        {
            if(FL.enabled == false)
            {
                FL.enabled = true;
            }
            else
            {
                FL.enabled = false;
            }
        }
    }
    public void SUN()
    {
        if (FL.enabled == false)
        {
            FL.enabled = true;
        }
        else
        {
            FL.enabled = false;
        }
    }
}
