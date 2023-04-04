using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagers : MonoBehaviour
{
    //Open Page

    private void Start()
    {
        GetComponent<Scene>();
    }
    public void Buka_Learn()
    {
        SceneManager.LoadScene("Learn");
        Debug.Log("Learn");
    }
    public void Buka_Leaderboard()
    {
        SceneManager.LoadScene("Leaderboard");
        Debug.Log("Leaderboard");
    }
    public void Buka_Community()
    {
        SceneManager.LoadScene("Community");
        Debug.Log("Community");
    }

    public void Buka_Profile()
    {
        SceneManager.LoadScene("Profile");
        Debug.Log("Profile");
    }

    public void Buka_Settings()
    {
        SceneManager.LoadScene("Settings");
        Debug.Log("Settings");
    }

    public void Backto_Profile()
    {
        SceneManager.LoadScene("Profile");
        Debug.Log("Back to Profile");
    }

    //Learning Page to Topics
    public void Learn_TechBasic()
    {
        SceneManager.LoadScene("Learn_TechBasic");
        Debug.Log("Basic");
    }
    public void Learn_Hardware()
    {
        SceneManager.LoadScene("Learn_Hardware");
        Debug.Log("Hardware");
    }
    public void Learn_Software()
    {
        SceneManager.LoadScene("Learn_Software");
        Debug.Log("Software");
    }
    public void Learn_Network()
    {
        SceneManager.LoadScene("Learn_Network");
        Debug.Log("Network");
    }
    public void Learn_CSharp()
    {
        SceneManager.LoadScene("Learn_CSharp");
        Debug.Log("CSharp");
    }

    //Topics Page to Learn Topics
    public void Learn_What_is_Technology()
    {
        SceneManager.LoadScene("Learn_Topic_TechBasic");
        Debug.Log("What is Technology?");
    }

    public void Learn_Device()
    {
        SceneManager.LoadScene("Learn_Topic_Device");
        Debug.Log("Device?");
    }

    public void Learn_Introduce_Computer()
    {
        SceneManager.LoadScene("Learn_Topic_IntroComp");
        Debug.Log("Introduce Computer?");
    }

    public void Learn_Example()
    {
        SceneManager.LoadScene("Learn_Topic_Example");
        Debug.Log("Example Technology in IRL?");
    }

    //Topics -> Learning Topic
    public void Topic_LearningTopic()
    {
        SceneManager.LoadScene("Learn_TechBasic");
        Debug.Log("Example Technology in IRL?");
    }

    //Topics Back to Learning Topics Tech Basic
    public void WhatisTech_LearningTopics()
    {
        SceneManager.LoadScene("Learn_Topic_TechBasic");
        Debug.Log("Back from What is Tech Topics to Learning Topics?");
    }

    public void Device_LearningTopics()
    {
        SceneManager.LoadScene("Learn_Topic_Device");
        Debug.Log("Back from Device Topics to Learning Topics?");
    }

    public void IntroComp_LearningTopics()
    {
        SceneManager.LoadScene("Learn_Topic_IntroComp");
        Debug.Log("Back from Intro Computer Topics to Learning Topics?");
    }

    public void Example_LearningTopics()
    {
        SceneManager.LoadScene("Learn_Topic_Example");
        Debug.Log("Back from Example Topics to Learning Topics?");
    }

    //Learning Topics back to Learn Page
    public void Topics_to_Learn()
    {
        SceneManager.LoadScene("Learn");
        Debug.Log("Back to Learn");
    }

    public void
}
