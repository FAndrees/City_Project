
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public UnityEngine.UI.InputField InputField;
    public float alpha;
    public GameObject Canvas;
    public CanvasGroup canvasGroup;
    private void Start()
    {
        Canvas.GetComponent<CanvasGroup>();

    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            canvasGroup.alpha = 0;
            InputField.interactable = false;
            return;
        }

    }
}