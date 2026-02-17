using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using ResoniteLink;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using System.Linq;

public class ResoniteLinkWindow : EditorWindow
{
    public enum ConnectionState
    {
        Disconnected,
        Connecting,
        Connected,
    }

    public int Port;

    public ConnectionState State
    {
        get
        {
            if (_linkInterface == null)
                return ConnectionState.Disconnected;
            else if (_linkInterface.IsConnected)
                return ConnectionState.Connected;
            else
                return ConnectionState.Connecting;
        }
    }

    [SerializeField]
    SceneConverter _converter;

    string _lastConnectionError;
    LinkInterface _linkInterface;

    [MenuItem("Resonite SDK/Open Resonite SDK Manager")]
    public static void ShowWindow()
    {
        ResoniteLinkWindow window = GetWindow<ResoniteLinkWindow>();
        window.titleContent = new GUIContent("Resonite SDK");
    }

    void OnGUI()
    {
        GUI.enabled = State == ConnectionState.Disconnected;
        Port = EditorGUILayout.IntField("Port: ", Port);

        GUI.enabled = State != ConnectionState.Connecting;

        if (GUILayout.Button(ConnectButtonLabel))
            ConnectPressed();

        GUI.enabled = true;
        EditorGUILayout.LabelField($"ResoniteLinkStatus: ", StatusLabel);

        if (!string.IsNullOrEmpty(_lastConnectionError))
            GUILayout.Label($"ERROR: {_lastConnectionError}");

        GUILayout.Space(16);

        GUI.enabled = State == ConnectionState.Connected;

        if (GUILayout.Button("Send Current Scene"))
            SendCurrentScene(); 
    }

    void SendCurrentScene()
    {
        if(_converter == null)
            _converter = new SceneConverter();

        // TODO!!! Better wrap this around?
        _converter.EnsureAssetConverter();

        var roots = SceneManager.GetActiveScene().GetRootGameObjects();

        _converter.Convert(roots.Select(g => g.transform), _linkInterface);
    }

    void ConnectPressed()
    {
        _lastConnectionError = null;

        if (State == ConnectionState.Disconnected)
        {
            _linkInterface = new LinkInterface();
            Task.Run(async () =>
            {
                try
                {
                    await _linkInterface.Connect(new System.Uri($"ws://localhost:{Port}"), System.Threading.CancellationToken.None);
                }
                catch(System.Exception ex)
                {
                    _lastConnectionError = ex.Message;
                }
            });
        }
        else
        {
            var __linkInterface = _linkInterface;
            _linkInterface = null;

            Task.Run(async () =>
            {
                __linkInterface.Dispose();
            });
        }
    }

    string ConnectButtonLabel => State switch
    {
        ConnectionState.Disconnected => "Connect",
        ConnectionState.Connecting => "Connecting...",
        ConnectionState.Connected => "Disconnect",
    };

    string StatusLabel => State switch
    {
        ConnectionState.Disconnected => "Disconnected",
        ConnectionState.Connecting => $"Connecting to port {Port}...",
        ConnectionState.Connected => $"Connected on port {Port}"
    };
}
