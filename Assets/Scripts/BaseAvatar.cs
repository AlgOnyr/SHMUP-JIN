using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

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

    [SerializeField] float _maxSpeed = .1f;
    public float MaxSpeed
    {
        get { return _maxSpeed; }
        set { _maxSpeed = value; }
    }


    UnityEvent OnDeathEvent;

    void Start()
    {
        _health = _maxHealth;
        if (OnDeathEvent == null)
            OnDeathEvent = new UnityEvent();

        OnDeathEvent.AddListener(DeathRegister);
    }



    protected virtual void DeathRegister()
    {
        
    }


    void TakeDamage(int damages)
    {
        _health -= damages;
        if (_health <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        OnDeathEvent.Invoke();
        Destroy(gameObject);
    }


}
