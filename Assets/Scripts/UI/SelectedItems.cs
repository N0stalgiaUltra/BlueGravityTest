using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedItems: MonoBehaviour
{
    public static List<ItemCard> selectedItems;
    public static int total = 0;

    private void Start()
    {
        selectedItems = new List<ItemCard>();
    }
}
