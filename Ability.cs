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
    int range;
    int speed;
    int cooldown;
    bool friendly;

    public Ability (Target tg, Effect ef, int r, int s, int cd, bool friend) {
       target = tg;
       effect = ef;
       range = r;
       speed = s;
       cooldown = cd;
       friendly = friend;
    }
}
