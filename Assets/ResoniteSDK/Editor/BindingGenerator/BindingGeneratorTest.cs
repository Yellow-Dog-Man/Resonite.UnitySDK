using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using ResoniteLink;
using System.Threading.Tasks;

public class BindingGeneratorTest : ScriptableWizard
{
    public int Port = 0;

    [MenuItem("Resonite SDK/Generate Bindings (Test)")]
    static void CreateWizard()
    {
        ScriptableWizard.DisplayWizard<BindingGeneratorTest>("Generate Bindings", "Generate");
    }

    void OnWizardCreate()
    {
        Task.Run(async () =>
        {
            try
            {
                Debug.Log($"Connecting to port {Port}...");

                var link = new ResoniteLink.LinkInterface();
                await link.Connect(new System.Uri("ws://localhost:" + Port), System.Threading.CancellationToken.None);

                Debug.Log($"Connected to port {Port}");

                var generator = new ResoniteBindingGenerator(link);

                await generator.GenerateBindings();
            }
            catch(System.Exception ex)
            {
                Debug.LogError(ex);
            }
        });
    }
}
