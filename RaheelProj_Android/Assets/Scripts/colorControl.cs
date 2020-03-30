using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorControl : MonoBehaviour
{
    public GameObject colorManager;
    // Start is called before the first frame update
    void Start()
    {
        colorManager = GameObject.FindGameObjectWithTag("colorManager");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(colorManager.GetComponent<colorManager>().curCol);
        if (colorManager.GetComponent<colorManager>().curCol == "All")
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }

        else if (colorManager.GetComponent<colorManager>().curCol == gameObject.tag.ToString())
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;

        }
        
    }
}
