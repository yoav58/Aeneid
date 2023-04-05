using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransportCollider : MonoBehaviour
{
    public bool usingMark;
    public GameObject mark;
    public TMP_Text massageGuide;
    public string textGuide;
    bool isInRange = false;
    public SaverAllScript sl;

    public string SceneName;
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
                if(sl != null)sl.save();
                SceneManager.LoadScene(SceneName);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (usingMark) mark.SetActive(true);
            massageGuide.text = textGuide;
            isInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(usingMark) mark.SetActive(false);
            massageGuide.text = "";
            isInRange = false;
        }
    }
}
