using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToMainMenu : MonoBehaviour {

    [SerializeField] float LevelLoadDelay = 2f;

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        ScenePersist sp = FindObjectOfType<ScenePersist>();

        if (sp != null)
        {
            Destroy(sp.gameObject);
        }
        StartCoroutine(LoadMainMenu());
    }

    IEnumerator LoadMainMenu()
    {
        yield return new WaitForSecondsRealtime(LevelLoadDelay);

        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(0); // Load the Main Menu
    }
}
