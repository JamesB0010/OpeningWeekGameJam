using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject optionsMenu;
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider slider;
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volume");
    }

    void Update()
    {
        
    }

    private void StartGamePress()
    {

    }

    public void OptionsPress()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void QuitGamePress()
    {
#if UNITY_STANDALONE
        Application.Quit();
#endif
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    public void SetVolume(float volume)
    {
        Debug.Log("=" + volume);
        audioMixer.SetFloat("volume", volume);
        PlayerPrefs.SetFloat("volume", volume);
        Debug.Log(PlayerPrefs.GetFloat("volume"));
    }
}
