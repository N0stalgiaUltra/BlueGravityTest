using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ItemCard : CardButton
{
    [SerializeField] private TextMeshProUGUI priceText;
    [SerializeField] private Image itemSprite;
    [SerializeField] private GameObject storeSprite;
    private int clothTypeId;
    int price;

    [SerializeField] private bool isOnInventory;
    public void SetupCard(ItemData data)
    {
        price = data.price;
        priceText.text = price.ToString(); 
        itemSprite.sprite = data.sprite;
        clothTypeId = (int)data.clothType;
        base.Setup();
        cardButton.onClick.AddListener(SelectedCards);
        isOnInventory = false;
    }

    private void SelectedCards()
    {
        if (!isOnInventory) {
            if (clicked)
            {
                StaticObjects.selectedItems.Add(this);
                StaticObjects.total += this.price;
            }
            else
            {
                if (StaticObjects.selectedItems.Count > 0 && StaticObjects.selectedItems.Contains(this))
                {
                    StaticObjects.selectedItems.Remove(this);

                    if (StaticObjects.total > 0)
                        StaticObjects.total -= this.price;
                    else
                        StaticObjects.total = 0;
                }

            }
        }
        else
        {
            //aqui ele reconhece o clique
            //precisaria tirar um objeto daqui 
            //print(StaticObjects.inventoryItems);
            
        }
        
    }

    public void SetupCardToInventory()
    {
        storeSprite.SetActive(false);
        isOnInventory = true;
        cardButton.onClick.AddListener(SelectedCards);
    }

    public int ClothID {get => this.clothTypeId; }
    public Sprite ItemSprite { get => this.itemSprite.sprite; }
}
