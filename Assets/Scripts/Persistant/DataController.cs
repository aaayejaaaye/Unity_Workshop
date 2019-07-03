using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//manages all behavior
public class DataController : MonoBehaviour
{
    public InstructionData[] allInstructionData; // size of the Instruction set
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene ("HUD");
    }

    public InstructionData GetCurrentInstructionData()
    {
        return allInstructionData[0];// eventually we can use this to determine other data types from the round
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
