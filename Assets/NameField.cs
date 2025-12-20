using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameField : MonoBehaviour
{
    private static float _yPosition = 800f; 
    [SerializeField] private float yOffsetStep = 200f;

    public void RemoveNameField()
    {
        GameObject.FindGameObjectWithTag("InputField").GetComponent<InputField>().RemoveInputField();
        Destroy(gameObject);
    }

    
    public void MoveNameField()
    {
        foreach (var field in GameObject.FindGameObjectsWithTag("NameField"))
        {
            field.GetComponent<RectTransform>().anchoredPosition = new Vector2(0,_yPosition);
            _yPosition -= yOffsetStep;
        }
    }
}
