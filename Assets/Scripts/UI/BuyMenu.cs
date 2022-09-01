using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BuyMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private TextMeshProUGUI priceText;
    [SerializeField] private Button buyButton;
    [SerializeField] private ItemCard itemCardPrefab;
    [SerializeField] private Transform cardTransform;
    [SerializeField] private Inventory inventoryRef;

    private List<ItemCard> shopList = new List<ItemCard>();
    public void SetMenu(List<ItemData> items, string title)
    {
        titleText.text = $"{title} Shop";
        priceText.text = $"Total: {StaticObjects.total}";
        buyButton.onClick.AddListener(BuyItem);

        for (int i = 0; i < items.Count; i++)
        {
            ItemCard aux = Instantiate(itemCardPrefab, cardTransform);
            aux.SetupCard(items[i]);
            shopList.Add(aux);
        }
    }
    private void Update()
    {
        priceText.text = $"Total: {StaticObjects.total}";
    }
    private void BuyItem()
    {
        if (StaticObjects.selectedItems.Count != 0)
        {
            for (int i = 0; i < StaticObjects.selectedItems.Count; i++)
                inventoryRef.AddToInventory(StaticObjects.selectedItems[i]);

            StaticObjects.ClearList(StaticObjects.selectedItems);
        }
        else
            return;

    }
    public void OpenMenu(bool value, List<ItemData> items, string title)
    {
        if (value)
        {
            this.gameObject.SetActive(value);
            SetMenu(items, title);
        }
        else
            return;
    }
    public void CloseMenu(bool value)
    {
        if (!value)
        {
            ClearMenu();
            this.gameObject.SetActive(value);
        }
        else
            return;
    }

    public void ClearMenu()
    {
        for (int i = 0; i < shopList.Count; i++)
        {
            shopList[i].gameObject.SetActive(false);
        }

        shopList.Clear();
    }

    
}
