using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelButton : MonoBehaviour
{
    private void Start() {
        // check next scene kalau tidak ada. sembuyiin button ini
        var currentScene = SceneManager.GetActiveScene();
        int currentLevel = int.Parse(currentScene.name.Split("Level ")[1]);
        int nextLevel = currentLevel + 1;
        var nextScene = SceneManager.GetSceneByName("Level "+nextLevel);
        if(nextScene == null)
            this.gameObject.SetActive(false);
    }
}
