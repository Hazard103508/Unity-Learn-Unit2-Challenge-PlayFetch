using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float time = 0;
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (time >= 1)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                time = 0;
            }
        }
    }
}
