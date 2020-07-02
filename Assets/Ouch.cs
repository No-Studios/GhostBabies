using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ouch : MonoBehaviour
{
    [SerializeField] private GameObject[] _lives = null;
    private int _index = 0;

    void Update()
    {
        /*if (_index == 4){
            _youDied.SetActive(true);
        }*/
    }
    void OnCollisionEnter2D(Collision2D ghost)
    {
        if((ghost.gameObject.tag == "Ghost"))
        {
            _lives[_index].SetActive(false);
            _index++;
        }
    }
}
