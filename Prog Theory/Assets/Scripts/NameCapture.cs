using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameCapture : MonoBehaviour
{
    public InputField nameField;
    
    // Start is called before the first frame update
    void Start()
    {
        nameField.onValueChanged.AddListener(OnInputFieldValueChanged);
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    void OnInputFieldValueChanged(string nameField)
    {
        Debug.Log("Name text changed: " + nameField);
    }
}
