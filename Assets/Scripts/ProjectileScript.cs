using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public float projectileSpeed;
    public float killZone = 30;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.right * projectileSpeed * Time.deltaTime);


        if (transform.position.x > killZone)
        {
            Destroy(gameObject);
        }
    }
}
