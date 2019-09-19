using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAvatar : MonoBehaviour
{
    int _health;
    public int Health
    {
        get{ return _health; }
        set { _health = value; }
    }

    [SerializeField] int _maxHealth;
    public int MaxHealth
    {
        get { return _maxHealth; }
        set { _maxHealth = value; }
    }

    float _maxSpeed = .1f;
    public float MaxSpeed
    {
        get { return _maxSpeed; }
        set { _maxSpeed = value; }
    }

    void TakeDamage(int damages)
    {
        Debug.Log("Vie" + _health);
        _health -= damages;
        if (_health <= 0)
        {
            Debug.Log("Vie " + _health);
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }


    private void Start()
    {
        _health = _maxHealth;
    }
}
