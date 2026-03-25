using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public class ResoniteAvatarSetupWizard : EditorWindow
{
    [SerializeField] GameObject _avatarRoot;
    [SerializeField] bool _setupProtection = true;
    [SerializeField] bool _setupEyes = true;
    [SerializeField] bool _setupFaceTracking = true;
    [SerializeField] bool _setupVolumeMeter = false;
    [SerializeField] Transform _leftFootOverride;
    [SerializeField] Transform _rightFootOverride;
    [SerializeField] Transform _hipsOverride;
    [SerializeField] Vector3 _viewpointOffset;
    [SerializeField] Vector2 _scrollPosition;
    [SerializeField] bool _showOptionalRefs;

    static ResoniteAvatarSetupWizard _activeInstance;

    [MenuItem("Resonite SDK/Avatar Setup Wizard")]
    public static void ShowWindow()
    {
        var window = GetWindow<ResoniteAvatarSetupWizard>();
        window.titleContent = new GUIContent("Avatar Setup Wizard");
        window.minSize = new Vector2(400, 500);
        window.Show();
    }

    void OnEnable()
    {
        _activeInstance = this;
        SceneView.duringSceneGui += OnSceneGUI;
    }

    void OnDisable()
    {
        SceneView.duringSceneGui -= OnSceneGUI;
        if (_activeInstance == this)
            _activeInstance = null;
    }

    void OnGUI()
    {
        _scrollPosition = EditorGUILayout.BeginScrollView(_scrollPosition);

        DrawAvatarRootSection();

        var humanoidAnimator = GetValidHumanoidAnimator();
        bool hasValidAnimator = humanoidAnimator != null;
        var setupTracker = _avatarRoot != null ? _avatarRoot.GetComponent<AvatarSetupTracker>() : null;
        var avatarDescriptor = _avatarRoot != null ? _avatarRoot.GetComponent<BipedAvatarDescriptor>() : null;

        DrawValidationSection(humanoidAnimator, avatarDescriptor, setupTracker);

        if (hasValidAnimator)
        {
            DrawDetectedBonesSection(humanoidAnimator);
            DrawViewpointSection(avatarDescriptor);
            DrawOptionalReferencesSection(humanoidAnimator);
            DrawSetupOptionsSection();
            DrawToolAnchorSection(avatarDescriptor);
        }

        EditorGUILayout.Space(10);
        DrawActionButtons(hasValidAnimator, setupTracker, avatarDescriptor);

        EditorGUILayout.EndScrollView();
    }

    void OnSceneGUI(SceneView sceneView)
    {
        if (_avatarRoot == null)
            return;

        var avatarDescriptor = _avatarRoot.GetComponent<BipedAvatarDescriptor>();
        if (avatarDescriptor == null || avatarDescriptor.ViewpointReference == null)
            return;

        var viewpointTransform = avatarDescriptor.ViewpointReference;

        EditorGUI.BeginChangeCheck();
        var draggedPosition = Handles.PositionHandle(viewpointTransform.position, viewpointTransform.rotation);

        if (EditorGUI.EndChangeCheck())
        {
            Undo.RecordObject(viewpointTransform, "Move Viewpoint");
            viewpointTransform.position = draggedPosition;
            _viewpointOffset = viewpointTransform.localPosition;
            Repaint();
        }

        var viewpointWorldPosition = viewpointTransform.position;
        var viewpointWorldRotation = viewpointTransform.rotation;
        float eyeSeparationMeters = 0.065f;

        Handles.color = Color.cyan;
        Handles.SphereHandleCap(0, viewpointWorldPosition + viewpointWorldRotation * Vector3.left * eyeSeparationMeters * 0.5f, Quaternion.identity, 0.02f, EventType.Repaint);
        Handles.color = Color.red;
        Handles.SphereHandleCap(0, viewpointWorldPosition + viewpointWorldRotation * Vector3.right * eyeSeparationMeters * 0.5f, Quaternion.identity, 0.02f, EventType.Repaint);

        Handles.color = Color.blue;
        Handles.DrawLine(viewpointWorldPosition, viewpointWorldPosition + viewpointWorldRotation * Vector3.forward * 0.15f);

        Handles.color = Color.white;
        Handles.Label(viewpointWorldPosition + Vector3.up * 0.05f, "Viewpoint");
    }

    void DrawAvatarRootSection()
    {
        EditorGUILayout.LabelField("Avatar Root", EditorStyles.boldLabel);

        EditorGUI.BeginChangeCheck();
        _avatarRoot = (GameObject)EditorGUILayout.ObjectField("Root GameObject", _avatarRoot, typeof(GameObject), true);
        if (EditorGUI.EndChangeCheck())
            OnAvatarRootChanged();

        EditorGUILayout.Space(4);
    }

    void DrawValidationSection(Animator humanoidAnimator, BipedAvatarDescriptor avatarDescriptor, AvatarSetupTracker setupTracker)
    {
        if (_avatarRoot == null)
        {
            EditorGUILayout.HelpBox("Drag your avatar's root GameObject into the field above.", MessageType.Info);
            return;
        }

        if (humanoidAnimator == null)
        {
            var animatorOnRoot = _avatarRoot.GetComponent<Animator>();
            if (animatorOnRoot == null)
                EditorGUILayout.HelpBox("No Animator component found on the root GameObject.", MessageType.Error);
            else if (animatorOnRoot.avatar == null)
                EditorGUILayout.HelpBox("Animator has no Avatar assigned.", MessageType.Error);
            else if (!animatorOnRoot.avatar.isHuman)
                EditorGUILayout.HelpBox("Animator avatar is not Humanoid. Resonite avatars require a humanoid rig.", MessageType.Error);
            return;
        }

        if (avatarDescriptor != null)
            EditorGUILayout.HelpBox("BipedAvatarDescriptor already present. Setup will reconfigure it.", MessageType.Info);

        if (setupTracker != null)
            EditorGUILayout.HelpBox("Previous wizard setup detected. Use Revert to undo, or Setup to reconfigure.", MessageType.Info);
    }

    void DrawDetectedBonesSection(Animator humanoidAnimator)
    {
        EditorGUILayout.LabelField("Detected Bones", EditorStyles.boldLabel);

        using (new EditorGUI.DisabledScope(true))
        {
            DrawBoneField(humanoidAnimator, "Head", HumanBodyBones.Head);
            DrawBoneField(humanoidAnimator, "Left Hand", HumanBodyBones.LeftHand);
            DrawBoneField(humanoidAnimator, "Right Hand", HumanBodyBones.RightHand);

            var leftEyeBone = humanoidAnimator.GetBoneTransform(HumanBodyBones.LeftEye);
            var rightEyeBone = humanoidAnimator.GetBoneTransform(HumanBodyBones.RightEye);
            string eyeDetectionStatus = (leftEyeBone != null && rightEyeBone != null) ? "Detected" : "Not found (will estimate)";
            EditorGUILayout.LabelField("Eyes", eyeDetectionStatus);
        }

        EditorGUILayout.Space(4);
    }

    void DrawViewpointSection(BipedAvatarDescriptor avatarDescriptor)
    {
        EditorGUILayout.LabelField("Viewpoint Position", EditorStyles.boldLabel);

        if (avatarDescriptor != null && avatarDescriptor.ViewpointReference != null)
        {
            EditorGUI.BeginChangeCheck();
            var editedLocalPosition = EditorGUILayout.Vector3Field("Local Position", avatarDescriptor.ViewpointReference.localPosition);
            if (EditorGUI.EndChangeCheck())
            {
                Undo.RecordObject(avatarDescriptor.ViewpointReference, "Set Viewpoint Position");
                avatarDescriptor.ViewpointReference.localPosition = editedLocalPosition;
                _viewpointOffset = editedLocalPosition;
            }

            EditorGUILayout.BeginHorizontal();
            using (new EditorGUI.DisabledScope(true))
                EditorGUILayout.Vector3Field("World Position", avatarDescriptor.ViewpointReference.position);
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.HelpBox("Drag the position handle in the Scene View to adjust the viewpoint.", MessageType.None);
        }
        else
        {
            _viewpointOffset = EditorGUILayout.Vector3Field("Offset (applied on Setup)", _viewpointOffset);

            EditorGUILayout.BeginHorizontal();
            if (GUILayout.Button("Reset Offset", GUILayout.Width(100)))
                _viewpointOffset = Vector3.zero;
            EditorGUILayout.EndHorizontal();
        }

        EditorGUILayout.Space(4);
    }

    void DrawOptionalReferencesSection(Animator humanoidAnimator)
    {
        _showOptionalRefs = EditorGUILayout.Foldout(_showOptionalRefs, "Optional References", true, EditorStyles.foldoutHeader);
        if (!_showOptionalRefs)
            return;

        EditorGUI.indentLevel++;

        DrawOptionalRefWithAutoDetect(humanoidAnimator, "Left Foot", ref _leftFootOverride, HumanBodyBones.LeftFoot);
        DrawOptionalRefWithAutoDetect(humanoidAnimator, "Right Foot", ref _rightFootOverride, HumanBodyBones.RightFoot);
        DrawOptionalRefWithAutoDetect(humanoidAnimator, "Hips", ref _hipsOverride, HumanBodyBones.Hips);

        EditorGUI.indentLevel--;
        EditorGUILayout.Space(4);
    }

    void DrawSetupOptionsSection()
    {
        EditorGUILayout.LabelField("Setup Options", EditorStyles.boldLabel);

        _setupProtection = EditorGUILayout.Toggle("Avatar Protection", _setupProtection);
        _setupEyes = EditorGUILayout.Toggle("Eye Setup", _setupEyes);
        _setupFaceTracking = EditorGUILayout.Toggle("Face Tracking", _setupFaceTracking);
        _setupVolumeMeter = EditorGUILayout.Toggle("Volume Meter", _setupVolumeMeter);

        EditorGUILayout.Space(4);
    }

    void DrawToolAnchorSection(BipedAvatarDescriptor avatarDescriptor)
    {
        var humanoidAnimator = GetValidHumanoidAnimator();
        if (humanoidAnimator == null || avatarDescriptor == null) return;
        if (avatarDescriptor.LeftHandReference == null && avatarDescriptor.RightHandReference == null) return;

        EditorGUILayout.LabelField("Tool Anchors", EditorStyles.boldLabel);

        if (GUILayout.Button("Try Auto Setup Tool Anchors"))
            PositionToolAnchorsFromFingerBones(humanoidAnimator, avatarDescriptor);

        EditorGUILayout.Space(4);
    }

    void DrawActionButtons(bool hasValidAnimator, AvatarSetupTracker setupTracker, BipedAvatarDescriptor avatarDescriptor)
    {
        EditorGUILayout.BeginHorizontal();

        GUI.enabled = hasValidAnimator;
        if (GUILayout.Button("Setup Avatar", GUILayout.Height(32)))
            PerformSetup();

        GUI.enabled = setupTracker != null;
        if (GUILayout.Button("Revert Setup", GUILayout.Height(32)))
            PerformRevert();

        GUI.enabled = true;
        EditorGUILayout.EndHorizontal();
    }

    void PositionToolAnchorsFromFingerBones(Animator humanoidAnimator, BipedAvatarDescriptor avatarDescriptor)
    {
        Undo.SetCurrentGroupName("Try Auto Setup Tool Anchors");
        int undoGroup = Undo.GetCurrentGroup();

        if (avatarDescriptor.LeftHandReference != null)
            PositionHandAnchors(humanoidAnimator, avatarDescriptor.LeftHandReference, isRightHand: false);

        if (avatarDescriptor.RightHandReference != null)
            PositionHandAnchors(humanoidAnimator, avatarDescriptor.RightHandReference, isRightHand: true);

        Undo.CollapseUndoOperations(undoGroup);
        EditorSceneManager.MarkSceneDirty(_avatarRoot.scene);
        SceneView.RepaintAll();
    }

    void PositionHandAnchors(Animator humanoidAnimator, Transform handReferenceRoot, bool isRightHand)
    {
        var indexFingerTip = humanoidAnimator.GetBoneTransform(isRightHand ? HumanBodyBones.RightIndexDistal : HumanBodyBones.LeftIndexDistal);
        var middleFingerTip = humanoidAnimator.GetBoneTransform(isRightHand ? HumanBodyBones.RightMiddleDistal : HumanBodyBones.LeftMiddleDistal);
        var ringFingerTip = humanoidAnimator.GetBoneTransform(isRightHand ? HumanBodyBones.RightRingDistal : HumanBodyBones.LeftRingDistal);
        var pinkyFingerTip = humanoidAnimator.GetBoneTransform(isRightHand ? HumanBodyBones.RightLittleDistal : HumanBodyBones.LeftLittleDistal);

        var indexFingerBase = humanoidAnimator.GetBoneTransform(isRightHand ? HumanBodyBones.RightIndexProximal : HumanBodyBones.LeftIndexProximal);
        var middleFingerBase = humanoidAnimator.GetBoneTransform(isRightHand ? HumanBodyBones.RightMiddleProximal : HumanBodyBones.LeftMiddleProximal);
        var ringFingerBase = humanoidAnimator.GetBoneTransform(isRightHand ? HumanBodyBones.RightRingProximal : HumanBodyBones.LeftRingProximal);
        var pinkyFingerBase = humanoidAnimator.GetBoneTransform(isRightHand ? HumanBodyBones.RightLittleProximal : HumanBodyBones.LeftLittleProximal);

        var indexFingerMiddleJoint = humanoidAnimator.GetBoneTransform(isRightHand ? HumanBodyBones.RightIndexIntermediate : HumanBodyBones.LeftIndexIntermediate);
        var handBone = humanoidAnimator.GetBoneTransform(isRightHand ? HumanBodyBones.RightHand : HumanBodyBones.LeftHand);

        PositionTooltipAtIndexFingertip(handReferenceRoot, indexFingerTip, indexFingerMiddleJoint, indexFingerBase, handBone);
        PositionGrabberAtPalmCenter(handReferenceRoot, handBone,
            new[] { indexFingerTip, middleFingerTip, ringFingerTip, pinkyFingerTip },
            new[] { indexFingerBase, middleFingerBase, ringFingerBase, pinkyFingerBase });
        PositionShelfAboveGrabber(handReferenceRoot);
    }

    void PositionTooltipAtIndexFingertip(Transform handReferenceRoot, Transform indexDistalBone, Transform indexIntermediateBone, Transform indexProximalBone, Transform handBone)
    {
        var tooltipTransform = handReferenceRoot.Find("Tooltip");
        if (tooltipTransform == null || indexDistalBone == null)
            return;

        Undo.RecordObject(tooltipTransform, "Position Tooltip");

        Vector3 fingerForwardDirection;

        if (indexIntermediateBone != null)
        {
            fingerForwardDirection = (indexDistalBone.position - indexIntermediateBone.position).normalized;
            float distalBoneLength = Vector3.Distance(indexIntermediateBone.position, indexDistalBone.position);
            tooltipTransform.position = indexDistalBone.position + fingerForwardDirection * distalBoneLength;
        }
        else if (indexProximalBone != null)
        {
            fingerForwardDirection = (indexDistalBone.position - indexProximalBone.position).normalized;
            tooltipTransform.position = indexDistalBone.position;
        }
        else
        {
            fingerForwardDirection = indexDistalBone.forward;
            tooltipTransform.position = indexDistalBone.position;
        }

        var tooltipUpDirection = handBone != null ? handBone.up : Vector3.up;
        bool fingerPointsAlongUpAxis = Mathf.Abs(Vector3.Dot(fingerForwardDirection, tooltipUpDirection)) > 0.95f;
        if (fingerPointsAlongUpAxis)
            tooltipUpDirection = handBone != null ? handBone.forward : Vector3.forward;

        tooltipTransform.rotation = Quaternion.LookRotation(fingerForwardDirection, tooltipUpDirection);
    }

    void PositionGrabberAtPalmCenter(Transform handReferenceRoot, Transform handBone, Transform[] fingerTipBones, Transform[] fingerBaseBones)
    {
        var grabberTransform = handReferenceRoot.Find("Grabber");
        if (grabberTransform == null || handBone == null)
            return;

        Undo.RecordObject(grabberTransform, "Position Grabber");

        var validFingerTips = fingerTipBones.Where(bone => bone != null).ToArray();
        var validFingerBases = fingerBaseBones.Where(bone => bone != null).ToArray();

        if (validFingerTips.Length > 0 && validFingerBases.Length > 0)
        {
            var averageFingerTipPosition = validFingerTips.Aggregate(Vector3.zero, (sum, bone) => sum + bone.position) / validFingerTips.Length;
            var averageFingerBasePosition = validFingerBases.Aggregate(Vector3.zero, (sum, bone) => sum + bone.position) / validFingerBases.Length;

            float palmBias = 0.65f;
            grabberTransform.position = Vector3.Lerp(averageFingerTipPosition, averageFingerBasePosition, palmBias);

            var palmToFingersDirection = (averageFingerTipPosition - averageFingerBasePosition).normalized;
            grabberTransform.rotation = Quaternion.LookRotation(palmToFingersDirection, Vector3.up);
        }
        else
        {
            grabberTransform.position = handBone.position + handBone.forward * 0.05f;
        }
    }

    void PositionShelfAboveGrabber(Transform handReferenceRoot)
    {
        var shelfTransform = handReferenceRoot.Find("Shelf");
        var grabberTransform = handReferenceRoot.Find("Grabber");
        if (shelfTransform == null || grabberTransform == null)
            return;

        Undo.RecordObject(shelfTransform, "Position Shelf");
        shelfTransform.position = grabberTransform.position + Vector3.up * 0.04f - grabberTransform.forward * 0.03f;
        shelfTransform.rotation = grabberTransform.rotation;
    }

    void PerformSetup()
    {
        Undo.SetCurrentGroupName("Avatar Setup Wizard");
        int undoGroup = Undo.GetCurrentGroup();

        var setupTracker = _avatarRoot.GetComponent<AvatarSetupTracker>();
        if (setupTracker == null)
            setupTracker = Undo.AddComponent<AvatarSetupTracker>(_avatarRoot);
        else
            Undo.RecordObject(setupTracker, "Reconfigure Avatar Setup");

        var avatarDescriptor = _avatarRoot.GetComponent<BipedAvatarDescriptor>();
        bool isNewDescriptor = avatarDescriptor == null;

        if (isNewDescriptor)
        {
            avatarDescriptor = Undo.AddComponent<BipedAvatarDescriptor>(_avatarRoot);
            setupTracker.TrackComponent(avatarDescriptor);
        }
        else
        {
            Undo.RecordObject(avatarDescriptor, "Reconfigure BipedAvatarDescriptor");
        }

        avatarDescriptor.SetupProtection = _setupProtection;
        avatarDescriptor.SetupEyes = _setupEyes;
        avatarDescriptor.SetupFaceTracking = _setupFaceTracking;
        avatarDescriptor.SetupVolumeMeter = _setupVolumeMeter;

        if (_leftFootOverride != null) avatarDescriptor.LeftFootReference = _leftFootOverride;
        if (_rightFootOverride != null) avatarDescriptor.RightFootReference = _rightFootOverride;
        if (_hipsOverride != null) avatarDescriptor.HipsReference = _hipsOverride;

        if (isNewDescriptor)
            TrackCreatedReferenceHierarchy(setupTracker, avatarDescriptor);

        if (avatarDescriptor.ViewpointReference != null && _viewpointOffset != Vector3.zero)
        {
            Undo.RecordObject(avatarDescriptor.ViewpointReference, "Apply Viewpoint Offset");
            avatarDescriptor.ViewpointReference.localPosition += _viewpointOffset;
        }

        EditorUtility.SetDirty(setupTracker);
        EditorUtility.SetDirty(avatarDescriptor);
        Undo.CollapseUndoOperations(undoGroup);
        EditorSceneManager.MarkSceneDirty(_avatarRoot.scene);
        SceneView.RepaintAll();
    }

    void TrackCreatedReferenceHierarchy(AvatarSetupTracker setupTracker, BipedAvatarDescriptor avatarDescriptor)
    {
        if (avatarDescriptor.ViewpointReference == null)
            return;

        var referencesContainer = avatarDescriptor.ViewpointReference.parent;
        if (referencesContainer == null || referencesContainer.gameObject.name != "References")
            return;

        setupTracker.TrackGameObject(referencesContainer.gameObject);
    }

    void PerformRevert()
    {
        var setupTracker = _avatarRoot.GetComponent<AvatarSetupTracker>();
        if (setupTracker == null)
            return;

        int remainingComponentCount = setupTracker.AddedComponents.Count(c => c != null);
        int remainingGameObjectCount = setupTracker.CreatedGameObjects.Count(go => go != null);

        if (!EditorUtility.DisplayDialog("Revert Avatar Setup",
            $"This will remove:\n- {remainingComponentCount} component(s)\n- {remainingGameObjectCount} GameObject(s)\n\nThis action is undoable (Ctrl+Z).",
            "Revert", "Cancel"))
            return;

        Undo.SetCurrentGroupName("Revert Avatar Setup");
        int undoGroup = Undo.GetCurrentGroup();

        foreach (var trackedGameObject in setupTracker.CreatedGameObjects)
        {
            if (trackedGameObject != null)
                Undo.DestroyObjectImmediate(trackedGameObject);
        }

        foreach (var trackedComponent in setupTracker.AddedComponents)
        {
            if (trackedComponent != null)
                Undo.DestroyObjectImmediate(trackedComponent);
        }

        Undo.DestroyObjectImmediate(setupTracker);

        Undo.CollapseUndoOperations(undoGroup);
        EditorSceneManager.MarkSceneDirty(_avatarRoot.scene);
        SceneView.RepaintAll();
    }

    Animator GetValidHumanoidAnimator()
    {
        if (_avatarRoot == null)
            return null;

        var animator = _avatarRoot.GetComponent<Animator>();
        if (animator == null || animator.avatar == null || !animator.avatar.isHuman)
            return null;

        return animator;
    }

    void OnAvatarRootChanged()
    {
        if (_avatarRoot == null)
            return;

        AutoFillOptionalReferences();
    }

    void AutoFillOptionalReferences()
    {
        var humanoidAnimator = GetValidHumanoidAnimator();
        if (humanoidAnimator == null) return;

        if (_leftFootOverride == null)
            _leftFootOverride = humanoidAnimator.GetBoneTransform(HumanBodyBones.LeftFoot);
        if (_rightFootOverride == null)
            _rightFootOverride = humanoidAnimator.GetBoneTransform(HumanBodyBones.RightFoot);
        if (_hipsOverride == null)
            _hipsOverride = humanoidAnimator.GetBoneTransform(HumanBodyBones.Hips);
    }

    void DrawBoneField(Animator humanoidAnimator, string label, HumanBodyBones bone)
    {
        var boneTransform = humanoidAnimator.GetBoneTransform(bone);
        string boneName = boneTransform != null ? boneTransform.name : "(not found)";
        EditorGUILayout.LabelField(label, boneName);
    }

    void DrawOptionalRefWithAutoDetect(Animator humanoidAnimator, string label, ref Transform field, HumanBodyBones bone)
    {
        EditorGUILayout.BeginHorizontal();
        field = (Transform)EditorGUILayout.ObjectField(label, field, typeof(Transform), true);
        if (GUILayout.Button("Auto", GUILayout.Width(48)))
        {
            var detectedBone = humanoidAnimator.GetBoneTransform(bone);
            if (detectedBone != null)
                field = detectedBone;
            else
                Debug.LogWarning($"[Avatar Setup Wizard] Could not auto-detect {label} bone.");
        }
        EditorGUILayout.EndHorizontal();
    }
}
