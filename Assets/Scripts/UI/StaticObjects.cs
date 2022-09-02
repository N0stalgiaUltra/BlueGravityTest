using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticObjects: MonoBehaviour
{
    public static List<ItemCard> selectedItems;
    public static List<ItemCard> inventoryItems;
    public static int total = 0;
    public static ItemCard clickedItem;
    private void Start()
    {
        selectedItems = new List<ItemCard>();
        inventoryItems = new List<ItemCard>();
    }

    public static void ClearList(List<ItemCard> aux)
    {
        aux.Clear();
        total = 0;
    }

    public static void RemoveObject(List<ItemCard> list, ItemCard item)
    {
        item.gameObject.SetActive(false);  
        list.Remove(item);
        //item = null;
    }
}
