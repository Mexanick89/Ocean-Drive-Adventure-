using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void Market()
    {
        SceneManager.LoadScene(3);
    }

    public void Base()
    {
        SceneManager.LoadScene(1);
    }
}
