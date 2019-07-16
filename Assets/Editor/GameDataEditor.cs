using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;//Acess editor Window
using System.IO;// works with files
/// <summary>
/// 
/// </summary>
public class GameDataEditor : EditorWindow 
{
    public GameData gameData; //holds JSON info
    private string gameDataProjectFilePath = "/StreamingAssets/data.json"; //json file path

    [MenuItem("Window/Game Data Editor")] //create a menu item attribute(GUI)
    static void Init()
    {
        EditorWindow.GetWindow(typeof(GameDataEditor)).Show(); //


    }

    void OnGUI()//similar to update
    {
        if (gameData != null) //is data loaded?
        {
            SerializedObject serializedObject = new SerializedObject(this); //this = GameDataEditor
            SerializedProperty serializedProperty = serializedObject.FindProperty("gameData"); // search through serialized object "gameData"
            EditorGUILayout.PropertyField(serializedProperty, true); //pass in serialized proerty to display children 

            serializedObject.ApplyModifiedProperties(); //incase user has changed anything update object

            if (GUILayout.Button("Save data"))
            {
                // SaveGameData();
                SaveGameDataNew();
            }
        }

        if (GUILayout.Button("Load data"))
        {
            // LoadGameData();
            LoadGameDataNew();
        }
        if (GUILayout.Button("Create New"))
        {
            CreateNewDataNew();
        }
    }

    private void LoadGameData()// see also in datacontroler.cs(similar)
    {
        string filePath = Application.dataPath + gameDataProjectFilePath; //

        if (File.Exists(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath); //read/convert a JSON 
            gameData = JsonUtility.FromJson<GameData>(dataAsJson); //Place into gamedata object
        }
        else
        {
            gameData = new GameData();
        }
    }

    private void LoadGameDataNew()
    {
        string filePath = EditorUtility.OpenFilePanel("Select localization data file", Application.streamingAssetsPath, "json");

        if (!string.IsNullOrEmpty(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath);

            gameData = JsonUtility.FromJson<GameData>(dataAsJson);
        }
    }

    private void SaveGameData()
    {

        string dataAsJson = JsonUtility.ToJson(gameData);//serializee from gd to JSON store as string

        string filePath = Application.dataPath + gameDataProjectFilePath;
        File.WriteAllText(filePath, dataAsJson);//loads or overites; writes to filePath 

    }


    private void SaveGameDataNew()
    {
        string filePath = EditorUtility.SaveFilePanel("Save localization data file", Application.streamingAssetsPath, "", "json");

        if (!string.IsNullOrEmpty(filePath))
        {
            string dataAsJson = JsonUtility.ToJson(gameData);
            File.WriteAllText(filePath, dataAsJson);
        }
    }

    private void CreateNewDataNew()
    {
        gameData = new GameData();
    }

}
