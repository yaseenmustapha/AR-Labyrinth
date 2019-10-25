using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    [SerializeField]
    private Text dataText, winText, deathText, restartText;
    private GameObject level;
    [SerializeField]
    AudioClip winClip, loseClip;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start() {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {
        if (level == null)
            level = GameObject.FindWithTag("Level");
        else {
            Vector3 levelRot = level.transform.eulerAngles;
            dataText.text = string.Format(
                "Rotation data:\nX: {0}°\nY: {1}°\nZ: {2}°",
                levelRot.x,
                levelRot.y,
                levelRot.z);
        }
    }

    public void OnDeath() {
        deathText.gameObject.SetActive(true);
        restartText.gameObject.SetActive(true);
        audioSource.clip = loseClip;
        audioSource.Play();
    }

    public void OnWin() {
        winText.gameObject.SetActive(true);
        audioSource.clip = winClip;
        audioSource.Play();
    }
}
