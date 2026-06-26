# QA Evidence Summary

## Build
```text
# Game Build Validation Report

- project_name: NeonDrift_MVP
- run_id: notion-NeonDrift_MVP-build-build-ios-simulator-20260626141049
- stage_range: build-ios-simulator
- source_output_folder: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/
- source_handoff_path: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/handoffs/development/final_handoff.md

## Source Development Delivery Gate
- PASS source_output_folder_exists: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/
- PASS source_handoff_exists: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/handoffs/development/final_handoff.md
- PASS handoff_marker_delivery_status__passed: delivery_status: passed
- PASS handoff_marker_unity_project_path: unity_project_path:
- PASS handoff_marker_context_policy__compressed_context_first: context_policy: compressed_context_first
- PASS handoff_marker_context_pack_path__status_context_development_context_pack_md: context_pack_path: status/context/development_context_pack.md
- PASS handoff_marker_qa_automation: qa_automation:
- PASS handoff_marker_runtime_qa_probe_json: Runtime QA probe JSON:
- PASS unity_project_resolved: unity/NeonDrift (handoff unity_project_path)
- PASS source_file_exists.unity/NeonDrift/Packages/manifest.json
- PASS source_file_exists.unity/NeonDrift/ProjectSettings/ProjectVersion.txt
- PASS source_file_exists.unity/NeonDrift/Assets/Scenes/Main.unity
- PASS source_file_exists.unity/NeonDrift/Assets/Scripts/DriftPlayerController.cs
- PASS source_file_exists.unity/NeonDrift/Assets/Scripts/HazardSpawner.cs
- PASS source_file_exists.unity/NeonDrift/Assets/Scripts/GameSessionController.cs
- PASS source_file_exists.unity/NeonDrift/Assets/Scripts/RuntimeQaProbe.cs
- PASS source_file_exists.unity/NeonDrift/Assets/Scripts/NeonDriftUiActions.cs
- PASS source_file_exists.unity/NeonDrift/Assets/Tests/EditMode/NeonDriftEditModeTests.cs
- PASS source_file_exists.unity/NeonDrift/Assets/Tests/EditMode/NeonDrift.EditModeTests.asmdef
- PASS source_file_exists.unity/NeonDrift/Assets/Tests/PlayMode/NeonDriftPlayModeTests.cs
- PASS source_file_exists.unity/NeonDrift/Assets/Tests/PlayMode/NeonDrift.PlayModeTests.asmdef
- PASS source_file_exists.unity/NeonDrift/Assets/Editor/BuildPipelineRunner.cs
- PASS source_file_exists.unity/NeonDrift/Assets/Branding/AppIcon.png
- PASS source_file_exists.unity/NeonDrift/Assets/Branding/AppIcon.svg
- PASS source_file_exists.assets/icons/app_icon_master.svg
- PASS source_file_exists.assets/icons/app_icon_manifest.json
- PASS source_file_exists.assets/icons/app_icon_1024.png
- PASS source_file_exists.assets/icons/ios/AppIcon-1024.png
- PASS source_file_exists.assets/icons/android/adaptive-icon-foreground.png
- PASS source_file_exists.assets/icons/android/adaptive-icon-background.png
- PASS source_file_exists.assets/icons/web/favicon-32.png
- PASS source_file_exists.docs/development/Icon_Generation_Report.md
- PASS source_file_exists.status/validation/icon_assets_validation.md
- PASS source_file_exists.unity/NeonDrift/Assets/Art/Fonts/NeonDriftBitmapFont.png
- PASS source_file_exists.unity/NeonDrift/Assets/Art/Backgrounds/NeonTrackBackground.png
- PASS source_file_exists.unity/NeonDrift/Assets/Art/VFX/NeonDriftVfxSheet.png
- PASS source_file_exists.assets/fonts/neondrift_bitmap_font.png
- PASS source_file_exists.assets/fonts/neondrift_bitmap_font.fnt
- PASS source_file_exists.assets/fonts/typography_manifest.json
- PASS source_file_exists.assets/backgrounds/neon_track_background_2048.png
- PASS source_file_exists.assets/backgrounds/background_manifest.json
- PASS source_file_exists.assets/vfx/neon_drift_vfx_sheet.png
- PASS source_file_exists.assets/vfx/vfx_manifest.json
- PASS source_file_exists.docs/development/Visual_Assets_Generation_Report.md
- PASS source_file_exists.status/validation/visual_assets_validation.md
- PASS source_file_exists.handoffs/development/final_handoff.md
- PASS source_file_exists.status/context/development_context_pack.md
- PASS context_pack_marker_decisions: ## Decisions
- PASS context_pack_marker_constraints: ## Constraints
- PASS context_pack_marker_build_input: ## Build Input
- PASS context_pack_marker_source_paths: ## Source Paths
- PASS context_pack_marker_compressed_context_pack: compressed context pack
- PASS source_file_exists.status/validation/development_full_validation.md

## Unity Platform Build Gate
- PASS unity_project_exists: /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/unity/NeonDrift (handoff unity_project_path)
- PASS unity_build_workspace_prepared: /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/unity_build_workspace/NeonDrift.run.1782483119.37854
- PASS unity_editor_detected: /Applications/Unity/Hub/Editor/6000.0.77f1/Unity.app/Contents/MacOS/Unity
- PASS unity_project_version_detected: 6000.0.77f1
- PASS unity_qa_evidence_tests: /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_runqaevidencetests.log; copied=/Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_editmode_test_results.xml, /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml, /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json
- PASS unity_batchmode_ValidateProject: covered by unity_qa_evidence_tests
- PASS unity_platform_support_BuildIOSSimulator: /Applications/Unity/Hub/Editor/6000.0.77f1/PlaybackEngines/iOSSupport
- PASS unity_batchmode_BuildIOSSimulator: /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_buildiossimulator.log
- PASS xcodebuild_ios_simulator: log=
```

