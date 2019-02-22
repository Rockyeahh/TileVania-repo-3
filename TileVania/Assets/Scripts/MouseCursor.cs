using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MouseCursor : MonoBehaviour {

    void Awake()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("01a_Main_Menu"))
        {
            Cursor.visible = true;
        }
        else { Cursor.visible = false; }
    }
}
