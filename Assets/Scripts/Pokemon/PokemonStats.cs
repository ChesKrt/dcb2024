using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonStats
{
    private string pkName = "";
    private int life;
    private int attack;
    private int defense;
    private int speed;
    private int specialAttack;
    private int specialDefense;
    private int pokedexNumber;

    AttackStats attack1;
    AttackStats attack2;
    AttackStats attack3;
    AttackStats attack4;

    public PokemonStats(string pkName, int life, int attack, int defense, int speed, int specialAttack, int specialDefense, int power1, int power2, int power3, int power4, int pokedexNumber)
    {
        this.pkName = pkName;
        this.life = life;
        this.attack = attack;
        this.defense = defense;
        this.speed = speed;
        this.specialAttack = specialAttack;
        this.specialDefense = specialDefense;
        this.pokedexNumber = pokedexNumber;

        attack1 = new AttackStats(power1, "Placaje");
        attack2 = new AttackStats(power2, "Ataque rapido");
        attack3 = new AttackStats(power3, "Arañazo");
        attack4 = new AttackStats(power4, "Doble ataque");
        this.pokedexNumber = pokedexNumber;
    }

    public void TotalSpecialAttack(int attackPlayer, int defenseRival)
    {
        specialAttack = attackPlayer + defenseRival;
    }

    /*public string GetName()
    {
        return pkName;
    }

    public void SetName(string pkName)
    {
        this.pkName = pkName;
    }*/

    public string PkName
    {
        get { return pkName; }
        set {  pkName = value; }
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

    public int Attack1
    {
        get { return attack1.Power; }
        set { attack1.Power = value; }
    }

    public int Attack2
    {
        get { return attack2.Power; }
        set { attack1.Power = value; }
    }

    public int Attack3
    {
        get { return attack3.Power; }
        set { attack1.Power = value; }
    }

    public int Attack4
    {
        get { return attack4.Power; }
        set { attack1.Power = value; }
    }

    public string Name1
    {
        get { return attack1.Name; }
        set { attack1.Name = value; }
    }

    public string Name2
    {
        get { return attack2.Name; }
        set { attack2.Name = value; }
    }

    public string Name3
    {
        get { return attack3.Name; }
        set { attack3.Name = value; }
    }

    public string Name4
    {
        get { return attack4.Name; }
        set { attack4.Name = value; }
    }

    public int PokdedexNumber
    {
        get { return pokedexNumber; }
        set { pokedexNumber = value; }
    }

}
