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
    //[HideInInspector] public List<ItemCard> items = new List<ItemCard>();
    [SerializeField] private GameObject inventoryObj;
    [SerializeField] private Transform inventoryTransform;

    [SerializeField] private Button changeClothBtn;
    [SerializeField] private PlayerClothes playerClothes;

    [SerializeField] private int index = 0; //inventory index

    // Start is called before the first frame update
    void Start()
    {
        changeClothBtn.onClick.AddListener(ChangeCloth);
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
        aux.SetupCardToInventory();
        StaticObjects.inventoryItems.Add(aux);

        index++;
    }

    public void ChangeCloth()
    {
        //recuperar o item e indice dele
        playerClothes.ChangeCloth(StaticObjects.clickedItem.ItemSprite, StaticObjects.clickedItem.ClothID);
    }
}
