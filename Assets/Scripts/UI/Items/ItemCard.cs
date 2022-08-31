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
            
        }
        else
        {
            if(SelectedItems.selectedItems.Count > 0 && SelectedItems.selectedItems.Contains(this))
            {
                SelectedItems.selectedItems.Remove(this);
                
                if (SelectedItems.total > 0)
                    SelectedItems.total -= this.price;
                else
                    SelectedItems.total = 0;
            }
            
        }
    }
}
