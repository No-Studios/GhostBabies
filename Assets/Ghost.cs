using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{

    float currentVeloc;
    public float speed; 
    // Start is called before the first frame update
    void Start()
    {
        //currentVeloc = Vector3.up;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        FloatUp(speed);

    }

    void FloatUp(float targetVeloc)
    {
        currentVeloc = (Mathf.Lerp(currentVeloc, targetVeloc, Time.deltaTime));
        transform.position += transform.up * currentVeloc * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bound")
        {
            Destroy(this.gameObject);
        }
    }
}
