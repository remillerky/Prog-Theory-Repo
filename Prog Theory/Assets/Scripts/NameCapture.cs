using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameCapture : MonoBehaviour
{
    public InputField nameField;

    // Update is called once per frame
    void Update()
    {
        nameField.onValueChanged.AddListener(OnInputFieldValueChanged);
    }

    void OnInputFieldValueChanged(string nameField)
    {
        Debug.Log("Name text changed: " + nameField);
    }
}
