using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldMovMent : MonoBehaviour
{
    [SerializeField]
    public Transform moneyPlace;
    [SerializeField]
    public float addedMax;
    [SerializeField]
    public float addedMin;
    [SerializeField]
    float  speed;
    bool goUp;
    private float max;
    private float min;
    // Start is called before the first frame update

    private void Awake()
    {
        max = transform.localPosition.y + addedMax;
        min = transform.localPosition.y - addedMin;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (moneyPlace.position.y >= max) moveDouwn(speed);
        else if (moneyPlace.position.y <= min) moveUp(speed);
        else move();

    }



    private void moveUp(float speed)
    {
        goUp = true;
        moneyPlace.position = new Vector3(moneyPlace.position.x, moneyPlace.position.y + speed * Time.deltaTime);
    }
    private void moveDouwn(float speed)
    {
        goUp = false;
        moneyPlace.position = new Vector3(moneyPlace.position.x, moneyPlace.position.y - speed * Time.deltaTime);

    }

    private void move()
    {
        if (goUp) moveUp(speed);
        else moveDouwn(speed);
    }
}
