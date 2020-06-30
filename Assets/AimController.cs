using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimController : MonoBehaviour
{

    Ray ray;
    RaycastHit2D hitData;

    public GameObject baby;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0);
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.zero);
            Debug.DrawRay(transform.position, Vector2.zero, Color.white, 5.0f);
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
                if(hit.collider.tag == "Ghost")
                {
                    spawnBaby(hit);
                    Destroy(hit.collider.gameObject);
                }
                //hit.collider.attachedRigidbody.AddForce(Vector2.up);
            }
        }

    }

    void spawnBaby(RaycastHit2D hit)
    {

        Debug.Log(hit.transform.position.x);
        Instantiate(baby, hit.transform.position, Quaternion.identity);

        Debug.Log("weeee");
    }


}
