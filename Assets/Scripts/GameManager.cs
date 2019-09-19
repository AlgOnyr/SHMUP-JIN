using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _enemy;

    [Tooltip("in s")] [SerializeField] float _spawnRate = 1.5f;
    private void Awake()
    {
        if (instance is null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    void SpawnEnemies()
    {
        float randY = Random.Range(-4, 4);
        Instantiate(_enemy, new Vector3(8, randY, 0), Quaternion.identity);
    }

    void Start()
    {
        Instantiate(_player, new Vector3(-8, 0, 0),Quaternion.identity);
        InvokeRepeating("SpawnEnemies", 0, _spawnRate);
    }


    void Update()
    {
        
    }
}
