using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Scripting.Python;

[CustomEditor(typeof(Python_Manager))]
public class Python_Manager_Editor : Editor
{
    Python_Manager target_manager;

    private void OnEnable()
    {
        target_manager = (Python_Manager)target;
    }

    public override void OnInspectorGUI()
    {
        if(GUILayout.Button("Launch Python Script", GUILayout.Height(35)))
        {
            string path = Application.dataPath + "/Python/log_names.py" ;
            PythonRunner.RunFile(path);
            //Debug.Log(path);
            //Debug.Log("This is Working!");
        }
    }

}
