using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{


    public Text instructionDisplayText; //
    
    //public Text timeDisplayText; //LATER
    public SimpleObjectPool stepButtonObjectPool; //
    public Transform stepButtonParent; //
    public GameObject instructionDisplay; //
    public GameObject roundEndDisplay; //gO bACK TO MAUN mENU

    private DataController dataController; //
    private InstructionData currentInstructionData; //
    private Instructions[] instructionPool; //

    private bool isRoundActive; // are steps active not used yet
    private float time; //LATER
    private int instructionIndex;//
    
    private List<GameObject> stepButtonGameObjects = new List<GameObject>();

    // Use this for initialization  
    // Start is called before the first frame update
    void Start()
    {
        
        dataController = FindObjectOfType<DataController>(); //its persistant so data controller will always be there
        currentInstructionData = dataController.GetCurrentInstructionData(); //which instruction are we on
        instructionPool = currentInstructionData.instructions; //store instruction in pool

        instructionIndex = 0;
        ShowInstruction();
        isRoundActive = true;

    }

    private void ShowInstruction()
    {
        RemoveStepButtons();
        Instructions instructions = instructionPool[instructionIndex];//had issues with types of classes
        instructionDisplayText.text = instructions.instructionText;//doesn't work
        for (int i = 0; i<instructions.steps.Length; i++)
        {
            GameObject stepButtonGameObject = stepButtonObjectPool.GetObject();//get another spawned button that is not beong used so we can set it up
            stepButtonGameObject.transform.SetParent(stepButtonParent); //parent button to panel so the go into vertical layout group
            stepButtonGameObjects.Add(stepButtonGameObject); //add prefab
            StepsText stepText = stepButtonGameObject.GetComponent<StepsText>(); //get referecne from script to gameobejcts and call Text component
            stepText.Setup(instructions.steps[i]);//what ever step we are settingup and it will display the correct answer/step //may need to come back to this// NA
        }
    }
    private void RemoveStepButtons() //remove any old steps and puts them back in pool
    {
        while (stepButtonGameObjects.Count> 0)
        {
            stepButtonObjectPool.ReturnObject(stepButtonGameObjects[0]); //send to objpool
            stepButtonGameObjects.RemoveAt(0);//remove from list of active
        }
    }
    public void ReturntoMenu()
    {
        SceneManager.LoadScene("HUD");
    }
    //not used yet
    public void EndTask()
    {
        isRoundActive = false;
        instructionDisplay.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
