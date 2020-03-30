using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began) 
            {
                Vector2 touch = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                RaycastHit2D hit = Physics2D.Raycast(touch, Input.GetTouch(0).position);
                Debug.Log(hit.collider.tag);
                if (hit.collider && hit.collider.tag == "Placeholder")
                {
                    transform.position = hit.transform.position;
                }
            }
        }
    }
}
