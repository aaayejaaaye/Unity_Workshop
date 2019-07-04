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
            SerializedObject serializedObject = new SerializedObject(this); //this = GmaeDataEditor
            SerializedProperty serializedProperty = serializedObject.FindProperty("gameData"); // search through serialized object "gameData"
            EditorGUILayout.PropertyField(serializedProperty, true); //pass in serialized proerty to display children 

            serializedObject.ApplyModifiedProperties(); //incase user has changed anything update object

            if (GUILayout.Button("Save data"))
            {
                SaveGameData();
            }
        }

        if (GUILayout.Button("Load data"))
        {
            LoadGameData();
        }
    }

    private void LoadGameData()
    {
        string filePath = Application.dataPath + gameDataProjectFilePath; //

        if (File.Exists(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath); //read/convert as JSON 
            gameData = JsonUtility.FromJson<GameData>(dataAsJson); //Place into gamedata object
        }
        else
        {
            gameData = new GameData();
        }
    }

    private void SaveGameData()
    {

        string dataAsJson = JsonUtility.ToJson(gameData);//serializee form JSON store as string

        string filePath = Application.dataPath + gameDataProjectFilePath;
        File.WriteAllText(filePath, dataAsJson);//loads or overites

    }
}
