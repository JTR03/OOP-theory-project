using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerName;
    // Start is called before the first frame update
    void Start()
    {
        playerName.text = $"Player: {MainManager.Instance.PlayerName}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
