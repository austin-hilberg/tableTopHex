using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability
{
    public GameManager.TargetType targetType;
    HexPiece target;
    GameManager.EffectType effectType;
    int value;
    public int range;
    int speed;
    int cooldown;
    public bool friendly;
    string name;

    public Ability (
        GameManager.TargetType targetType,
        GameManager.EffectType effectType,
        int value,
        int range,
        int speed,
        int cooldown,
        bool friendly,
        string name
        ) {
       this.targetType = targetType;
       this.effectType = effectType;
       this.value = value;
       this.range = range;
       this.speed = speed;
       this.cooldown = cooldown;
       this.friendly = friendly;
       this.name = name;
    }

    public void SetTarget(HexPiece target) {
        this.target = target;
    }
}
