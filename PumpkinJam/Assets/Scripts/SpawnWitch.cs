using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWitch : MonoBehaviour
{
    public GameObject witchPrefab;

    public bool yesSpawn;
    // Start is called before the first frame update
    void Start()
    {
        yesSpawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (yesSpawn)
        {
            StartCoroutine(Spawn());
            yesSpawn = false;
        }
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(2.5f);

        float rY = Random.Range(-10f, 10f);
        yesSpawn = true;

        GameObject witchInstance = Instantiate(witchPrefab, new Vector3(transform.position.x,rY,transform.position.z), Quaternion.identity);
    }
}
