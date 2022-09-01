using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetupUI : MonoBehaviour
{
    [SerializeField] private Transform player;

    [SerializeField] private BuyMenu buyMenu;
    [SerializeField] private TextMeshProUGUI buyText;

    [SerializeField] private float offsetY;

    private ClothesList clothesList;
    [SerializeField]bool value;

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
        if(Vector3.Distance(this.transform.position, player.position) <= 3f)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                value = !value;
                ActivateMenu(value);
                ActivateTexts(!value);
            }


        }

    }

    void ActivateTexts(bool value)
    {
        buyText.gameObject.SetActive(value);

        if(buyText.gameObject.activeSelf)
            buyText.rectTransform.localPosition = new Vector3(player.position.x, player.position.y + offsetY, player.position.z);
        
        
    }

    void ActivateMenu(bool value)
    {

        buyMenu.gameObject.SetActive(value);
        
        if(buyMenu.gameObject.activeSelf)
            buyMenu.SetMenu(clothesList.clothesList, clothesList.sectionName);
    }
}
