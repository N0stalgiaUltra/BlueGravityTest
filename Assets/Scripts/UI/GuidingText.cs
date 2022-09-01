using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GuidingText : MonoBehaviour
{
    [TextArea(1, 10)]
    [SerializeField] private string text;

    [SerializeField] private TextMeshProUGUI textObj;
    void Start()
    {
        textObj.text = text;
    }

    public void OpenText(bool value) 
    {
        if (textObj.text.Length > 0)
            textObj.text = text;


        this.textObj.gameObject.SetActive(value); 
    
    }


}
