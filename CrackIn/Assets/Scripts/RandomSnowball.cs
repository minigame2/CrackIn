using UnityEngine;

public class RandomSnowball: MonoBehaviour
{
    public GameObject spawn;
    float nextSpawn = 1f;
    public float spawnRateBall = 2f;
    Vector2 whereToSpawn;
    float randX;
    float timer;


    // Update is called once per frame
    void Update()
    {
        SpawnBall();

    }

    private void SpawnBall()
    {
        timer = timer + Time.deltaTime;
        // timer += Time.deltaTime


        if (timer > spawnRateBall)
        {
            nextSpawn = Time.deltaTime + spawnRateBall;
            randX = Random.Range(-8f, 8f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(spawn, whereToSpawn, Quaternion.identity);
            timer = 0f;
        }
    }
}