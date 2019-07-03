using System.Collections;
using System.Collections.Generic;
using UnityEngine; //to use unity API
using UnityEngine.SceneManagement; //for loading scene
using System.IO;// for files

//manages all behavior
public class DataController : MonoBehaviour
{   //was public but now private
    private InstructionData[] allInstructionData; // size of the Instruction set // set to private because of json
    private string gameDataFileName = "data.json";
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        LoadGameData();//Loads Json
        SceneManager.LoadScene ("HUD");
    }

    public InstructionData GetCurrentInstructionData()
    {
        return allInstructionData[0];// eventually we can use this to determine other data types from the round
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
    void Update()
    {
        
    }
}
