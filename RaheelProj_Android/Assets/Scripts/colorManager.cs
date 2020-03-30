using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorManager : MonoBehaviour
{
    public List<string> color;
    public string curCol;
    // Start is called before the first frame update
    void Start()
    {
        color.Add("All");
        color.Add("RedBlock");
        color.Add("BlueBlock");
        color.Add("GreenBlock");
        curCol = color[0];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void All()
    {

        curCol = color[0];
    }
    public void Red()
    {

        curCol = color[1];
    }
    public void Blue()
    {

        curCol = color[2];
    }
    public void Green()
    {

        curCol = color[3];
    }
}
