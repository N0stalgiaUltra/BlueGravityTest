using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetupUI : MonoBehaviour
{
    [SerializeField] private Transform player;

    [SerializeField] private BuyMenu buyMenu;
    [SerializeField] private float offsetY;

    private ClothesList clothesList;
    [SerializeField] bool value;

    void Start()
    {
        clothesList = GetComponent<ClothesList>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckDistance();
    }

    void CheckDistance()
    {
        if (Vector3.Distance(this.transform.position, player.position) <= 3f)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                value = !value;
                ActivateMenu(value);
            }
        }

    }    
        
    void ActivateMenu(bool value)
    {
        if (!buyMenu.gameObject.activeSelf)
            buyMenu.OpenMenu(value, clothesList.clothesList, clothesList.sectionName);
        else
            buyMenu.CloseMenu(value);

    }
}
