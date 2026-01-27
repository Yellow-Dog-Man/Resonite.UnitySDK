//#define LOG_ONLY

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using ResoniteLink;
using System.Threading.Tasks;
using System.Threading;

public class BindingGeneratorTest : ScriptableWizard
{
    public const string PROGRESS_BAR_TITLE = "Generating bindings";

    public int Port = 9000;

    [MenuItem("Resonite SDK/Generate Bindings (Test)")]
    static void CreateWizard()
    {
        ScriptableWizard.DisplayWizard<BindingGeneratorTest>("Generate Bindings", "Generate");
    }

    void OnWizardCreate()
    {
#if !LOG_ONLY
        using var progress = new ProgressSynchronizer();
#else
        var progress = new ProgressSynchronizer();
#endif

        var cancellation = new CancellationTokenSource();

#if !LOG_ONLY
        EditorUtility.DisplayCancelableProgressBar(PROGRESS_BAR_TITLE, "Generating bindings", 0f);
#endif

        Task.Run(async () =>
        {
            try
            {
                Debug.Log($"Connecting to port {Port}...");

                var link = new ResoniteLink.LinkInterface();
                await link.Connect(new System.Uri("ws://localhost:" + Port), cancellation.Token);

                Debug.Log($"Connected to port {Port}");

                var generator = new ResoniteBindingGenerator(link, cancellation.Token, progress);

                await generator.GenerateBindings();
                //await generator.GenerateComponentBindingsForCategory("Uncategorized");
                //await generator.GenerateComponentBinding("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.AsyncDynamicImpulseReceiver");

                Debug.Log("Binding generation complete");
            }
            catch(System.Exception ex)
            {
                Debug.LogError(ex);
            }
        });

#if !LOG_ONLY
        do
        {
            progress.WaitForProgress();

            if(EditorUtility.DisplayCancelableProgressBar(PROGRESS_BAR_TITLE, progress.Info, progress.Progress))
            {
                EditorUtility.DisplayCancelableProgressBar(PROGRESS_BAR_TITLE, "Cancelling...", 0f);
                Debug.Log("Cancelling bindings generation...");
                cancellation.Cancel();
                break;
            }
        } while (!progress.Done);

        EditorUtility.ClearProgressBar();
#else
        Task.Run(() =>
        {
            do
            {
                progress.WaitForProgress();
                Debug.Log(progress.Info);
            } while (!progress.Done);

            Debug.Log("DONE!");

            progress.Dispose();
        });
#endif
    }
}
