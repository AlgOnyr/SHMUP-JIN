using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvatar : BaseAvatar
{
    [SerializeField] float _energy = 100;
    public float Energy
    {
        get { return _energy; }
        set { _energy = value; }
    }
}
