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
        priceText.text = $"Total: {SelectedItems.total}";
        buyButton.onClick.AddListener(BuyItem);

        for (int i = 0; i < items.Count; i++)
        {
            ItemCard aux = Instantiate(itemCardPrefab, cardTransform);
            aux.SetupCard(items[i]);
            //buyButton = aux.GetComponent<Button>();
            //buyButton.onClick.AddListener(BuyItem);
        }
    }
    private void Update()
    {
        priceText.text = $"Total: {SelectedItems.total}";
    }
    private void BuyItem()
    {
        if (SelectedItems.selectedItems.Count != 0)
        {
            //print($"Itens na lista {SelectedItems.selectedItems.Count}, pre�o total: {SelectedItems.total}");
            for (int i = 0; i < SelectedItems.selectedItems.Count; i++)
                inventoryRef.AddToInventory(SelectedItems.selectedItems[i]);

            SelectedItems.ClearList();
        }
        else
            return;

    }

    
}
