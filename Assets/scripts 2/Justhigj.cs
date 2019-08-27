using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Justhigj : MonoBehaviour
{
  //  public Text scoretext2;
    public Text highscore;
    public GameObject newscoreui;
    bool onlyonce;

    void Start()
    {
        if (onlyonce == true)
        {
            newscoreui.SetActive(true);
            onlyonce = false;
        }
        highscore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
    }
    // Update is called once per frame
    void Update()
    {

       // scoretext2.text = FindObjectOfType<playermovement>().count.ToString();
        if (FindObjectOfType<playermovement>().count > PlayerPrefs.GetInt("highscore", 0))
        {
            onlyonce = true; newscoreui.SetActive(true);

            PlayerPrefs.SetInt("highscore", FindObjectOfType<playermovement>().count);
            highscore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
        }

    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }
}
