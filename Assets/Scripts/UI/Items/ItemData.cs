using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "BlueGravity/Create Item Data")]
public class ItemData : ScriptableObject 
{   
    public enum ClothType
    {
        HOOD,
        PANTS,
        BELT,
        TORSO,
        GLOVES
    }
    public ClothType clothType;
    public Sprite sprite;
    public int price;
}
