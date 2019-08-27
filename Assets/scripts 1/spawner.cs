
using UnityEngine;

public class spawner : MonoBehaviour {
    public Transform[] spawnpoints;
    public GameObject[] wallprefab;
    private float timetospawn = 1f;
    public float timebetweenwaves = 1f;
    bool flag = true;
    // Use this for initialization
    void Update () {
       if( Time.time >= timetospawn)
        {
            spawnblocks();
            timetospawn = Time.time + timebetweenwaves;
        }
        

    }
    void spawnblocks()
    {
       
        if (flag == true)
        {
            int ran1 = Random.Range(0, 3);
            Instantiate(wallprefab[ran1], spawnpoints[0].position, Quaternion.identity);
            flag = false;
        }
        else
        {
            int ran2 = Random.Range(0, 3);
            Instantiate(wallprefab[ran2], spawnpoints[1].position, Quaternion.identity);
            flag = true;
        }
    }

}
