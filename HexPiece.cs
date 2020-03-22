using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexPiece : MonoBehaviour
{
    Vector2 pos = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(int q, int r)
    {
        MoveTo((int) pos.x + q, (int) pos.y + r);
    }

    public void Move(Vector2 v)
    {
        Move((int) v.x, (int) v.y);
    }

    public void MoveTo(int q, int r)
    {
        pos.Set(q, r);
    }

    public void MoveTo(Vector2 p)
    {
        MoveTo((int)p.x, (int)p.y);
    }
}
