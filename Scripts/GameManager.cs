using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject _startmenu;
    [SerializeField] TextMeshProUGUI _levelText;
    [SerializeField] GameObject _finishWindow;
    [SerializeField] Coinsmanager _coinsmanager;

    public bool _isFinished = false;
    public void Play()
    {
        _startmenu.SetActive(false);
        FindAnyObjectByType<PlayBehavior>().Play();
        _isFinished = true;
    }
    void Start()
    {
        _levelText.text = SceneManager.GetActiveScene().name;
    }
    public void ShowFinishShow()
    {
        _finishWindow.SetActive(true);
    }
    public void NextLevel()
    {
        int next = SceneManager.GetActiveScene().buildIndex + 1;
        if (next < SceneManager.sceneCountInBuildSettings) 
        { 
            _coinsmanager.SaveToProgress();
            SceneManager.LoadScene(next); 
        }        
    }
}
