using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ItemCard : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI priceText;
    [SerializeField] private Image itemSprite;
    [SerializeField] private CardButton cardButton;
    public void SetupCard(ItemData data)
    {
        priceText.text = data.price.ToString();
        itemSprite.sprite = data.sprite;
        cardButton.Setup();
    }
}
