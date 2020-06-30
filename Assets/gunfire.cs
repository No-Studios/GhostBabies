using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunfire : MonoBehaviour
{
    private Animator gunAnim;
    // Start is called before the first frame update
    void Start()
    {
        gunAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("fire");
            gunAnim.SetTrigger("fire");
            //gunAnim.ResetTrigger("fire");
        }
    }
}
