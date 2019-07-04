using System.Collections;
using System.Collections.Generic;
using UnityEngine; //to use unity API
using UnityEngine.SceneManagement; //for loading scene
using System.IO;// for files
/// <summary>
/// main purpose is to supply the instruction Data when we access scene
/// </summary>
//manages all behavior
public class DataController : MonoBehaviour
{   //was public but now private, if you want variables visible to the editor make public
    private InstructionData[] allInstructionData; // size of the Instruction set // set to private because of json
    private string gameDataFileName = "data.json";
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        LoadGameData();//Loads Json
        SceneManager.LoadScene ("HUD");
    }

    public InstructionData GetCurrentInstructionData()//return the first set of the current round/ie loads instructiondata array
    {
        return allInstructionData[0];
    }
    private void LoadGameData()
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, gameDataFileName); //where the JSON is
        if (File.Exists(filePath))
            {
            string dataAsJson = File.ReadAllText(filePath); //read file store it as a string
            GameData loadedData = JsonUtility.FromJson<GameData>(dataAsJson);//take string, deserialize it into a GameData object

            allInstructionData = loadedData.allInstructionData; //make it available to use in the game (see datacontroller and gamedata; same variable)
        }
        else
        {
            Debug.LogError("Cannot load Game data");
        }
    }
    // Update is called once per frame
    
}
