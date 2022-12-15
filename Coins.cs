using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class Coins : MonoBehaviour
{
    public int coins;
    public int maxCoins;

    [SerializeField] private AudioSource UpCristall;


    public Text TextCoins;

    private void Awake()
    {
        if (!PlayerPrefs.HasKey("Almaz"))
        {
            PlayerPrefs.SetInt("Almaz", 0);
        }
    }
    void Start()
    {
        coins = PlayerPrefs.GetInt("Almaz");
        TextCoins.text = coins.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Almaz")
        {
            coins++;
            TextCoins.text = coins.ToString();
            PlayerPrefs.SetInt("Almaz", coins);
            other.gameObject.SetActive(false);
            UpCristall.Play();
        }
    }
}
