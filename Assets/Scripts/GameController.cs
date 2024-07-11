using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    private Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] spheres = GameObject.FindGameObjectsWithTag("Sphere");

        if(spheres.Length == 0)
        {
            canvas.enabled = true;
            Time.timeScale = 0;
        }
    }
}
