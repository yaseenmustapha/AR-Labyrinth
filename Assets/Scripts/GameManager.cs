using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    UIManager uiManager;
    private bool gameOver = false;
    // Start is called before the first frame update
    void Start() {
        uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    public void FailLevel() {
        if (!gameOver) {
            uiManager.OnDeath();
            StartCoroutine(RestartRoutine());
        }
    }

    IEnumerator RestartRoutine() {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene(0);
    }

    public void CompleteLevel() {
        if (!gameOver) {
            uiManager.OnWin();
            gameOver = true;
        }
    }
}
