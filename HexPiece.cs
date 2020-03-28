using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexPiece : MonoBehaviour
{
    int q;
    int r;

    public enum PieceType
    {
        Scenery,
        Occupant
    }
    PieceType type;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Set(int q, int r, PieceType type) {
        SetPosition(q, r);
        this.type = type;
    }

    public void SetPosition(int q, int r) {
        this.q = q;
        this.r = r;
        transform.Translate(HexBoard.GetXYZ(q, r) - transform.localPosition, Space.Self);
    }

    public void Move(int dq, int dr)
    {
        q += dq;
        r += dr;
        //Todo: This should initiate or queue move animation rather than Translate.
        transform.Translate(HexBoard.GetXYZ(dq, dr), Space.Self);
    }

}
