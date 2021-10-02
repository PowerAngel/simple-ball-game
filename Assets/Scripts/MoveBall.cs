using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MoveBall : MonoBehaviour
{

    public float speed = 1;
    public Text scoreText;
    private int points = 0;
    private Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float movementHorizontal = Input.GetAxis("Horizontal");
        float movementVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movementHorizontal, 0.0f, movementVertical);

        rigidBody.AddForce(movement * speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision: " + collision.gameObject.name);
        if (collision.gameObject.name == "Point(Clone)")
        {
            points++;
            Debug.Log("Points: " + points);
            scoreText.text = "Score: " + points.ToString();
        }
    }
}
