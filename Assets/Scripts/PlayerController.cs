using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizonalInput;
    public float xRange = 10;
    public float speed = 10.0f;
    public GameObject projectilePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation); }

        if (transform.position.x < -xRange)
        {

            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            horizonalInput = Input.GetAxis("Horizonal");
            transform.Translate(Vector3.right * horizonalInput * Time.deltaTime * speed);
        }
    }
}
