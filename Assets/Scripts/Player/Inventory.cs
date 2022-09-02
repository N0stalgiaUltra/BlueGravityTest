using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    //abre inventario
    //coloca cards comprados
    //troca roupa do player 
    //
    [SerializeField] private GameObject inventoryObj;
    [SerializeField] private Transform inventoryTransform;

    [SerializeField] private Button changeClothBtn;
    [SerializeField] private Button sellItemBtn;
    [SerializeField] private PlayerClothes playerClothes;
    [SerializeField] private PlayerWallet playerCoins;

    private bool value;
    [SerializeField] private int userCoins = 0;
    // Start is called before the first frame update
    void Start()
    {
        changeClothBtn.onClick.AddListener(ChangeCloth);
        sellItemBtn.onClick.AddListener(SellItem);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            value = !value;
            OpenCloseInventory(value);
        }

    }

    public void OpenCloseInventory(bool value)
    {
        inventoryObj.SetActive(value);
    }

    public void AddToInventory(ItemCard obj)
    {
        ItemCard aux = Instantiate(obj, inventoryTransform);
        aux.SetupCardToInventory();
        StaticObjects.inventoryItems.Add(aux);
    }

    public void ChangeCloth()
    {
        //recuperar o item e indice dele
        if(StaticObjects.clickedItem != null)
            playerClothes.ChangeCloth(StaticObjects.clickedItem.ItemSprite, StaticObjects.clickedItem.ClothID);
    }

    public void SellItem()
    {
        if (!playerClothes.IsPlayerWearing(StaticObjects.clickedItem.ItemSprite)) 
        {
            playerCoins.CoinsManager(StaticObjects.clickedItem.Price, true);
            StaticObjects.RemoveObject(StaticObjects.inventoryItems, StaticObjects.clickedItem);
        }
        else
            Debug.LogWarning("UNEQUIP THIS CLOTH PIECE TO SELL");
    }
}
