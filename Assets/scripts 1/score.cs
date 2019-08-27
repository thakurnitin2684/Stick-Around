using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour {
    public Text scoretext;

	
	// Update is called once per frame
	void Update () {
        scoretext.text = FindObjectOfType<playermovement>().count.ToString();
	}
}
