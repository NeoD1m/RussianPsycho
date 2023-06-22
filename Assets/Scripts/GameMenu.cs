using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    public GameObject menu;
    public GameObject slider;
    public AudioSource music;
    bool isMenuOpen = false;
    void ToggleMenu()
    {
        isMenuOpen = !isMenuOpen;

        menu.SetActive(isMenuOpen);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape key was pressed");
            ToggleMenu();
        }

        music.volume = slider.GetComponent<Slider>().value;
    }
}
