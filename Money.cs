using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public int money;
    public int earnedMoney;
    public Text moneyText;

    void Start()
    {
        money = PlayerPrefs.GetInt("Money");
        earnedMoney = PlayerPrefs.GetInt("Sore");
        money += earnedMoney;
        PlayerPrefs.SetInt("Money", money);
        moneyText.text = money.ToString();
        earnedMoney = 0;
        PlayerPrefs.SetInt("Score", earnedMoney);

    }
}
