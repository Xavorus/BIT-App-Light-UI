using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Materi : MonoBehaviour
{
    //1
    public GameObject Matery1;
    //2
    public GameObject Matery2;
    //3
    public GameObject Matery3;
    //4
    public GameObject Matery4;
    //5
    public GameObject Matery5;
    //6
    public GameObject Matery6;
    //7
    public GameObject Matery7;
    //8
    public GameObject Matery8;
    //9
    public GameObject Matery9;
    //10
    public GameObject Matery10;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    //Learn Topics Tech Basic
    public void ActiveM2()
    {
        Matery1.SetActive(false);
        Matery2.SetActive(true);
    }

    public void ActiveM3()
    {
        Matery2.SetActive(false);
        Matery3.SetActive(true);
    }

    public void ActiveM4()
    {
        Matery3.SetActive(false);
        Matery4.SetActive(true);
    }

    public void ActiveM5()
    {
        Matery4.SetActive(false);
        Matery5.SetActive(true);
    }

    public void ActiveM6()
    {
        Matery5.SetActive(false);
        Matery6.SetActive(true);
    }

    public void ActiveM7()
    {
        Matery6.SetActive(false);
        Matery7.SetActive(true);
    }

    public void ActiveM8()
    {
        Matery7.SetActive(false);
        Matery8.SetActive(true);
    }

    public void ActiveM9()
    {
        Matery8.SetActive(false);
        Matery9.SetActive(true);
    }

    public void ActiveM10()
    {
        Matery9.SetActive(false);
        Matery10.SetActive(true);
    }

    public void backtoLearnTopics()
    {
        SceneManager.LoadScene("Learn_TechBasic");
    }
}
