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
    public Text gold;
    
    
    void Start()
    {
        if (PlayerPrefs.HasKey("Last_Login"))
        {
            DateTime lastLogin = DateTime.Parse(PlayerPrefs.GetString("Last_Login"));

            TimeSpan timeSpan = DateTime.Now - lastLogin;
            
            time.text = String.Format("You were Offline for : " + "{0} Days {1} Hours {2} Minutes {3} seconds", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);

            Exp.text = (float)timeSpan.TotalMinutes + ("Exp");
            
            gold.text = (float)timeSpan.TotalMinutes + ("Gold");
        }
        else
        {
            time.text = "Welcome to War of Dietys";
            Exp.text = " ";
            gold.text = " ";
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
