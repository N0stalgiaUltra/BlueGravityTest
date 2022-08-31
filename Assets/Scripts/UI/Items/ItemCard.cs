using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ItemCard : CardButton
{
    [SerializeField] private TextMeshProUGUI priceText;
    [SerializeField] private Image itemSprite;

    int price;
    //[SerializeField] private CardButton cardButton;

    public void SetupCard(ItemData data)
    {
        price = data.price;
        priceText.text = price.ToString(); 
        itemSprite.sprite = data.sprite;
        base.Setup();
        cardButton.onClick.AddListener(SelectedCards);
    }

    private void SelectedCards()
    {
        if (clicked)
        {
            SelectedItems.selectedItems.Add(this);
            SelectedItems.total += this.price;
            print($"Itens na lista {SelectedItems.selectedItems.Count}, preço total: {SelectedItems.total}");
        }
        else
        {
            return;
        }
    }
}
