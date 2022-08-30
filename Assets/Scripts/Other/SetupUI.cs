using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetupUI : MonoBehaviour
{
    [SerializeField] private Transform player;

    [SerializeField] private TextMeshProUGUI buyText;

    [SerializeField] private float adjust;
    void Start()
    {
        
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
            ActivateObjects();
        }

    }

    void ActivateObjects()
    {
        buyText.gameObject.SetActive(true);
        buyText.rectTransform.localPosition = new Vector3(player.position.x, player.position.y + adjust, player.position.z);
    }
}
