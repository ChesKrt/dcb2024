using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon Template", menuName = "PK Template/New Pokemon", order = 1)]
public class PokemonTemplate : ScriptableObject
{
    [SerializeField] private string pkName;
    [SerializeField] private int life;
    [SerializeField] private int attack;
    [SerializeField] private int defense;
    [SerializeField] private int speed;
    [SerializeField] private int specialAttack;
    [SerializeField] private int specialDefense;
    [SerializeField] private int pokedexNumber;

    public void TotalSpecialAttack(int attackPlayer, int defenseRival)
    {
        specialAttack = attackPlayer + defenseRival;
    }

    public string PkName
    {
        get { return pkName; }
        set { pkName = value; }
    }

    public int Life
    {
        get { return life; }
        set { life = value; }
    }

    public int Attack
    {
        get { return attack; }
        set { attack = value; }
    }

    public int Defense
    {
        get { return defense; }
        set { defense = value; }
    }

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public int SpecialAttack
    {
        get { return specialAttack; }
        set { specialAttack = value; }
    }

    public int SpecialDefense
    {
        get { return specialDefense; }
        set { specialDefense = value; }
    }

    public int PokdedexNumber
    {
        get { return pokedexNumber; }
        set { pokedexNumber = value; }
    }
}
