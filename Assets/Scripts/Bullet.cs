using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    float _damage;
    public float Damage
    {
        get { return _damage; }
        set { _damage = value; }
    }

    Vector2 _speed;
    public Vector2 Speed {
        get { return _speed; }
        set { _speed = value; }
    }


    protected virtual void Init()
    {
        Damage = _damage;
        Speed = _speed;
    }

    protected virtual void UpdatePosition()
    {
        transform.Translate(new Vector3(Speed.x, Speed.y, 0) * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SendMessage("TakeDamage", _damage);
        Destroy(gameObject);
    }

    private void Start()
    {
        Init();
    }

    private void Update()
    {
        UpdatePosition();
    }
}
