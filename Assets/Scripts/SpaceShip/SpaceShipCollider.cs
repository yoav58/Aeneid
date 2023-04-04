using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class SpaceShipCollider : MonoBehaviour
{
    public GameObject mark;
    public TMP_Text massageGuide;
    bool isInRange = false;
    public StatesSaver sl;
    public ItemsSaver itemSaver;
    public string SceneName;

    public SaverAllScript saver;
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
                sl.SaveGame();
                itemSaver.saveItems();
                saveSpaceLocation();
                saver.save();
                SceneManager.LoadScene("Space");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            mark.SetActive(true);
            massageGuide.text = "Press Enter to get in spaceship";
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

    public void saveSpaceLocation()
    {
        PlayerPrefs.SetInt(SceneName,1);
    }

}
