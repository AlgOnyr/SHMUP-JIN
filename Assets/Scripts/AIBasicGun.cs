using System.Collections;
using System.Collections.Generic;
using UnityEngine;


enum BulletType { Player, Enemy };
public class AIBasicGun : MonoBehaviour
{
    [SerializeField] float _cooldown;
    [SerializeField] GameObject _bullet;
    private void Start()
    {
        InvokeRepeating("Fire", 0 ,_cooldown);
    }


    void Fire()
    {
        Instantiate(_bullet, transform.position, Quaternion.identity);
    }
}
