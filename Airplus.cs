using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Airplus : MonoBehaviour
{
    public AirBaloon air;
    [SerializeField] private AudioSource UpO2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Air")
        {
            air.time -= 30f;
            UpO2.Play();
            other.gameObject.SetActive(false);
        }
    }

}

