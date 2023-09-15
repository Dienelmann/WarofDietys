using UnityEngine;
using System;
using UnityEditor.UIElements;
using UnityEngine.UI;
using static UnityEngine.UI.Text;

public class OfflineProgress : MonoBehaviour
{
    public Text Exp;
    public Text time;
    public bool Startscreen;
    
    void Start()
    {
        if (PlayerPrefs.HasKey("Last_Login"))
        {
            DateTime lastLogin = DateTime.Parse(PlayerPrefs.GetString("Last_Login"));

            TimeSpan timeSpan = DateTime.Now - lastLogin;
            
            time.text = String.Format("{0} Days {1} Hours {2} Minutes {3} seconds", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);

            Exp.text = (int)timeSpan.TotalMinutes + ("Exp");
        }
        else
        {
            time.text = "Welcome to War of Dietys";
            Exp.text = " ";
        } 
        
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetString("Last_Login", DateTime.Now.ToString());
    }

    /*private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Startscreen = true;
        }
    }*/
}
