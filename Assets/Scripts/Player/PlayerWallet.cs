using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerWallet : MonoBehaviour
{
    [SerializeField] private int coins;
    [SerializeField] private TextMeshProUGUI coinsText;

    void Start()
    {
        coins = 1000;
    }

    private void Update()
    {
        coinsText.text = $"Coins: {coins}";
    }

    public void CoinsManager(int value, bool add)
    {
        if (add)
            coins += value;
        else
            coins -= value;
    }

    public void DebugAddCoins() => coins += 10000;

    public int Coins { get => coins; }
}
