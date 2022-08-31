using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //abre inventario
    //coloca cards comprados
    //troca roupa do player 
    public List<ItemCard> items = new List<ItemCard>();
    [SerializeField] private GameObject inventoryObj;
    [SerializeField] private Transform inventoryTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            inventoryObj.SetActive(true);

    }

    public void AddToInventory(ItemCard obj)
    {
        ItemCard aux = Instantiate(obj, inventoryTransform);
        items.Add(aux);
    }
}
