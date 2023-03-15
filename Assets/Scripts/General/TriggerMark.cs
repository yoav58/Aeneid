using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;


// this is a general file for trigger.

public class TriggerMark : MonoBehaviour
{
    public GameObject mark;
    public TMP_Text massageGuide;
    public string message;
    bool isInRange = false;

    [SerializeField] private UnityEvent pressedEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            if(isInRange)
            {
                pressedEvent.Invoke();
            }
        }
    }
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            mark.SetActive(true);
            massageGuide.text = message;
            isInRange = true;
        }
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            mark.SetActive(false);
            massageGuide.text = "";
            isInRange = false;
        }
    }
    
    
    
}
