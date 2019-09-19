using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAvatar : BaseAvatar
{
    [SerializeField] int _scoreValue = 100;
    protected override void DeathRegister()
    {
        GameManager.instance.Score += _scoreValue;
    }
}
