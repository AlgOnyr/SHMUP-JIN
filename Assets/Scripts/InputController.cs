using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    GameObject _player;
    BulletGun _bulletGun;
    [SerializeField] float _speed;


    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _bulletGun = _player.GetComponent<BulletGun>();
    }

    void Update()
    {
        float _horizontal = Input.GetAxis("Horizontal");
        float _vertical = Input.GetAxis("Vertical");

        _player.transform.Translate(_speed * new Vector2(_horizontal, _vertical));
        if (_player.transform.position.y > Screen.height / 2)
        {
            _player.transform.position = new Vector2( _player.transform.position.x, Screen.height / 2); // Remplacer Screen.height par l'equi en world space
        }
        else if (_player.transform.position.y < -Screen.height/2)
        {
            _player.transform.position = new Vector2(_player.transform.position.x, -Screen.height / 2);
        }


        if (Input.GetKey(KeyCode.Space))
        {
            _bulletGun.Fire();
        }
    }


}
