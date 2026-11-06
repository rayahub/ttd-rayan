using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    public float speed;
    public int damage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position; 

        transform.position += direction.normalized * speed * Time.deltaTime;

        transform.rotation = Quaternion.LookRotation(direction);


    }
    private void OnCollisionEnter(Collision collision)
    {     
        if (collision.gameObject.CompareTag("MainTower"))
        {
            collision.gameObject.GetComponent<MainTower>().getDamage(damage);
            Destroy(gameObject);

        }
    }
}
