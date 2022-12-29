using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainRocket : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Base")
        {
            SceneManager.LoadScene(1);
        }
    }
}
