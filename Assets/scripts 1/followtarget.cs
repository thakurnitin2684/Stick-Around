
using UnityEngine;

public class followtarget : MonoBehaviour {

    public Transform target;
    void Update()
    {
        if(target.position.y>transform.position.y)
        {
           
            transform.position = new Vector3(transform.position.x, transform.position.y, -10f);
        }
    }
}
