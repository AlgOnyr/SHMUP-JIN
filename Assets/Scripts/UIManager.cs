using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] Slider _hpBar;
    [SerializeField] Slider _energyBar;
    [SerializeField] TextMeshProUGUI _scoreText;
    float _maxHealth;
    float _maxEnergy;

    PlayerAvatar _player;
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAvatar>();
        _maxHealth = _player.MaxHealth;
        _maxEnergy = _player.Energy;
        _scoreText.text = "000";
    }


    void Update()
    {
        _scoreText.text = GameManager.instance.Score.ToString();
        if (!(_player is null))
        {
            _hpBar.value = _player.Health / _maxHealth;
            _energyBar.value = _player.Energy / _maxEnergy;
        }
        else
        {
            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAvatar>();
            _maxHealth = _player.Health;
            _maxEnergy = _player.Energy;
        }
    }

}
