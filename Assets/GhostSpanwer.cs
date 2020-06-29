using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpanwer : MonoBehaviour
{
    [SerializeField]
    GameObject leftBound;
    [SerializeField]
    GameObject rightBound;

    Vector3 leftBoundPos;
    Vector3 rightBoundPos; 

    //int score2 = Scoring.score;
    bool isSpawning = true;
    public GameObject[] enemies;
    int enemyIndex = 0;


    IEnumerator SpawnObject(int index)
    {

        while (isSpawning)
        {
            float seconds = Random.Range(3, 5);
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            Debug.Log("Waiting for " + seconds + " seconds");

            yield return new WaitForSeconds(seconds);

            Instantiate(enemies[enemyIndex], new Vector3(Random.Range(leftBoundPos.x, rightBoundPos.x), leftBoundPos.y, 0), transform.rotation);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        leftBoundPos = leftBound.transform.position;
        rightBoundPos = rightBound.transform.position;
        StartCoroutine(SpawnObject(enemyIndex));

    }

    // Update is called once per frame
    void Update()
    {

            isSpawning = true;
            //int enemyIndex = Random.Range(0, enemies.Length);
            //StartCoroutine(SpawnObject(enemyIndex, Random.Range(1, 3)));
    }
}
