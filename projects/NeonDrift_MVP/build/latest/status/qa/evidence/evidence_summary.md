# QA Evidence Summary

## Build
```text
# Game Build Validation Report

- project_name: NeonDrift_MVP
- run_id: notion-NeonDrift_MVP-build-build-ios-simulator-20260626141753
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
- PASS unity_build_workspace_prepared: /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/unity_build_workspace/NeonDrift.run.1782483479.44964
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
/Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.run.1782483479.44964.app/NeonDrift.run.1782483479.44964: Mach-O 64-bit executable arm64

```

## App Info
```text
{
    ApplicationType = User;
    Bundle = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data/Containers/Bundle/Application/ED5C1ED9-2529-4740-8114-DA1108D0DA32/NeonDrift.run.1782483479.44964.app/";
    BundleContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data/Containers/Bundle/Application/ED5C1ED9-2529-4740-8114-DA1108D0DA32/";
    CFBundleDisplayName = "NeonDrift.run.1782483479.44964";
    CFBundleExecutable = "NeonDrift.run.1782483479.44964";
    CFBundleIdentifier = "com.DefaultCompany.NeonDrift.run.1782483479.44964";
    CFBundleName = "NeonDrift.run.1782483479.44964";
    CFBundleVersion = 0;
    DataContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data/Containers/Data/Application/28B3D79C-2A02-4507-9E62-673AB0A4A36D/";
    GroupContainers =     {
    };
    Path = "/Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data/Containers/Bundle/Application/ED5C1ED9-2529-4740-8114-DA1108D0DA32/NeonDrift.run.1782483479.44964.app";
    SBAppTags =     (
    );
}

```

## Launch
```text
com.DefaultCompany.NeonDrift.run.1782483479.44964: 46296

```

## Screenshot
- path: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_menu.png
- exists: True
- bytes: 79109
- width: 1206
- height: 2622
- nonblank_estimate: nonblank

