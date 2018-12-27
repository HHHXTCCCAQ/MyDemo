using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class UISelect : MonoBehaviour
{

    private Button but_UpSelect;
    private Button but_DownSelect;
    private Button but_Submit;
    // Use this for initialization
    void Start()
    {
        but_UpSelect = transform.Find("but_UpSelect/").GetComponent<Button>();
        but_DownSelect = transform.Find("but_DownSelect/").GetComponent<Button>();
        but_Submit = transform.Find("but_Submit/").GetComponent<Button>();
        but_Submit.onClick.AddListener(SubmitBut);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SubmitBut()
    {
        ChangeScene(Config.SceneName);
    }

    void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}