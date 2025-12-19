using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickAnimation : MonoBehaviour
{

    private Transform _buttonTransform;
    
    private void Start()
    {
        _buttonTransform = GetComponent<Transform>();
    }
    public void ButtonClick()
    {
        StartCoroutine(ButtonAnimation());
    }

    private IEnumerator ButtonAnimation()
    {
        for (var i = 0; i < 10; i++)
        {
            _buttonTransform.localScale = Vector3.Lerp(_buttonTransform.localScale, Vector3.zero, i/10f);
            yield return new WaitForSeconds(0.01f);
        }
        for (var i = 0; i < 10; i++)
        {
            _buttonTransform.localScale = Vector3.Lerp(_buttonTransform.localScale, Vector3.one, i/10f);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
