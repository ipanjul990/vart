using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class JsonWriteReadSystem : MonoBehaviour
{

    public InputField idInputField;
    public InputField commentInputField;

    public void SaveToJson()
    {
        WeaponData data = new WeaponData();
        data.Id =  idInputField.text;
        data.Comment =  commentInputField.text;
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath + "/WeaponDataFile.json", json);
    }

    public void LoadToJson()
    {
        string json = File.ReadAllText(Application.dataPath + "/WeaponDataFile.json");
        WeaponData data = JsonUtility.FromJson<WeaponData>(json);

        idInputField.text = data.Id;
        commentInputField.text = data.Comment;

    }
}
