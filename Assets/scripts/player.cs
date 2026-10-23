using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody rb;
    public float moveSpeed;
    public float jumpHeight;
    public GameObject ball;
    bool hasBall = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            ball.SetActive(hasBall);

            hasBall = !hasBall;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "net" && !hasBall)
        {
            Debug.Log("SLAM DUNK!");
        }
    }
}
