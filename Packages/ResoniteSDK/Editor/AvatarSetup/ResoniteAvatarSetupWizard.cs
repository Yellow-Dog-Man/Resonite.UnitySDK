using System;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace ResoniteSDK.Editor {
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
        [SerializeField] bool _useGlobalOrientation;
        [SerializeField] bool _showOptionalRefs;
        [SerializeField] bool _showRotationTools;
        [SerializeField] bool _showEditVisuals = true;
        [SerializeField] bool _showViewpointVisual = true;
        [SerializeField] bool _showLeftFootVisual = true;
        [SerializeField] bool _showRightFootVisual = true;
        [SerializeField] bool _showHipsVisual = true;
        [SerializeField] bool _showTooltipVisual = true;
        [SerializeField] bool _showGrabberVisual = true;
        [SerializeField] bool _showShelfVisual = true;

        [MenuItem("Resonite SDK/Avatar Setup Wizard")]
        public static void ShowWindow()
        {
            var window = GetWindow<ResoniteAvatarSetupWizard>();
            window.titleContent = new GUIContent("Avatar Setup Wizard");
            window.minSize = new Vector2(420, 500);
            window.Show();
        }

        void OnEnable() => SceneView.duringSceneGui += OnSceneGUI;
        void OnDisable() => SceneView.duringSceneGui -= OnSceneGUI;

        void OnGUI()
        {
            _scrollPosition = EditorGUILayout.BeginScrollView(_scrollPosition);

            DrawAvatarRootSection();

            var humanoidAnimator = GetValidHumanoidAnimator();
            bool hasValidAnimator = humanoidAnimator != null;
            var setupTracker = _avatarRoot != null ? _avatarRoot.GetComponent<AvatarSetupTracker>() : null;
            var avatarDescriptor = _avatarRoot != null ? _avatarRoot.GetComponent<ResoniteBipedAvatarDescriptor>() : null;

            DrawValidationSection(humanoidAnimator, avatarDescriptor, setupTracker);

            if (hasValidAnimator)
            {
                DrawDetectedBonesSection(humanoidAnimator);
                DrawViewpointSection(avatarDescriptor);
                DrawSetupOptionsSection();

                EditorGUILayout.Space(6);
                DrawActionButtons(hasValidAnimator, setupTracker, avatarDescriptor);
                EditorGUILayout.Space(6);

                DrawSeparator();
                DrawOptionalReferencesSection(humanoidAnimator);
                DrawRotationToolsSection(avatarDescriptor);

                DrawSeparator();
                DrawEditVisualsSection();
            }
            else
            {
                EditorGUILayout.Space(10);
                DrawActionButtons(hasValidAnimator, setupTracker, avatarDescriptor);
            }

            EditorGUILayout.EndScrollView();
        }

        // ─────────────────────────────────────────────
        //  Scene Gizmos
        // ─────────────────────────────────────────────

        void OnSceneGUI(SceneView sceneView)
        {
            if (_avatarRoot == null)
                return;

            var avatarDescriptor = _avatarRoot.GetComponent<ResoniteBipedAvatarDescriptor>();
            if (avatarDescriptor == null)
                return;

            if (_showViewpointVisual && avatarDescriptor.ViewpointReference != null)
                DrawViewpointGizmo(avatarDescriptor.ViewpointReference);

            if (_showLeftFootVisual && avatarDescriptor.LeftFootReference != null)
                DrawFootGizmo(avatarDescriptor.LeftFootReference, "Left Foot", Color.cyan);

            if (_showRightFootVisual && avatarDescriptor.RightFootReference != null)
                DrawFootGizmo(avatarDescriptor.RightFootReference, "Right Foot", new Color(1f, 0.4f, 0.4f));

            if (_showHipsVisual && avatarDescriptor.HipsReference != null)
                DrawHipsGizmo(avatarDescriptor.HipsReference);

            if (avatarDescriptor.LeftHandReference != null)
                DrawHandAnchorsGizmo(avatarDescriptor.LeftHandReference, "L");

            if (avatarDescriptor.RightHandReference != null)
                DrawHandAnchorsGizmo(avatarDescriptor.RightHandReference, "R");
        }

        void DrawViewpointGizmo(Transform viewpointTransform)
        {
            EditorGUI.BeginChangeCheck();
            var draggedPosition = Handles.PositionHandle(viewpointTransform.position, viewpointTransform.rotation);

            if (EditorGUI.EndChangeCheck())
            {
                Undo.RecordObject(viewpointTransform, "Move Viewpoint");
                viewpointTransform.position = draggedPosition;
                _viewpointOffset = viewpointTransform.localPosition;
                Repaint();
            }

            var pos = viewpointTransform.position;
            var rot = viewpointTransform.rotation;
            float eyeSeparation = 0.065f;

            Handles.color = Color.cyan;
            Handles.SphereHandleCap(0, pos + rot * Vector3.left * eyeSeparation * 0.5f, Quaternion.identity, 0.02f, EventType.Repaint);
            Handles.color = Color.red;
            Handles.SphereHandleCap(0, pos + rot * Vector3.right * eyeSeparation * 0.5f, Quaternion.identity, 0.02f, EventType.Repaint);

            Handles.color = Color.blue;
            Handles.DrawLine(pos, pos + rot * Vector3.forward * 0.15f);

            Handles.color = Color.white;
            Handles.Label(pos + Vector3.up * 0.05f, "Viewpoint");
        }

        void DrawFootGizmo(Transform footTransform, string label, Color color)
        {
            var pos = footTransform.position;
            var rot = footTransform.rotation;

            Handles.color = color;
            Handles.matrix = Matrix4x4.TRS(pos + rot * Vector3.forward * 0.06f, rot, Vector3.one);
            Handles.DrawWireCube(Vector3.zero, new Vector3(0.075f, 0.04f, 0.15f));
            Handles.matrix = Matrix4x4.identity;

            DrawAxisLines(pos, rot, 0.1f);

            Handles.color = Color.white;
            Handles.Label(pos + Vector3.up * 0.05f, label);
        }

        void DrawHipsGizmo(Transform hipsTransform)
        {
            var pos = hipsTransform.position;
            var rot = hipsTransform.rotation;

            Handles.color = Color.magenta;
            Handles.DrawWireDisc(pos, rot * Vector3.up, 0.1f);
            Handles.DrawWireDisc(pos, rot * Vector3.forward, 0.1f);

            DrawAxisLines(pos, rot, 0.15f);

            Handles.color = Color.white;
            Handles.Label(pos + Vector3.up * 0.12f, "Hips");
        }

        void DrawHandAnchorsGizmo(Transform handReference, string side)
        {
            var tooltip = handReference.Find("Tooltip");
            if (_showTooltipVisual && tooltip != null)
            {
                Handles.color = new Color(1f, 0f, 1f);
                Handles.SphereHandleCap(0, tooltip.position, Quaternion.identity, 0.015f, EventType.Repaint);
                Handles.DrawLine(tooltip.position, tooltip.position + tooltip.forward * 0.05f);
                Handles.color = Color.white;
                Handles.Label(tooltip.position + Vector3.up * 0.02f, side + " Tooltip");
            }

            var grabber = handReference.Find("Grabber");
            if (_showGrabberVisual && grabber != null)
            {
                Handles.color = new Color(0.5f, 0f, 1f, 0.6f);
                Handles.DrawWireDisc(grabber.position, grabber.up, 0.04f);
                Handles.DrawWireDisc(grabber.position, grabber.forward, 0.04f);
                Handles.DrawWireDisc(grabber.position, grabber.right, 0.04f);
                Handles.color = Color.white;
                Handles.Label(grabber.position + Vector3.up * 0.05f, side + " Grabber");
            }

            var shelf = handReference.Find("Shelf");
            if (_showShelfVisual && shelf != null)
            {
                Handles.color = new Color(0.75f, 0f, 1f);
                Handles.matrix = Matrix4x4.TRS(shelf.position, shelf.rotation, Vector3.one);
                Handles.DrawWireCube(Vector3.zero, new Vector3(0.02f, 0.003f, 0.04f));
                Handles.matrix = Matrix4x4.identity;
                Handles.color = Color.white;
                Handles.Label(shelf.position + Vector3.up * 0.02f, side + " Shelf");
            }
        }

        void DrawAxisLines(Vector3 position, Quaternion rotation, float length)
        {
            Handles.color = Color.blue;
            Handles.DrawLine(position, position + rotation * Vector3.forward * length);
            Handles.color = Color.green;
            Handles.DrawLine(position, position + rotation * Vector3.up * length);
            Handles.color = Color.red;
            Handles.DrawLine(position, position + rotation * Vector3.right * length);
        }

        // ─────────────────────────────────────────────
        //  UI Sections
        // ─────────────────────────────────────────────

        void DrawAvatarRootSection()
        {
            EditorGUILayout.LabelField("Avatar Root", EditorStyles.boldLabel);

            EditorGUI.BeginChangeCheck();
            _avatarRoot = (GameObject)EditorGUILayout.ObjectField("Root GameObject", _avatarRoot, typeof(GameObject), true);
            if (EditorGUI.EndChangeCheck())
                OnAvatarRootChanged();

            EditorGUILayout.Space(4);
        }

        void DrawValidationSection(Animator humanoidAnimator, ResoniteBipedAvatarDescriptor avatarDescriptor, AvatarSetupTracker setupTracker)
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

            if (setupTracker != null)
                EditorGUILayout.HelpBox("Previous setup detected. Use Revert to undo, or Setup to reconfigure.", MessageType.Info);
            else if (avatarDescriptor != null)
                EditorGUILayout.HelpBox("ResoniteBipedAvatarDescriptor already present. Setup will reconfigure it.", MessageType.Info);
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
                string eyeStatus = (leftEyeBone != null && rightEyeBone != null) ? "Detected" : "Not found (will estimate)";
                EditorGUILayout.LabelField("Eyes", eyeStatus);
            }

            EditorGUILayout.Space(4);
        }

        void DrawViewpointSection(ResoniteBipedAvatarDescriptor avatarDescriptor)
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

                using (new EditorGUI.DisabledScope(true))
                    EditorGUILayout.Vector3Field("World Position", avatarDescriptor.ViewpointReference.position);

                EditorGUILayout.HelpBox("Drag the position handle in the Scene View to adjust the viewpoint.", MessageType.None);
            }
            else
            {
                _viewpointOffset = EditorGUILayout.Vector3Field("Offset (applied on Setup)", _viewpointOffset);
                if (GUILayout.Button("Reset Offset", GUILayout.Width(100)))
                    _viewpointOffset = Vector3.zero;
            }

            EditorGUILayout.Space(4);
        }

        void DrawSetupOptionsSection()
        {
            EditorGUILayout.LabelField("Setup Options", EditorStyles.boldLabel);

            _setupProtection = EditorGUILayout.Toggle("Avatar Protection", _setupProtection);
            _setupEyes = EditorGUILayout.Toggle("Eye Setup", _setupEyes);
            _setupFaceTracking = EditorGUILayout.Toggle("Face Tracking", _setupFaceTracking);
            _setupVolumeMeter = EditorGUILayout.Toggle("Volume Meter", _setupVolumeMeter);
            _useGlobalOrientation = EditorGUILayout.Toggle("Use Global Forward/Up", _useGlobalOrientation);

            if (!_useGlobalOrientation && _avatarRoot != null && RootDeviatesFromGlobal())
                EditorGUILayout.HelpBox("Root forward/up differs from global. Enable this if hips or feet are rotated incorrectly.", MessageType.Warning);

            EditorGUILayout.Space(2);
        }

        void DrawActionButtons(bool hasValidAnimator, AvatarSetupTracker setupTracker, ResoniteBipedAvatarDescriptor avatarDescriptor)
        {
            EditorGUILayout.BeginHorizontal();

            GUI.enabled = hasValidAnimator;
            if (GUILayout.Button("Setup Avatar", GUILayout.Height(30)))
                PerformSetup();

            GUI.enabled = setupTracker != null;
            if (GUILayout.Button("Revert Setup", GUILayout.Height(30)))
                PerformRevert();

            GUI.enabled = true;
            EditorGUILayout.EndHorizontal();
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

        void DrawRotationToolsSection(ResoniteBipedAvatarDescriptor avatarDescriptor)
        {
            if (avatarDescriptor == null)
                return;

            bool hasAnyRef = avatarDescriptor.LeftFootReference != null
                || avatarDescriptor.RightFootReference != null
                || avatarDescriptor.HipsReference != null
                || avatarDescriptor.LeftHandReference != null
                || avatarDescriptor.RightHandReference != null;

            if (!hasAnyRef)
                return;

            _showRotationTools = EditorGUILayout.Foldout(_showRotationTools, "Tools", true, EditorStyles.foldoutHeader);
            if (!_showRotationTools)
                return;

            EditorGUI.indentLevel++;

            if (avatarDescriptor.LeftFootReference != null || avatarDescriptor.RightFootReference != null)
            {
                EditorGUILayout.LabelField("Feet", EditorStyles.miniBoldLabel);

                EditorGUILayout.BeginHorizontal();
                DrawSmallFixButton("Fix Left (Toes)", avatarDescriptor.LeftFootReference,
                    () => avatarDescriptor.TryFixFootRotation(false));
                DrawSmallFixButton("Fix Right (Toes)", avatarDescriptor.RightFootReference,
                    () => avatarDescriptor.TryFixFootRotation(true));
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();
                DrawSmallFixButton("Mirror L \u2192 R", avatarDescriptor.RightFootReference,
                    () => avatarDescriptor.MirrorRotation(avatarDescriptor.LeftFootReference, avatarDescriptor.RightFootReference, 1));
                DrawSmallFixButton("Mirror R \u2192 L", avatarDescriptor.LeftFootReference,
                    () => avatarDescriptor.MirrorRotation(avatarDescriptor.RightFootReference, avatarDescriptor.LeftFootReference, 1));
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();
                DrawSmallFixButton("Compute Left", avatarDescriptor.LeftFootReference,
                    () => avatarDescriptor.RecomputeFootReference(false, _useGlobalOrientation));
                DrawSmallFixButton("Compute Right", avatarDescriptor.RightFootReference,
                    () => avatarDescriptor.RecomputeFootReference(true, _useGlobalOrientation));
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.Space(4);
            }

            if (avatarDescriptor.HipsReference != null)
            {
                EditorGUILayout.LabelField("Hips", EditorStyles.miniBoldLabel);

                EditorGUILayout.BeginHorizontal();
                DrawSmallFixButton("Fix (Tail)", avatarDescriptor.HipsReference,
                    () => avatarDescriptor.TryFixHipsRotation());
                DrawSmallFixButton("Fix (Belly)", avatarDescriptor.HipsReference,
                    () => avatarDescriptor.TryFixHipsRotationFromBelly());
                EditorGUILayout.EndHorizontal();

                DrawSmallFixButton("Compute Hips", avatarDescriptor.HipsReference,
                    () => avatarDescriptor.RecomputeHipsReference(_useGlobalOrientation));

                EditorGUILayout.Space(4);
            }

            if (avatarDescriptor.LeftHandReference != null || avatarDescriptor.RightHandReference != null)
            {
                EditorGUILayout.LabelField("Tool Anchors", EditorStyles.miniBoldLabel);

                if (GUILayout.Button("Try Auto Setup Tool Anchors", GUILayout.Height(22)))
                {
                    Undo.SetCurrentGroupName("Try Auto Setup Tool Anchors");
                    int undoGroup = Undo.GetCurrentGroup();

                    RecordHandAnchorChildrenForUndo(avatarDescriptor.LeftHandReference);
                    RecordHandAnchorChildrenForUndo(avatarDescriptor.RightHandReference);

                    avatarDescriptor.TryAutoPositionToolAnchors();

                    Undo.CollapseUndoOperations(undoGroup);
                    EditorSceneManager.MarkSceneDirty(_avatarRoot.scene);
                    SceneView.RepaintAll();
                }

                EditorGUILayout.Space(4);
            }

            EditorGUI.indentLevel--;
        }

        void DrawSmallFixButton(string label, Transform referenceSlot, Func<bool> fixAction)
        {
            GUI.enabled = referenceSlot != null;
            if (GUILayout.Button(label, GUILayout.Height(22)))
            {
                Undo.RecordObject(referenceSlot, label);
                if (!fixAction())
                {
                    Debug.LogWarning($"[Avatar Setup Wizard] {label}: no suitable bone data found.");
                }
                else
                {
                    EditorUtility.SetDirty(referenceSlot);
                    EditorSceneManager.MarkSceneDirty(referenceSlot.gameObject.scene);
                    SceneView.RepaintAll();
                }
            }
            GUI.enabled = true;
        }

        void DrawEditVisualsSection()
        {
            _showEditVisuals = EditorGUILayout.Foldout(_showEditVisuals, "Edit Visuals", true, EditorStyles.foldoutHeader);
            if (!_showEditVisuals)
                return;

            EditorGUI.BeginChangeCheck();

            EditorGUI.indentLevel++;
            _showViewpointVisual = EditorGUILayout.Toggle("Viewpoint", _showViewpointVisual);
            _showLeftFootVisual = EditorGUILayout.Toggle("Left Foot", _showLeftFootVisual);
            _showRightFootVisual = EditorGUILayout.Toggle("Right Foot", _showRightFootVisual);
            _showHipsVisual = EditorGUILayout.Toggle("Hips", _showHipsVisual);
            _showTooltipVisual = EditorGUILayout.Toggle("Tooltip", _showTooltipVisual);
            _showGrabberVisual = EditorGUILayout.Toggle("Grabber", _showGrabberVisual);
            _showShelfVisual = EditorGUILayout.Toggle("Shelf", _showShelfVisual);
            EditorGUI.indentLevel--;

            if (EditorGUI.EndChangeCheck())
                SceneView.RepaintAll();

            EditorGUILayout.Space(4);
        }

        // ─────────────────────────────────────────────
        //  Setup / Revert
        // ─────────────────────────────────────────────

        void PerformSetup()
        {
            Undo.SetCurrentGroupName("Avatar Setup Wizard");
            int undoGroup = Undo.GetCurrentGroup();

            var setupTracker = _avatarRoot.GetComponent<AvatarSetupTracker>();
            if (setupTracker == null)
                setupTracker = Undo.AddComponent<AvatarSetupTracker>(_avatarRoot);
            else
                Undo.RecordObject(setupTracker, "Reconfigure Avatar Setup");

            var avatarDescriptor = _avatarRoot.GetComponent<ResoniteBipedAvatarDescriptor>();
            bool isNewDescriptor = avatarDescriptor == null;

            if (isNewDescriptor)
            {
                avatarDescriptor = Undo.AddComponent<ResoniteBipedAvatarDescriptor>(_avatarRoot);
                setupTracker.TrackComponent(avatarDescriptor);
            }
            else
            {
                Undo.RecordObject(avatarDescriptor, "Reconfigure ResoniteBipedAvatarDescriptor");
            }

            avatarDescriptor.SetupProtection = _setupProtection;
            avatarDescriptor.SetupEyes = _setupEyes;
            avatarDescriptor.SetupFaceTracking = _setupFaceTracking;
            avatarDescriptor.SetupVolumeMeter = _setupVolumeMeter;

            var referencesParent = avatarDescriptor.EnsureReferencesExist();
            if (referencesParent != null)
                avatarDescriptor.CreateOptionalReferenceSlots(referencesParent, _useGlobalOrientation,
                    _leftFootOverride, _rightFootOverride, _hipsOverride);

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

        void TrackCreatedReferenceHierarchy(AvatarSetupTracker setupTracker, ResoniteBipedAvatarDescriptor avatarDescriptor)
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

        // ─────────────────────────────────────────────
        //  Helpers
        // ─────────────────────────────────────────────

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

            // Reset the viewpoint offset, to prevent offset from previous avatar being applied
            _viewpointOffset = Vector3.zero;
            _leftFootOverride = null;
            _rightFootOverride = null;
            _hipsOverride = null;

            var existingDescriptor = _avatarRoot.GetComponent<ResoniteBipedAvatarDescriptor>();
            if (existingDescriptor != null)
            {
                _setupProtection = existingDescriptor.SetupProtection;
                _setupEyes = existingDescriptor.SetupEyes;
                _setupFaceTracking = existingDescriptor.SetupFaceTracking;
                _setupVolumeMeter = existingDescriptor.SetupVolumeMeter;
            }
        }

        bool RootDeviatesFromGlobal()
        {
            var rootRotation = _avatarRoot.transform.rotation;
            float forwardDot = Vector3.Dot(rootRotation * Vector3.forward, Vector3.forward);
            float upDot = Vector3.Dot(rootRotation * Vector3.up, Vector3.up);
            return forwardDot < 0.99f || upDot < 0.99f;
        }

        void DrawSeparator()
        {
            EditorGUILayout.Space(2);
            var rect = EditorGUILayout.GetControlRect(false, 1);
            EditorGUI.DrawRect(rect, new Color(0.5f, 0.5f, 0.5f, 0.3f));
            EditorGUILayout.Space(2);
        }

        void DrawBoneField(Animator humanoidAnimator, string label, HumanBodyBones bone)
        {
            var boneTransform = humanoidAnimator.GetBoneTransform(bone);
            string boneName = boneTransform != null ? boneTransform.name : "(not found)";
            EditorGUILayout.LabelField(label, boneName);
        }

        void RecordHandAnchorChildrenForUndo(Transform handReference)
        {
            if (handReference == null)
                return;

            var tooltip = handReference.Find("Tooltip");
            var grabber = handReference.Find("Grabber");
            var shelf = handReference.Find("Shelf");

            if (tooltip != null) Undo.RecordObject(tooltip, "Position Tool Anchors");
            if (grabber != null) Undo.RecordObject(grabber, "Position Tool Anchors");
            if (shelf != null) Undo.RecordObject(shelf, "Position Tool Anchors");
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
}