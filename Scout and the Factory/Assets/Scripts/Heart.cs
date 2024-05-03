using UnityEngine;

public class Heart : MonoBehaviour
{
    public float speed = 5.0f;
    private PlayerHealth playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
        // transform.rotation = Quaternion.Euler(0, speed, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerHealth.curHealth++;
            Destroy(gameObject);
        }
    }
}
