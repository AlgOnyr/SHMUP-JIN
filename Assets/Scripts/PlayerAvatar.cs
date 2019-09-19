using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAvatar : BaseAvatar
{
    [SerializeField] float _energy = 100;
    public float Energy
    {
        get { return _energy; }
        set { _energy = value; }
    }

     protected override void Die()
    {
        base.Die();
        SceneManager.LoadScene(2);
    }
}
