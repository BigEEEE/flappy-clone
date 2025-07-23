using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public float moveSpeed;
    public float killZone = -45;
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);

        if (transform.position.x < killZone)
        {
            Destroy(gameObject);
        }
    }
}
