using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform transform;

    public float speed = 5f;

    public float rotationSpeed = 5f;

    public Score scoreValue;

    bool isMovingLeft = false;

    bool isMovingRight = false;

    public GameObject gameOverPanel;


    // Start is called before the first frame update

    void Start()

    {
        gameOverPanel.SetActive(false);
        Time.timeScale = 1;
    }


    // Update is called once per frame

    void Update()

    {


        if (Input.GetKey(KeyCode.RightArrow))

        {

            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 70), rotationSpeed * Time.deltaTime);

        }


        if (Input.GetKey(KeyCode.LeftArrow))

        {

            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 110), rotationSpeed * Time.deltaTime);

        }

        if (transform.rotation.z != 110 && transform.rotation.z != 70)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 90), 10f * Time.deltaTime);
        }

        if (transform.position.x < -2.65f)
        {
            transform.position = new Vector3(-2.65f, transform.position.y, transform.position.z);
        }

        if (transform.position.x > 2.65f)
        {
            transform.position = new Vector3(2.65f, transform.position.y, transform.position.z);
        }

    }


    void MoveLeft()

    {

        transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 47), rotationSpeed * Time.deltaTime);

    }



    void MoveRight()

    {

        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, -47), rotationSpeed * Time.deltaTime);

    }



    public void MovingLeft(bool i)

    {

        isMovingLeft = i;

    }



    public void MovingRight(bool i)

    {

        isMovingRight = i;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cars")
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }

        if (collision.gameObject.tag == "Coin")
        {
            scoreValue.score += 10;
            Destroy(collision.gameObject);
        }

    }

}
