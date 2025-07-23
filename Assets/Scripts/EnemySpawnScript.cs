using UnityEngine;

using static UnityEngine.RuleTile.TilingRuleOutput;

public class EnemySpawnScript : MonoBehaviour
{


    public GameObject enemy;

    public float spawnRate;
    public float heightOffset;
    private float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {

            timer += Time.deltaTime;

        }
        else
        {

            spawnEnemy();
            timer = 0;
        }
    }

    void spawnEnemy()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;


        Instantiate(enemy, new Vector3(transform.position.x, UnityEngine.Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
