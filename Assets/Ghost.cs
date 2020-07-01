using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{

    float currentVeloc;
    public float speed;
    public Score sc;
    public movement_type movement_Type;

    [SerializeField]
    private float frequency = 3f;

    [SerializeField]
    private float magnitude = 3f;


    Vector3 pos; 
    public enum movement_type
    {
        NORMAL, 
        WAVE
    }
    // Start is called before the first frame update
    void Start()
    {
        //currentVeloc = Vector3.up;
        sc = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        if (movement_Type == movement_type.NORMAL)
        {
            FloatUp(speed);
        }
        else if(movement_Type == movement_type.WAVE)
        {
            WaveMove();
        }

    }

    void FloatUp(float targetVeloc)
    {
        currentVeloc = (Mathf.Lerp(currentVeloc, targetVeloc, Time.deltaTime));
        transform.position += transform.up * currentVeloc * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("yooooooo");

        if (collision.gameObject.tag == "TBound")
        {

            sc.gameOverCount++;
            Destroy(this.gameObject);
        }
    }

    private void WaveMove()
    {
        pos += transform.up * Time.deltaTime * speed;
        float tempDeltaY = Mathf.Lerp(this.transform.position.y, pos.y, Time.deltaTime);
        transform.position = new Vector3(pos.x, tempDeltaY, 0) + transform.right * Mathf.Sin(Time.time * frequency) * magnitude;
    }

    public void RandomizeWave()
    {
        magnitude = Random.Range(2f, 3.5f);
        frequency = Random.Range(2, 4);
    }
}