## Unity EditMode Test Results
```xml
<test-run testcasecount="3" result="Passed" total="3" passed="3" failed="0">
  <test-suite type="TestSuite" name="NeonDrift.EditMode" result="Passed">
    <test-case name="RuntimeQaProbeReturnsValidJsonShape" result="Passed" />
    <test-case name="BuildPipelineRunnerEnsuresScene" result="Passed" />
    <test-case name="GameSessionControllerTypeAvailable" result="Passed" />
  </test-suite>
</test-run>

```

## Unity PlayMode Test Results
```xml
<test-run testcasecount="33" result="Passed" total="33" passed="33" failed="0">
  <test-suite type="TestSuite" name="NeonDrift.PlayMode" result="Passed">
    <test-case name="MainSceneHasCanvas" result="Passed" />
    <test-case name="MainSceneHasHudController" result="Passed" />
    <test-case name="MainSceneHasRuntimeQaProbe" result="Passed" />
    <test-case name="MainSceneHasPlayer" result="Passed" />
    <test-case name="MainSceneHasHazardSpawner" result="Passed" />
    <test-case name="MainSceneHasGameOverPanel" result="Passed" />
    <test-case name="MainMenuHasStartSettingsBestScore" result="Passed" />
    <test-case name="PauseControlPresent" result="Passed" />
    <test-case name="LeftRightControlZonesPresent" result="Passed" />
    <test-case name="RetryControlPresent" result="Passed" />
    <test-case name="SafeAreaAndFramePacingConfigured" result="Passed" />
    <test-case name="UiEventSystemPresent" result="Passed" />
    <test-case name="MenuButtonsClickable" result="Passed" />
    <test-case name="PauseRetryButtonsClickable" result="Passed" />
    <test-case name="ButtonPositionsAndSizesAreVerified" result="Passed" />
    <test-case name="CoreGameplayFunctionsAreVerified" result="Passed" />
    <test-case name="InitialStateWaitsForStart" result="Passed" />
    <test-case name="MenuLayoutIsReadable" result="Passed" />
    <test-case name="GameplayVisualsAreReadable" result="Passed" />
    <test-case name="GameplayInstructionReadable" result="Passed" />
    <test-case name="ContentDepthIsVerified" result="Passed" />
    <test-case name="GameplayMotionIsVerified" result="Passed" />
    <test-case name="HazardApproachMotionIsVerified" result="Passed" />
    <test-case name="PlayerSteeringMotionIsVerified" result="Passed" />
    <test-case name="HumanAgencyChangesOutcome" result="Passed" />
    <test-case name="TenSecondPlayabilityVerified" result="Passed" />
    <test-case name="EnemyPatternPressureVerified" result="Passed" />
    <test-case name="SkillRewardLoopVerified" result="Passed" />
    <test-case name="HumanPlaytestChecklistVerified" result="Passed" />
    <test-case name="RetryRestartsGameplay" result="Passed" />
    <test-case name="SoundToggleAudioVerified" result="Passed" />
    <test-case name="StartButtonFlowVerified" result="Passed" />
    <test-case name="EarlyGameOverIsProtected" result="Passed" />
  </test-suite>
</test-run>

```

