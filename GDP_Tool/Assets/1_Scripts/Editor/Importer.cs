using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Elie.Patterns
{
    public class Importer : EditorWindow
    {
        string myString = "Hello World";
        bool groupEnabled;
        bool myBool = true;
        float myFloat = 1.23f;
        
        [MenuItem("Window/My Window")]
        static void Init()
        {
            // Get existing open window or if none, make a new one:
            Importer window = (Importer)EditorWindow.GetWindow(typeof(Importer));
            window.Show();
        }

        void OnGUI()
        {
            GUILayout.Label("Base Settings", EditorStyles.boldLabel);
            myString = EditorGUILayout.TextField("Text Field", myString);

            groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled);
            myBool = EditorGUILayout.Toggle("Toggle", myBool);
            myFloat = EditorGUILayout.Slider("Slider", myFloat, -3, 3);
            EditorGUILayout.EndToggleGroup();
        }

        private void CreateGDP(string _fileText)
        {
            GameDesignPattern assetGDP = ScriptableObject.CreateInstance<GameDesignPattern>();
            
            
            
            AssetDatabase.CreateAsset(assetGDP, "Assets/2_Objects/GDP/"+assetGDP.title+".asset");
            AssetDatabase.SaveAssets();
        }
    }
}
