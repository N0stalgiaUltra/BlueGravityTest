using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesList : MonoBehaviour
{
    public enum ClothType{
        HOOD,
        PANTS,
        BELT,
        TORSO
    }
    public ClothType clothType;
    public List<ItemData> clothesList = new List<ItemData>();
}
