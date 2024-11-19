using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerName;
    public void StartBtn()
    {
        SceneManager.LoadScene(1);
        if(playerName.text.Length > 0)
        {
            MainManager.Instance.PlayerName = playerName.text;
        }
        
    }
}
