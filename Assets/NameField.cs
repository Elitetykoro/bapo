using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NameField : MonoBehaviour
{
    [SerializeField] private GameObject nameInputFieldPrefab;
    [SerializeField] private float yOffsetStep = 200f;
    private static float _yOffset;
    private static int _playerIndex;
    
    private void Start()
    {
        _playerIndex = 0;
        _yOffset = 0f;
    }

    public void OnNameEnter(string playerName)
    {
        
        PlayerPrefs.SetString(("PlayerName"+_playerIndex), playerName);
        _playerIndex++;
        _yOffset -= yOffsetStep;
        var field = Instantiate(nameInputFieldPrefab, transform);
        var rect = field.GetComponent<RectTransform>();
        rect.anchoredPosition = new Vector2(0, _yOffset);
    }
}
