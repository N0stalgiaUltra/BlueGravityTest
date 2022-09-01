using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClothes : MonoBehaviour
{
    //0 - Hood, 1- Pants, 2- Belt, 3- Torso, 4- Gloves
    [SerializeField] List<SpriteRenderer> playerClothes = new List<SpriteRenderer>(5);

    public void ChangeCloth(Sprite newCloth, int type)
    {
        switch (type)
        {
            //Hood
            case 0:
                playerClothes[type].sprite = newCloth;
                break;
            
            //Pants
            case 1: print("Changed the Pants");
                break;
            
            //Belt
            case 2:
                playerClothes[type].sprite = newCloth;
                break;
            
            //Torso
            case 3:
                playerClothes[type].sprite = newCloth;
                break;
            
            //Gloves
            case 4:
                print("Changed the Gloves");
                break;
        }
    }
}
