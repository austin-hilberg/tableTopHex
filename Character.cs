using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    int health;
    List<Ability> abilities;

    public int q = 0;
    public int r = 0;
    string charName;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Initialize(Player player, int q, int r, int hp, List<Ability> abils, string name) {
        this.player = player;
        this.q = q;
        this.r = r;
        health = hp;
        abilities = abils;
        charName = name;
    }
}