## Runtime QA Probe
```json
{
    "screenState": "menu",
    "screenWidth": 640,
    "screenHeight": 480,
    "safeArea": "(x:0.00, y:0.00, width:640.00, height:480.00)",
    "hasCanvas": true,
    "hasScoreText": true,
    "hasPulseText": true,
    "hasControlHint": true,
    "hasObjectiveText": true,
    "hasAvoidInstructionText": true,
    "hasPlayerLabel": true,
    "hasHazardLabel": true,
    "hasMainMenuPanel": true,
    "hasStartButton": true,
    "hasSettingsButton": true,
    "hasBestScoreText": true,
    "hasPauseButton": true,
    "hasRetryButton": true,
    "hasLeftControlZone": true,
    "hasRightControlZone": true,
    "hasGameOverPanel": true,
    "gameOverPanelVisible": false,
    "hasPlayer": true,
    "hasHazardSpawner": true,
    "hasEventSystem": true,
    "hasGraphicRaycaster": true,
    "hasUiActions": true,
    "startButtonClickable": true,
    "pauseButtonClickable": true,
    "retryButtonClickable": true,
    "settingsButtonClickable": true,
    "startButtonRect": "name=Start Button; width=360.0; height=96.0; min=(140.0,228.0); max=(500.0,324.0)",
    "settingsButtonRect": "name=Settings Button; width=360.0; height=82.0; min=(140.0,117.0); max=(500.0,199.0)",
    "pauseButtonRect": "name=Pause Button; width=96.0; height=72.0; min=(506.0,198.0); max=(602.0,270.0)",
    "retryButtonRect": "name=Retry Button; width=260.0; height=72.0; min=(190.0,239.0); max=(450.0,311.0)",
    "leftControlZoneRect": "name=Left Control Zone; width=250.0; height=156.0; min=(36.0,126.0); max=(286.0,282.0)",
    "rightControlZoneRect": "name=Right Control Zone; width=250.0; height=156.0; min=(354.0,126.0); max=(604.0,282.0)",
    "buttonLayoutVerified": true,
    "menuButtonSizeVerified": true,
    "pauseRetryButtonSizeVerified": true,
    "controlZoneSizeVerified": true,
    "controlsInsideSafeArea": true,
    "controlsDoNotOverlap": true,
    "menuLayoutVerified": true,
    "menuElementsDoNotOverlap": true,
    "gameplayHudHiddenInMenu": true,
    "gameplayControlsHiddenInMenu": true,
    "gameplayVisualsVerified": true,
    "gameplayVisualsHiddenInMenu": true,
    "gameplayInstructionReadableVerified": true,
    "contentDepthVerified": true,
    "gameplayMotionVerified": true,
    "hazardApproachMotionVerified": true,
    "playerSteeringMotionVerified": true,
    "humanAgencyVerified": true,
    "playerInputChangesOutcomeVerified": true,
    "coreGameplayObjectsVerified": true,
    "scoringSystemVerified": true,
    "pauseSystemVerified": true,
    "failureRetrySystemVerified": true,
    "startFlowVerified": true,
    "startButtonStartsGameVerified": true,
    "earlyGameOverProtected": true,
    "readableHazardPacingVerified": true,
    "tenSecondPlayabilityVerified": true,
    "enemyPatternPressureVerified": true,
    "skillRewardLoopVerified": true,
    "humanPlaytestChecklistVerified": true,
    "pauseControlVerified": true,
    "retryControlVerified": true,
    "retryRestartsGameplayVerified": true,
    "soundToggleAudioVerified": true,
    "audioSourcePresent": true,
    "leftRightSteeringVerified": true,
    "safeAreaApplied": true,
    "framePacingConfigured": true,
    "targetFrameRate": 60,
    "score": 0,
    "wave": 1,
    "combo": 0,
    "multiplier": 1,
    "boostCharge": 0.0,
    "currentLane": 0,
    "targetLane": 0,
    "lateralVelocity": 0.0,
    "driftDirection": "neutral",
    "trailState": "idle",
    "pickupCount": 0,
    "hazardCount": 0,
    "boostCount": 0,
    "comboCount": 0,
    "lastHazardSpawnX": 0.0,
    "scoreDeltaReason": "none",
    "pulseDeltaReason": "none",
    "lastCollisionType": "none",
    "lastFailureReason": "none",
    "isGameOver": false,
    "isPaused": false,
    "hasStarted": false,
    "gameplayTime": 0.0,
    "minimumSurvivalSeconds": 6.0,
    "framesPerSecond": 60.0,
    "exceptionCount": 0
}
```

