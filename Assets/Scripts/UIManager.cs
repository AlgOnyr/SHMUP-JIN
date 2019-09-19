using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Slider _hpBar;
    [SerializeField] Slider _energyBar;
    float _maxHealth;
    float _maxEnergy;

    PlayerAvatar _player;
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAvatar>();
        _maxHealth = _player.MaxHealth;
        _maxEnergy = _player.Energy;
    }


    void Update()
    {
        if (!(_player is null))
        {
            _hpBar.value = _player.MaxHealth;
            _energyBar.value = _player.Energy / _maxEnergy;
        }
        else
        {
            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAvatar>();
            _maxHealth = _player.MaxHealth;
            _maxEnergy = _player.Energy;
        }
    }
}
