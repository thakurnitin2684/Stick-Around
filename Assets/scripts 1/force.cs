
using UnityEngine;

public class force : MonoBehaviour
{

    public float speed2 = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed2 * Time.deltaTime);
    }
   
}