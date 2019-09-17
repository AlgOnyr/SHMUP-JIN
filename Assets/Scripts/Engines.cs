using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engines : MonoBehaviour
{
   [SerializeField] BaseAvatar _baseAvatar;

    private Vector2 _speed;
    public Vector2 Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }
 
    public Vector2 Position
    {
        get { return transform.position; }
        set { transform.position = value; }
    }

    void Update()
    {
        Position += _baseAvatar.MaxSpeed * Time.deltaTime * new Vector2(Mathf.Sqrt(2), Mathf.Sqrt(2));
    }
}
