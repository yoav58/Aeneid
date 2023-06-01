using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuideCanvas : MonoBehaviour
{

    private int clickNumber;

    public GameObject firstGuide;

    public GameObject secondGuide;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ContinueButton()
    {
        if (clickNumber == 1) SceneManager.LoadScene("FirensPlanetScene");
        firstGuide.SetActive(false);
        secondGuide.SetActive(true);
        clickNumber++;
    }
}
