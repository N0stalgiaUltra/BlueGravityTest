using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BuyMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private Button buyButton;
    [SerializeField] private ItemCard itemCardPrefab;
    [SerializeField] private Transform cardTransform;
    public void SetMenu(List<ItemData> items, string title)
    {
        titleText.text = $"{title} + Shop";

        for (int i = 0; i < items.Count; i++)
        {
            ItemCard aux = Instantiate(itemCardPrefab, cardTransform);
            aux.SetupCard(items[i]);
        }
        //adiciona os itens
        //adiciona o texto
        //seta o bot�o
    }

}
