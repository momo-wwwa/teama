using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void Onclick()
    {
        //ここで移りたいシーンを指定します。
        SceneManager.LoadScene("Stage1");
    }
}