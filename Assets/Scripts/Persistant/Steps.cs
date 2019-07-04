using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This is the String Text of a step 
/// ex. step 1 go to unity.com; step 2 click get started with unity
/// eventually we will want to add images
/// </summary>
[System.Serializable]
public class Steps 
{
    public string stepsText; //step instruction
    //to include and image with the JSON we can create a reference to a file that has the images in the JSON strinf and then access it when needed.
    public Sprite stepImg; //reminder that we want images with the step
    
}
