using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Restart")
        {
            SceneManager.LoadScene(2);
                }
    }
}
