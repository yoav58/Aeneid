using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlanetCollider : MonoBehaviour
{
    public string name;
    bool inRange;
    public TMP_Text massageGuide;
    private string textGuide = "Press Enter to land";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return) && inRange) SceneManager.LoadScene(name);


    }


     void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("enter");
        inRange = true;
        massageGuide.text = textGuide;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        inRange = false;
        massageGuide.text = "";
    }

    
}
