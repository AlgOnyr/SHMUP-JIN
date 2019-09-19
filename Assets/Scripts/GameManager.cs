using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _enemy;
    int _score = 0;
    public int Score
    {
        get { return _score; }
        set { _score = value; }
    }

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

    void OnEnable()
    {
        //Listen for a scene change as soon as the GameManager is enabled.
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    void OnDisable()
    {
        //Tell our 'OnLevelFinishedLoading' function to stop listening for a scene change if GameManager is disabled.
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        CancelInvoke();
        Instantiate(_player, new Vector3(-8, 0, 0), Quaternion.identity);
        //Reset Score when reloading
        if (scene.buildIndex == 1)
        {
            _score = 0;
            InvokeRepeating("SpawnEnemies", 0, _spawnRate);
        }
    }
}
