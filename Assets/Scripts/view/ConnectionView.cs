﻿using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ConnectionView : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI txtServerIP;
    [SerializeField]
    private TextMeshProUGUI txtServerPort;
    [SerializeField]
    private TextMeshProUGUI txtServerPassword;
    [SerializeField]
    private TextMeshProUGUI btnConnectText;

    [SerializeField]
    private Button btnConnect;

    public delegate void OnConnectionView(string ip, string port, string password);
    public static OnConnectionView OnConnect;

    // Start is called before the first frame update
    void Start()
    {
        txtServerIP.text = PlayerPrefs.GetString(ObsDeck.LAST_IP_KEY, "127.0.0.1"); ;
        txtServerPort.text = PlayerPrefs.GetString(ObsDeck.LAST_PORT_KEY, "4444"); ;
        btnConnect.onClick.AddListener(OnConnectClick);
    }

    private void OnConnectClick()
    {
        OnConnect(txtServerIP.text, txtServerPort.text, txtServerPassword.text);
    }
}