## Runtime Log Tail
```text
Timestamp               Ty Process[PID:TID]
2026-06-26 22:18:45.391 Df CoreSimulatorBridge[13156:887c08] Request received for installation of file:///Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.run.1782483479.44964.app/ with options: {
    PackageType = Developer;
    SimulatorRootPath = "/Library/Developer/CoreSimulator/Volumes/iOS_23F77/Library/Developer/CoreSimulator/Profiles/Runtimes/iOS 26.5.simruntime/Contents/Resources/RuntimeRoot";
    SimulatorUserPath = "/Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data";
}
2026-06-26 22:18:45.391 Df CoreSimulatorBridge[13156:887c08] [com.apple.installcoordination:framework] +[IXAppInstallCoordinator(IXSimpleInstaller) _beginInstallForURL:forPersonaUniqueString:consumeSource:options:progressBlock:completionWithIdentity:]: Beginning install for /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.run.1782483479.44964.app consuming source:N options:{
    IsUserInitiated = 1;
    PackageType = Developer;
} installationRequestorAuditToken: NULL
2026-06-26 22:18:45.393 Df installcoordinationd[26512:8823cb] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager registerPromise:]: Registered promise <IXSPlaceholder(0x105510500) Name:App Placeholder: NeonDrift.run.1782483479.44964 (com.DefaultCompany.NeonDrift.run.1782483479.44964) Creator:InstallCoordination Simple SPI UUID:BEEDDDB9-46EB-4A6E-98C3-A5561D74FBDA Location:[system-defined]> for UUID BEEDDDB9-46EB-4A6E-98C3-A5561D74FBDA
2026-06-26 22:18:45.394 Df installcoordinationd[26512:8823cb] [com.apple.installcoordination:daemon] -[IXSPlaceholder setAttributes:]: <IXSPlaceholder(0x105510500) Name:App Placeholder: NeonDrift.run.1782483479.44964 (com.DefaultCompany.NeonDrift.run.1782483479.44964) Creator:InstallCoordination Simple SPI UUID:BEEDDDB9-46EB-4A6E-98C3-A5561D74FBDA Location:[system-defined]>: setting placeholder attributes to <IXPlaceholderAttributes<0x1054a0dc0> : {
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
2026-06-26 22:18:45.394 Df CoreSimulatorBridge[13156:8846d8] [com.apple.installcoordination:framework] +[IXPlaceholder _setEntitlementsFromBundleExecutableURL:withBundleID:client:onPlaceholder:location:error:]: Executable for com.DefaultCompany.NeonDrift.run.1782483479.44964 at NeonDrift.run.1782483479.44964 -- file:///Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.run.1782483479.44964.app/ had no entitlements
2026-06-26 22:18:45.394 Df CoreSimulatorBridge[13156:8846d8] [com.apple.installcoordination:framework] +[IXPlaceholder _placeholderForBundle:client:withParent:installType:metadata:placeholderType:mayBeDeltaPackage:isFromSerializedPlaceholder:location:error:]: Using full fidelity icons for com.DefaultCompany.NeonDrift.run.1782483479.44964 at /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.run.1782483479.44964.app
2026-06-26 22:18:45.395 Df installcoordinationd[26512:8823cb] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager registerPromise:]: Registered promise <IXSPromisedTransferToPath(0x1054dd800) Name:Icon resources for com.DefaultCompany.NeonDrift.run.1782483479.44964 Creator:InstallCoordination Simple SPI UUID:A841A268-9BF6-46EA-8149-56AEBFD199F8 Location:[system-defined]> for UUID A841A268-9BF6-46EA-8149-56AEBFD199F8
2026-06-26 22:18:45.398 Df CoreSimulatorBridge[13156:8846d8] [com.apple.installcoordination:framework] -[IXPromisedTransferToPath setComplete:]: <IXPromisedTransferToPath<0x1034588c0> name:"Icon resources for com.DefaultCompany.NeonDrift.run.1782483479.44964" uuid:A841A268-9BF6-46EA-8149-56AEBFD199F8 creator:"InstallCoordination Simple SPI" location:[system-defined]> Move operation from /Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data/Containers/Shared/SystemGroup/systemgroup.com.apple.installcoordinationd/Library/InstallCoordination/PromiseStaging/A841A268-9BF6-46EA-8149-56AEBFD199F8/temp.tdZDQ0 to /Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data/Containers/Shared/SystemGroup/systemgroup.com.apple.installcoordinationd/Library/InstallCoordination/PromiseStaging/A841A268-9BF6-46EA-8149-56AEBFD199F8/temp.tdZDQ0 took 0.000058 seconds
2026-06-26 22:18:45.399 Df installcoordinationd[26512:8823cb] [com.apple.installcoordination:daemon] -[IXSDataPromise _setPercentComplete:saveStateIfNeeded:]: Progress: <IXSPromisedTransferToPath(0x1054dd800) Name:Icon resources for com.DefaultCompany.NeonDrift.run.1782483479.44964 Creator:InstallCoordination Simple SPI UUID:A841A268-9BF6-46EA-8149-56AEBFD199F8 Location:[system-defined]>
2026-06-26 22:18:45.399 Df installcoordinationd[26512:886baa] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promiseDidBegin:]: Unowned promise began: <IXSPromisedTransferToPath(0x1054dd800) Name:Icon resources for com.DefaultCompany.NeonDrift.run.1782483479.44964 Creator:InstallCoordination Simple SPI UUID:A841A268-9BF6-46EA-8149-56AEBFD199F8 Location:[system-defined]>
2026-06-26 22:18:45.399 Df installcoordinationd[26512:886baa] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promise:didUpdateProgress:]: Unowned promise update progress to 1.000000 : <IXSPromisedTransferToPath(0x1054dd800) Name:Icon resources for com.DefaultCompany.NeonDrift.run.1782483479.44964 Creator:InstallCoordination Simple SPI UUID:A841A268-9BF6-46EA-8149-56AEBFD199F8 Location:[system-defined]>
2026-06-26 22:18:45.399 Df installcoordinationd[26512:886baa] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promiseDidComplete:]: Unowned promise completed: <IXSPromisedTransferToPath(0x1054dd800) Name:Icon resources for com.DefaultCompany.NeonDrift.run.1782483479.44964 Creator:InstallCoordination Simple SPI UUID:A841A268-9BF6-46EA-8149-56AEBFD199F8 Location:[system-defined]>
2026-06-26 22:18:45.400 Df installcoordinationd[26512:8823cb] [com.apple.installcoordination:daemon] -[IXSDataPromise _setPercentComplete:saveStateIfNeeded:]: Progress: <IXSPromisedInMemoryDictionary(0x1054de300) Name:Info.plist icon content for com.DefaultCompany.NeonDrift.run.1782483479.44964 Creator:InstallCoordination Simple SPI UUID:1334A95B-001B-478E-9568-3853F53027D8 Location:[system-defined]>
2026-06-26 22:18:45.401 Df installcoordinationd[26512:8823cb] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager registerPromise:]: Registered promise <IXSPromisedInMemoryDictionary(0x1054de300) Name:Info.plist icon content for com.DefaultCompany.NeonDrift.run.1782483479.44964 Creator:InstallCoordination Simple SPI UUID:1334A95B-001B-478E-9568-3853F53027D8 Location:[system-defined]> for UUID 1334A95B-001B-478E-9568-3853F53027D8
2026-06-26 22:18:45.401 Df installcoordinationd[26512:88c0a3] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promiseDidBegin:]: Unowned promise began: <IXSPromisedInMemoryDictionary(0x1054de300) Name:Info.plist icon content for com.DefaultCompany.NeonDrift.run.1782483479.44964 Creator:InstallCoordination Simple SPI UUID:1334A95B-001B-478E-9568-3853F53027D8 Location:[system-defined]>
2026-06-26 22:18:45.401 Df installcoordinationd[26512:88c0a3] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promise:didUpdateProgress:]: Unowned promise upd
```
