using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PokemonManager : MonoBehaviour
{

    PokemonStats pikachu;
    PokemonStats charmander;

    // Start is called before the first frame update
    void Start()
    {
        pikachu = new PokemonStats();
        pikachu.pkName = "Pikachu";
        pikachu.life = 35;
        pikachu.attack = 55;
        pikachu.defense = 40;
        pikachu.speed = 90;
        Debug.Log($"Name: {pikachu.pkName}, life: {pikachu.life}, attack: {pikachu.attack}, defense: {pikachu.defense}, speed: {pikachu.speed}");

        charmander = new PokemonStats("Charmander", 39, 52, 43, 65);
        Debug.Log($"Name: {charmander.pkName}, life: {charmander.life}, attack: {charmander.attack}, defense: {charmander.defense}, speed: {charmander.speed}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
