using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StepsText : MonoBehaviour
{
    public Text stepText;

    private Steps stepData;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
     public void Setup(Steps data)
    {
        stepData = data;
        stepText.text = stepData.stepsText;
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
