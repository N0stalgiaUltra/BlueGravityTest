using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class CardButton : MonoBehaviour
{
    protected Button cardButton;
    protected bool clicked;
    private Image buttonImage;
    private Color unselectedColor, selectedColor;
    public void Setup()
    {
        cardButton = GetComponent<Button>();
        buttonImage = GetComponent<Image>();
        
        cardButton.onClick.AddListener(Select);
        selectedColor = cardButton.colors.selectedColor;
        unselectedColor = cardButton.colors.pressedColor;
        buttonImage.color = unselectedColor;

    }

    public void Select()
    {
        clicked = !clicked;
        buttonImage.color = clicked ? selectedColor : unselectedColor;
    }


}
