using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baby : MonoBehaviour
{

    SpriteRenderer babySprite; 
    // Start is called before the first frame update
    void Start()
    {

        babySprite = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BBound")
        {
            Debug.Log("start fade");

            StartCoroutine(FadeOut());
        }
    }

    IEnumerator FadeOut()
    {
        while (babySprite.color.a > 0)
        {
            
            yield return new WaitForSeconds(.1f);
            babySprite.color = new Color(255, 255, 255, babySprite.color.a - .1f);

        }
        Destroy(this.gameObject);
        //s.color.s
    }*/
}
