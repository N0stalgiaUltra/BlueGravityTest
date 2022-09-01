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
    public void SetMenu(List<ItemData> items, string title)
    {
        titleText.text = $"{title} Shop";
        priceText.text = $"Total: {StaticObjects.total}";
        buyButton.onClick.AddListener(BuyItem);

        for (int i = 0; i < items.Count; i++)
        {
            ItemCard aux = Instantiate(itemCardPrefab, cardTransform);
            aux.SetupCard(items[i]);
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

    
}
