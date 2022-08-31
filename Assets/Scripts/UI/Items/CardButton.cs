using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class CardButton : MonoBehaviour
{
    [SerializeField] private Button cardButton;

    [SerializeField] private bool clicked;
    [SerializeField] private Image buttonImage;
    private Color unselectedColor, selectedColor;
    public void Setup()
    {

        cardButton.onClick.AddListener(Select);
        //selectedColor = Color.red;
        selectedColor = cardButton.colors.selectedColor;
        //unselectedColor = Color.blue;
        unselectedColor = cardButton.colors.pressedColor;
        buttonImage.color = unselectedColor;

        //clicou, ele fica selecionado
        //desclicou, ele desceleciona
    }

    public void Select()
    {
        clicked = !clicked;
        buttonImage.color = clicked ? selectedColor : unselectedColor;

    }

 
}

// fundo transparente
// prseeiona -> fundo branco
// para de clicar, mantém fundo branco

//unsleceted = fundo transparente
// selected = fundo branco