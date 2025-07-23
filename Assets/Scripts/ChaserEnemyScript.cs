using UnityEngine;
using UnityEngine.Rendering;

using static UnityEngine.GraphicsBuffer;

public class ChaserEnemyScript : MonoBehaviour
{
    GameObject player;
    public float moveSpeed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 target = player.transform.position;
        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target, step);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit");
           Destroy(gameObject);    
    }
}
