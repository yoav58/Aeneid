using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving: MonoBehaviour
{
    public GameObject flySpacship;
    public float speed = 5.0f;
    public Vector3 foward = new Vector3(0, 0, 0);
    public Vector3 down = new Vector3(0, 0, 180);
    private Vector3 left = new Vector3(0, 0, 90);
    private Vector3 right = new Vector3(0, 0, 270);
    public Transform tf;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveUp();
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            moveDown();
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveLeft();
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            moveRight();
        }
        else flySpacship.SetActive(false);
    }

    private void moveUp()
    {
        tf.rotation = Quaternion.Euler(foward);
        tf.position = new Vector3(tf.position.x, tf.position.y + speed * Time.deltaTime, tf.position.z);
        flySpacship.SetActive(true);
    }

    private void moveDown()
    {
        tf.rotation = Quaternion.Euler(down);
        tf.position = new Vector3(tf.position.x, tf.position.y - speed * Time.deltaTime, tf.position.z);
        flySpacship.SetActive(true);
    }

    private void moveLeft()
    {
        tf.rotation = Quaternion.Euler(left);
        tf.position = new Vector3(tf.position.x - speed * Time.deltaTime, tf.position.y, tf.position.z);
        flySpacship.SetActive(true);
    }

    private void moveRight()
    {
        tf.rotation = Quaternion.Euler(right);
        tf.position = new Vector3(tf.position.x + speed * Time.deltaTime, tf.position.y, tf.position.z);
        flySpacship.SetActive(true);
    }
}
