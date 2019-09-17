using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGun : MonoBehaviour
{
    [SerializeField] Bullet _bullet;

    float _damage;
    public float Damage
    {
        get { return _damage; }
        set { _damage = value; }
    }

    Vector2 _speed;
    public Vector2 Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    float _counter;
    [SerializeField] float _cooldown;
     public float Cooldown
    {
        get { return _cooldown; }
        set { _cooldown = value; }
    }

    private void Start()
    {
        Cooldown = _cooldown;
    }

    public void Fire()
    {
        float curCD = Time.time - _counter;
        if (curCD >= Cooldown)
        {
            Instantiate(_bullet,transform.position, Quaternion.identity) ;
            _counter = Time.time;
        }
    }

}
