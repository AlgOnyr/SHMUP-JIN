using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemyBasicEngine : MonoBehaviour
{
    BaseAvatar _baseAvatar;
    SpriteRenderer _sr;

    private void Start()
    {
        _baseAvatar = GetComponent<BaseAvatar>();
        _sr = GetComponent<SpriteRenderer>();

    }

    void Update()
    {
        transform.position -= _baseAvatar.MaxSpeed * transform.right;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
