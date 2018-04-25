using System;
using UnityEditor;
using UnityEngine;
using WebSocketSharp;
namespace WebSocketSharp.Unity.Editor
{
    public class MenuExtension : MonoBehaviour

    {
        WebSocket ws;
        String ip = "ws://10.9.80.255:8000/Handler";
        public void Start()
        {
            ws = new WebSocket(ip);
        ws.OnOpen += (sender, e) =>
                ws.Send(String.Format("Hello, Unity"));
            ws.OnMessage += (sender, e) =>
            Handler(e.Data);
            ws.OnError += (sender, e) =>
            Debug.LogError(e.Message);
            ws.Connect();

        }
        public void send(string msg)
        {


            ws.Send(msg);
        }


        public void Handler(string msg)
        {


            Debug.Log("WSMessage: " + msg);
        }

        
    }
}