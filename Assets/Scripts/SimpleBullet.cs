using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBullet : Bullet
{
    [SerializeField] Vector2 _bulletSpeed = new Vector2(10, 0);
    protected override void Init()
    {
        base.Init();
        Speed = _bulletSpeed;
    }

    protected override void UpdatePosition()
    {
        base.UpdatePosition();

    }
}
