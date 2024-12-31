using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon sprites", menuName = "SpritesPK/sprite", order = 1)]
public class ScriptableSprites : ScriptableObject
{
    public Sprite backSprite;
    public Sprite frontSprite;
    public Sprite miniSprite;
    [SerializeField] private int pokedexNumber;

    public int Pokedex
    {
        get { return pokedexNumber; }
    }
}
