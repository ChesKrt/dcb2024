using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpriteManager : MonoBehaviour
{
    public ScriptableSprites[] sprites;
    public Image backImage;
    public Image frontImage;


    public static SpriteManager instance;

    private void Awake()
    {
        instance = this;
    }

    public Sprite MiniSprite(int player)
    {
        Sprite temp = null;

        for (int i = 0; i < sprites.Length; i++)
        {
            if (sprites[i].Pokedex == player)
            {
                temp = sprites[i].miniSprite;
            }
        }

        return temp;
    }

    public void SetSprites(int player, int enemy)
    {
        for (int i = 0; i < sprites.Length; i++)
        {
            if (sprites[i].Pokedex == player)
            {
                backImage.sprite = sprites[i].backSprite;
            }
            if (sprites[i].Pokedex == enemy)
            {
                frontImage.sprite = sprites[i].frontSprite; 
            }
        }
    }

}
