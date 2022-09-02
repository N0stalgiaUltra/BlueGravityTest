using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClothes : MonoBehaviour
{
    //0 - Hood, 1- Belt, 2- Torso
    [SerializeField] List<SpriteRenderer> playerClothes = new List<SpriteRenderer>(5);

    public void ChangeCloth(Sprite newCloth, int type)
    {
        switch (type)
        {
            //Hood
            case 0:
                playerClothes[type].sprite = newCloth;
                break;
            
            //Belt
            case 1:
                playerClothes[type].sprite = newCloth;
                break;
            
            //Torso
            case 2:
                playerClothes[type].sprite = newCloth;
                break;

        }
    }

    public bool IsPlayerWearing(Sprite aux)
    {
        if (aux == null)
            return false;
        
        else
        {
            for (int i = 0; i < playerClothes.Count; i++)
            {
                if (playerClothes[i].sprite.Equals(aux))
                    return true;
            }

            return false;
        }        
    }
}