## App Binary
```text
/Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.run.1782483119.37854.app/NeonDrift.run.1782483119.37854: Mach-O 64-bit executable arm64

```

## App Info
```text
{
    ApplicationType = User;
    Bundle = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data/Containers/Bundle/Application/8D05D9B3-88FA-43E9-9565-3655F3F898CF/NeonDrift.run.1782483119.37854.app/";
    BundleContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data/Containers/Bundle/Application/8D05D9B3-88FA-43E9-9565-3655F3F898CF/";
    CFBundleDisplayName = "NeonDrift.run.1782483119.37854";
    CFBundleExecutable = "NeonDrift.run.1782483119.37854";
    CFBundleIdentifier = "com.DefaultCompany.NeonDrift.run.1782483119.37854";
    CFBundleName = "NeonDrift.run.1782483119.37854";
    CFBundleVersion = 0;
    DataContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data/Containers/Data/Application/927F9877-5245-49B3-BB36-C34FC902409B/";
    GroupContainers =     {
    };
    Path = "/Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data/Containers/Bundle/Application/8D05D9B3-88FA-43E9-9565-3655F3F898CF/NeonDrift.run.1782483119.37854.app";
    SBAppTags =     (
    );
}

```

## Launch
```text
com.DefaultCompany.NeonDrift.run.1782483119.37854: 43500

```

## Screenshot
- path: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_menu.png
- exists: True
- bytes: 80138
- width: 1206
- height: 2622
- nonblank_estimate: nonblank

