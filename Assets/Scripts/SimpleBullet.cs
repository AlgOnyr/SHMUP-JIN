using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBullet : Bullet
{
    [SerializeField] string _target;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(_target))
        {
            Debug.Log(Damage);
            collision.gameObject.SendMessage("TakeDamage", Damage);
            Destroy(gameObject);
        }
    }
}
