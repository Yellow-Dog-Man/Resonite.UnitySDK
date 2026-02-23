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
            if(_linkInterface != null)
            {
                if (_linkInterface.IsConnected)
                    return ConnectionState.Connected;
                else if (_connecting)
                    return ConnectionState.Connecting;
            }

            return ConnectionState.Disconnected;
        }
    }

    public string UniqueSessionId => _uniqueSessionId;

    public LinkInterface Link => _linkInterface;

    [SerializeField]
    SceneConverter _converter;

    string _lastConnectionError;
    LinkInterface _linkInterface;
    bool _connecting;

    string _resoniteVersion;
    string _resoniteLinkVersion;
    string _uniqueSessionId;

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

        GUI.enabled = true;

        if (GUILayout.Button("Start Realtime Mode"))
            StartRealtimeMode();

        GUILayout.Space(32);

        if (GUILayout.Button("Cleanup converters in the scene"))
            CleanupConverters();

        if (GUILayout.Button("Reset conversion state"))
            ResetConversionState();
    }

    void EnsureConverter()
    {
        if (_converter == null)
            _converter = new SceneConverter();

        _converter.EnsureInitialized(this);
    }

    void SendCurrentScene()
    {
        EnsureConverter();

        _converter.ConvertScene();
    }

    void StartRealtimeMode()
    {
        EnsureConverter();

        _converter.StartRealtimeMode();
    }

    void ConnectPressed()
    {
        _lastConnectionError = null;

        if (State == ConnectionState.Disconnected)
        {
            // Cleanup any previous interface if it exists
            _linkInterface?.Dispose();

            _resoniteLinkVersion = null;
            _resoniteVersion = null;
            _uniqueSessionId = null;

            _connecting = true;
            _linkInterface = new LinkInterface();

            Task.Run(async () =>
            {
                try
                {
                    await _linkInterface.Connect(new System.Uri($"ws://localhost:{Port}"), System.Threading.CancellationToken.None);

                    var sessionInfo = await _linkInterface.GetSessionData();

                    if (!sessionInfo.Success)
                        throw new System.Exception($"Error getting session info: {sessionInfo.ErrorInfo}");

                    _resoniteLinkVersion = sessionInfo.ResoniteLinkVersion;
                    _resoniteVersion = sessionInfo.ResoniteVersion;

                    _uniqueSessionId = sessionInfo.UniqueSessionId;
                }
                catch(System.Exception ex)
                {
                    _lastConnectionError = ex.Message;

                    // Cleanup
                    _linkInterface.Dispose();
                    _linkInterface = null;
                }
                finally
                {
                    _connecting = false;
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

    void CleanupConverters()
    {
        var roots = SceneManager.GetActiveScene().GetRootGameObjects();

        foreach (var root in roots)
            foreach (var converter in root.GetComponentsInChildren<ResoniteComponentConverter>())
                DestroyImmediate(converter);
    }

    void ResetConversionState()
    {
        _converter = null;
        EnsureConverter();
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
        ConnectionState.Connected => $"Connected on port {Port} (Resonite: {_resoniteVersion})"
    };
}
