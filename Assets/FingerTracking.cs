using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FingerTracking : MonoBehaviour
{
    [System.Serializable]
    public class InputData
    {
        public int[] flexion;
        public int joyX;
        public int joyY;
        public bool joyClick;
        public bool triggerButton;
        public bool aButton;
        public bool bButton;
        public bool grab;
        public bool pinch;
        public bool calib;
        public bool menu;
    }

    public string jsonFilePath = "Assets/Resources/fingerData.json";
    private InputData inputData;

    void Start()
    {
        LoadJson();
    }

    void Update()
    {
        // Use the data from inputData to update finger positions
        TrackFingers();
    }

    void LoadJson()
    {
        string jsonData = File.ReadAllText(jsonFilePath);
        inputData = JsonUtility.FromJson<InputData>(jsonData);
    }

    void TrackFingers()
    {
        if (inputData != null)
        {
            // Example usage: Log flexion values for each finger
            for (int i = 0; i < inputData.flexion.Length; i++)
            {
                Debug.Log("Finger " + i + " flexion: " + inputData.flexion[i]);
            }

            // Additional processing can be added here to map flexion values to finger movements in Unity
        }
    }
}
