using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour
{
    public void ClickStartButton()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();

        Invoke("Next", 0.8f);
    }
    public void Next()
    {
        //�����ňڂ肽���V�[�����w�肵�܂��B
        SceneManager.LoadScene("SampleScene");
    }
}