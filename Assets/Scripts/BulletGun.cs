using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGun : MonoBehaviour
{
    [SerializeField] Bullet _bullet;
    [SerializeField] float _recoveryRate = 2f;
    bool _recovering = true;
    [SerializeField] float _energyCost = 10;
    PlayerAvatar _playerAvatar;

    [SerializeField] float _damage;
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
        _playerAvatar = GetComponent<PlayerAvatar>();
    }

    private void Update()
    {
    }

    public void Fire()
    {
        // Energy check, consumtion if ok then cooldown, rejection if nok
        float curCD = Time.time - _counter;

        CancelInvoke();
        if (curCD >= Cooldown && _playerAvatar.Energy >= _energyCost)
        {
            _recovering = false;
            _playerAvatar.Energy -= _energyCost;
            Instantiate(_bullet, transform.position, Quaternion.identity);
            _counter = Time.time;
        }
        Invoke("StartRegen", _cooldown * _recoveryRate);

    }

    void EnergyRegeneration()
    {
        if (_playerAvatar.Energy < 100 && _recovering)
            _playerAvatar.Energy += _energyCost;
    }

    void StartRegen()
    {
        _recovering = true;
        InvokeRepeating("EnergyRegeneration", 0, _cooldown);
    }

}
