using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    GameObject _player;
    BulletGun _bulletGun;
    float _speed;


    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _bulletGun = _player.GetComponent<BulletGun>();
        _speed = _player.GetComponent<PlayerAvatar>().MaxSpeed;
    }

    void Update()
    {
        float _horizontal = Input.GetAxisRaw("Horizontal");
        float _vertical = Input.GetAxisRaw("Vertical");

        _player.transform.Translate(_speed * new Vector2(_horizontal, _vertical));
        if (_player.transform.position.y > 3.3f)
        {
            _player.transform.position = new Vector2(_player.transform.position.x, 3.3f); // Remplacer Screen.height par l'equi en world space
        }
        else if (_player.transform.position.y < -4.5)
        {
            _player.transform.position = new Vector2(_player.transform.position.x, -4.5f);
        }


        if (Input.GetKey(KeyCode.Space))
        {
            _bulletGun.Fire();
        }


    }


}
