using System.Collections;
using UnityEngine;

public class destroy : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        if(transform.position.y < -8f)
        {
            Destroy(gameObject);
        }
		
	}
}
