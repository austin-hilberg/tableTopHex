using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability
{

    public enum Target
    {
        Self,
        SelfShape,
        Unit,
        UnitShape,
        Location,
        LocationShape
    }
    Target target;
    public enum Effect
    {
        Path,
        Jump,
        Heal,
        Harm
    }
    Effect effect;
    int value;
    int range;
    int speed;
    int cooldown;
    bool friendly;
    string name;

    public Ability (Target target, Effect effect, int value, int range, int speed, int cooldown, bool friendly, string name) {
       this.target = target;
       this.effect = effect;
       this.value = value;
       this.range = range;
       this.speed = speed;
       this.cooldown = cooldown;
       this.friendly = friendly;
       this.name = name;
    }
}