## Runtime Log Tail
```text
Timestamp               Ty Process[PID:TID]
2026-06-26 22:13:08.803 Df NeonDrift.run.1782483119.37854[39698:88303e] (CoreAudio)   HALC_ProxyIOContext.cpp:3376   HALC_IOContext_PauseIO(5523)
2026-06-26 22:13:08.803 Df NeonDrift.run.1782483119.37854[39698:88303e] (CoreAudio)   HALC_ProxyIOContext.cpp:3410   HALC_IOContext_ResumeIO(5523)
2026-06-26 22:13:08.803 Df NeonDrift.run.1782483119.37854[39698:88303e] (CoreAudio)   HALC_ProxyIOContext.cpp:1146   HALC_ProxyIOContext::PauseIO: -> 0 0 0, id:5523 called from HALC_IOContext_PauseIO
2026-06-26 22:13:08.803 Df NeonDrift.run.1782483119.37854[39698:88303e] (CoreAudio)   HALC_ProxyIOContext.cpp:1159   HALC_ProxyIOContext::PauseIO: <- 0 1 1, id:5523 called from HALC_IOContext_PauseIO
2026-06-26 22:13:08.803 Df NeonDrift.run.1782483119.37854[39698:88303e] (CoreAudio)   HALC_ProxyIOContext.cpp:1193   HALC_ProxyIOContext::ResumeIO: -> 0 1 1 id:5523 called from HALC_IOContext_ResumeIO
2026-06-26 22:13:08.803 Df NeonDrift.run.1782483119.37854[39698:88303e] (CoreAudio)   HALC_ProxyIOContext.cpp:1210   HALC_ProxyIOContext::ResumeIO: <- 0 0 0 id:5523 called from HALC_IOContext_ResumeIO
2026-06-26 22:13:09.218 Df NeonDrift.run.1782483119.37854[39698:88302a] (CoreAudio)   HALC_ProxyIOContext.cpp:3376   HALC_IOContext_PauseIO(5524)
2026-06-26 22:13:09.218 Df NeonDrift.run.1782483119.37854[39698:88302a] (CoreAudio)   HALC_ProxyIOContext.cpp:3410   HALC_IOContext_ResumeIO(5524)
2026-06-26 22:13:09.218 Df NeonDrift.run.1782483119.37854[39698:88302b] (CoreAudio)   HALC_ProxyIOContext.cpp:1146   HALC_ProxyIOContext::PauseIO: -> 0 0 0, id:5524 called from HALC_IOContext_PauseIO
2026-06-26 22:13:09.218 Df NeonDrift.run.1782483119.37854[39698:88302b] (CoreAudio)   HALC_ProxyIOContext.cpp:1159   HALC_ProxyIOContext::PauseIO: <- 0 1 1, id:5524 called from HALC_IOContext_PauseIO
2026-06-26 22:13:09.218 Df NeonDrift.run.1782483119.37854[39698:88302b] (CoreAudio)   HALC_ProxyIOContext.cpp:1193   HALC_ProxyIOContext::ResumeIO: -> 0 1 1 id:5524 called from HALC_IOContext_ResumeIO
2026-06-26 22:13:09.218 Df NeonDrift.run.1782483119.37854[39698:88302b] (CoreAudio)   HALC_ProxyIOContext.cpp:1210   HALC_ProxyIOContext::ResumeIO: <- 0 0 0 id:5524 called from HALC_IOContext_ResumeIO
2026-06-26 22:13:09.303 Df NeonDrift.run.1782483119.37854[39698:88302b] [com.apple.coreaudio:as_client] AVAudioSessionImpl_Simulator.mm:111   Set volume on device 92 to 0.60
2026-06-26 22:13:09.305 Df NeonDrift.run.1782483119.37854[39698:88302a] [com.apple.coreaudio:as_client] AVAudioSessionImpl_Simulator.mm:111   Set volume on device 92 to 0.60
2026-06-26 22:13:09.309 Df NeonDrift.run.1782483119.37854[39698:88302b] [com.apple.coreaudio:as_client] AVAudioSessionImpl_Simulator.mm:111   Set volume on device 92 to 0.60
2026-06-26 22:13:09.312 Df NeonDrift.run.1782483119.37854[39698:88302a] [com.apple.coreaudio:as_client] AVAudioSessionImpl_Simulator.mm:111   Set volume on device 92 to 0.60
2026-06-26 22:13:09.314 Df NeonDrift.run.1782483119.37854[39698:88302a] [com.apple.coreaudio:as_client] AVAudioSessionImpl_Simulator.mm:111   Set volume on device 92 to 0.60
2026-06-26 22:13:09.317 Df NeonDrift.run.1782483119.37854[39698:88302a] [com.apple.coreaudio:as_client] AVAudioSessionImpl_Simulator.mm:111   Set volume on device 92 to 0.60
2026-06-26 22:13:39.398 Df CoreSimulatorBridge[13156:882f64] Request received for installation of file:///Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.run.1782483119.37854.app/ with options: {
    PackageType = Developer;
    SimulatorRootPath = "/Library/Developer/CoreSimulator/Volumes/iOS_23F77/Library/Developer/CoreSimulator/Profiles/Runtimes/iOS 26.5.simruntime/Contents/Resources/RuntimeRoot";
    SimulatorUserPath = "/Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data";
}
2026-06-26 22:13:39.398 Df CoreSimulatorBridge[13156:882f64] [com.apple.installcoordination:framework] +[IXAppInstallCoordinator(IXSimpleInstaller) _beginInstallForURL:forPersonaUniqueString:consumeSource:options:progressBlock:completionWithIdentity:]: Beginning install for /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.run.1782483119.37854.app consuming source:N options:{
    IsUserInitiated = 1;
    PackageType = Developer;
} installationRequestorAuditToken: NULL
2026-06-26 22:13:39.401 Df installcoordinationd[26512:8823cb] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager registerPromise:]: Registered promise <IXSPlaceholder(0x105510500) Name:App Placeholder: NeonDrift.run.1782483119.37854 (com.DefaultCompany.NeonDrift.run.1782483119.37854) Creator:InstallCoordination Simple SPI UUID:A80A1FE8-28A1-42C0-95A7-0C88DB706B76 Location:[system-defined]> for UUID A80A1FE8-28A1-42C0-95A7-0C88DB706B76
2026-06-26 22:13:39.402 Df installcoordinationd[26512:8823cb] [com.apple.installcoordination:daemon] -[IXSPlaceholder setAttributes:]: <IXSPlaceholder(0x105510500) Name:App Placeholder: NeonDrift.run.1782483119.37854 (com.DefaultCompany.NeonDrift.run.1782483119.37854) Creator:InstallCoordination Simple SPI UUID:A80A1FE8-28A1-42C0-95A7-0C88DB706B76 Location:[system-defined]>: setting placeholder attributes to <IXPlaceholderAttributes<0x1054a14a0> : {
    CFBundleShortVersionString = "1.0";
    CFBundleSupportedPlatforms =     (
        iPhoneSimulator
    );
    CFBundleVersion = 0;
    DTPlatformName = iphonesimulator;
    LSRequiresIPhoneOS = 1;
    MinimumOSVersion = "13.0";
    UIDeviceFamily =     (
        1,
        2
    );
    UIRequiredDeviceCapabilities =     {
        arm64 = 1;
        metal = 1;
    };
}>
2026-06-26 22:13:39.403 Df CoreSimulatorBridge[13156:882f66] [com.apple.installcoordination:framework] +[IXPlaceholder _setEntitlementsFromBundleExecutableURL:withBundleID:client:onPlaceholder:location:error:]: Executable for com.DefaultCompany.NeonDrift.run.1782483119.37854 at NeonDrift.run.1782483119.37854 -- file:///Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.run.1782483119.37854.app/ had no entitlements
2026-06-26 22:13:39.403 Df CoreSimulatorBridge[13156:882f66] [com.apple.installcoordination:framework] +[IXPlaceholder _placeholderForBundle:client:withParent:installType:metadata:placeholderType:mayBeDeltaPackage:isFromSerializedPlaceholder:location:error:]: Using full fidelity icons for com.DefaultCompany.NeonDrift.run.1782483119.37854 at /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.run.1782483119.37854.app
2026-06-26 22:13:39.403 Df installcoordinationd[26512:8823cb] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager registerPromise:]: Registered promise <IXSPromisedTransferToPath(0x1054de680) Name:Icon resources for com.DefaultCompany.NeonDrift.run.1782483119.37854 Creator:InstallCoordination Simple SPI UUID:E77AEF05-C555-40C4-9A4C-738734529CBA Location:[system-defined]> for UUID E77AEF05-C555-40C4-9A4C-738734529CBA
2026-06-26 22:13:39.407 Df CoreSimulatorBridge[13156:882f66] [com.apple.installcoordination:framework] -[IXPromisedTransferToPath setComplete:]: <IXPromisedTransferToPath<0x103458300> name:"Icon resources for com.DefaultCompany.NeonDrift.run.1782483119.37854" uuid:E77AEF05-C555-40C4-9A4C-738734529CBA creator:"InstallCoordination Simple SPI" location:[system-defined]> Move operation from /Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data/Containers/Shared/SystemGroup/systemgroup.com.apple.installcoordinationd/Library/InstallCoordination/PromiseStaging/E77AEF05-C555-40C4-9A4C-738734529CBA/temp.plP47a to /Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-46
```
