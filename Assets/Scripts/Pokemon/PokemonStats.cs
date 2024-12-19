using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonStats
{
    public string pkName = "";
    public int life;
    public int attack;
    public int defense;
    public int speed;
    public int specialAttack;
    public int specialDefense;


    public PokemonStats()
    {

    }

    public PokemonStats(string _pkName, int _life, int _attack, int _defense, int _speed)
    {
        pkName = _pkName;
        life = _life;
        attack = _attack;
        defense = _defense;
        speed = _speed;
    }

    /*public void Pikachu()
    {
        pkName = "Pikachu";
        life = 35;
        attack = 55;
        defense = 40;
        speed = 90;
    }

    public void Charmander()
    {
        pkName = "Charmander";
        life = 39;
        attack = 52;
        defense = 43;
        speed = 65;
    }

    public void Bulbasaur()
    {
        pkName = "Bulbasaur";
    }*/
    

}
