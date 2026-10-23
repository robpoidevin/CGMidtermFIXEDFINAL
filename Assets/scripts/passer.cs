using UnityEngine;

public class passer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject ball;
    bool hasBall = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            ball.SetActive(hasBall);
            hasBall = !hasBall;
        }
    }
}
