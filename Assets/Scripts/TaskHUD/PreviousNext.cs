using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviousNext : MonoBehaviour
{
    GameController gc;
    public GameObject ps;
    public GameObject ns;
    
    // Start is called before the first frame update
    void Start()
    {
        ps = GameObject.Find("TaskHUDController");
        ps.GetComponent<GameController>();
    }
    public void getStepMethods()
    {
        
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
