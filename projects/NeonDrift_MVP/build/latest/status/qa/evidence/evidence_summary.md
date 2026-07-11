# QA Evidence Summary

## Build
```text
# Game Build Validation Report

- project_name: NeonDrift_MVP
- run_id: notion-NeonDrift_MVP-build-build-ios-simulator-20260711055429
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
- PASS unity_build_workspace_prepared: /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/unity_build_workspace/NeonDrift.run.1783749271.40695
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
<test-run testcasecount="34" result="Passed" total="34" passed="34" failed="0">
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
    <test-case name="FirstRunGameplayMeaningIsClear" result="Passed" />
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
    "hasTrackMeaningText": true,
    "hasControlMeaningText": true,
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
    "startButtonRect": "name=Start Button; width=390.0; height=104.0; min=(125.0,216.0); max=(515.0,320.0)",
    "settingsButtonRect": "name=Settings Button; width=390.0; height=90.0; min=(125.0,95.0); max=(515.0,185.0)",
    "pauseButtonRect": "name=Pause Button; width=96.0; height=72.0; min=(506.0,198.0); max=(602.0,270.0)",
    "retryButtonRect": "name=Retry Button; width=330.0; height=86.0; min=(155.0,38.0); max=(485.0,124.0)",
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
    "trackPurposeReadableVerified": true,
    "leftRightControlMeaningVerified": true,
    "firstRunClarityVerified": true,
    "humanReadableGameplayContractVerified": true,
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
/Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app/NeonDrift: Mach-O 64-bit executable arm64

```

## App Info
```text
{
    ApplicationType = User;
    Bundle = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Bundle/Application/E4109901-35B4-4E9A-88A1-AC1779A82DEB/NeonDrift.app/";
    BundleContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Bundle/Application/E4109901-35B4-4E9A-88A1-AC1779A82DEB/";
    CFBundleDisplayName = NeonDrift;
    CFBundleExecutable = NeonDrift;
    CFBundleIdentifier = "com.DefaultCompany.NeonDrift";
    CFBundleName = NeonDrift;
    CFBundleVersion = 0;
    DataContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Data/Application/F03CFFBC-3544-4CD7-9AA5-83A5939E7878/";
    GroupContainers =     {
    };
    Path = "/Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Bundle/Application/E4109901-35B4-4E9A-88A1-AC1779A82DEB/NeonDrift.app";
    SBAppTags =     (
    );
}

```

## Launch
```text
com.DefaultCompany.NeonDrift: 43644

```

## Screenshot
- path: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_menu.png
- exists: True
- bytes: 84081
- width: 1206
- height: 2622
- nonblank_estimate: nonblank

## Runtime Log Tail
```text
Timestamp               Ty Process[PID:TID]
2026-07-11 13:57:57.692 Df SpringBoard[43220:3bee81] [com.apple.frontboard.ApplicationLibrary:default] Added application: <SBApplicationInfo: 0x106bb8c00; com.DefaultCompany.NeonDrift.run.1782486232.95300 (NeonDrift.run.1782486232.95300)>
2026-07-11 13:57:57.692 Df SpringBoard[43220:3bee81] [com.apple.frontboard.ApplicationLibrary:default] Added application: <SBApplicationInfo: 0x10c202700; com.DefaultCompany.NeonDrift.run.1782573263.85778 (NeonDrift.run.1782573263.85778)>
2026-07-11 13:57:57.693 Df SpringBoard[43220:3bee81] [com.apple.frontboard.ApplicationLibrary:default] Added application: <SBApplicationInfo: 0x10c225200; com.DefaultCompany.NeonDrift.run.1782484808.68182 (NeonDrift.run.1782484808.68182)>
2026-07-11 13:57:57.693 Df SpringBoard[43220:3bee81] [com.apple.frontboard.ApplicationLibrary:default] Added application: <SBApplicationInfo: 0x10c227300; com.DefaultCompany.NeonDrift (NeonDrift)>
2026-07-11 13:57:57.693 Df SpringBoard[43220:3bee81] [com.apple.frontboard.ApplicationLibrary:default] Added application: <SBApplicationInfo: 0x10c259200; com.DefaultCompany.NeonDrift.run.1782493753.82761 (NeonDrift.run.1782493753.82761)>
2026-07-11 13:57:57.694 Df SpringBoard[43220:3bee81] [com.apple.frontboard.ApplicationLibrary:default] Added application: <SBApplicationInfo: 0x10c28a700; com.DefaultCompany.NeonDrift.run.1782485248.76636 (NeonDrift.run.1782485248.76636)>
2026-07-11 13:57:57.694 Df SpringBoard[43220:3bee81] [com.apple.frontboard.ApplicationLibrary:default] Added application: <SBApplicationInfo: 0x10c28bc00; com.DefaultCompany.NeonDrift.run.1782485533.82553 (NeonDrift.run.1782485533.82553)>
2026-07-11 13:57:57.694 Df SpringBoard[43220:3bee81] [com.apple.frontboard.ApplicationLibrary:default] Added application: <SBApplicationInfo: 0x10c2a5500; com.DefaultCompany.NeonDrift.run.1782638094.21137 (NeonDrift.run.1782638094.21137)>
2026-07-11 13:57:57.694 Df SpringBoard[43220:3bee81] [com.apple.frontboard.ApplicationLibrary:default] Added application: <SBApplicationInfo: 0x10c2a4900; com.DefaultCompany.NeonDrift.run.1782650479.26426 (NeonDrift.run.1782650479.26426)>
2026-07-11 13:57:57.695 Df SpringBoard[43220:3bee81] [com.apple.frontboard.ApplicationLibrary:default] Added application: <SBApplicationInfo: 0x10c2a7600; com.DefaultCompany.NeonDrift.run.1782484537.59589 (NeonDrift.run.1782484537.59589)>
2026-07-11 13:57:57.696 Df SpringBoard[43220:3bee81] [com.apple.frontboard.ApplicationLibrary:default] Added application: <SBApplicationInfo: 0x10c2db600; com.DefaultCompany.NeonDrift.run.1782641020.54193 (NeonDrift.run.1782641020.54193)>
2026-07-11 13:57:57.696 Df SpringBoard[43220:3bee81] [com.apple.frontboard.ApplicationLibrary:default] Added application: <SBApplicationInfo: 0x10c31aa00; com.DefaultCompany.NeonDrift.run.1782484282.54413 (NeonDrift.run.1782484282.54413)>
2026-07-11 13:57:57.700 Df SpringBoard[43220:3bee81] [com.apple.appinstallation:TransactionLog] com.DefaultCompany.NeonDrift.run.1782650479.26426/Unknown Persona:10:10:3:1:Application added
2026-07-11 13:57:57.701 Df SpringBoard[43220:3bee81] [com.apple.appinstallation:TransactionLog] com.DefaultCompany.NeonDrift.run.1782638094.21137/Unknown Persona:10:10:3:1:Application added
2026-07-11 13:57:57.703 Df SpringBoard[43220:3bee81] [com.apple.appinstallation:TransactionLog] com.DefaultCompany.NeonDrift.run.1782484537.59589/Unknown Persona:10:10:3:1:Application added
2026-07-11 13:57:57.706 Df SpringBoard[43220:3bee81] [com.apple.appinstallation:TransactionLog] com.DefaultCompany.NeonDrift.run.1782484808.68182/Unknown Persona:10:10:3:1:Application added
2026-07-11 13:57:57.710 Df SpringBoard[43220:3bee81] [com.apple.appinstallation:TransactionLog] com.DefaultCompany.NeonDrift/Unknown Persona:10:10:3:1:Application added
2026-07-11 13:57:57.714 Df SpringBoard[43220:3bee81] [com.apple.appinstallation:TransactionLog] com.DefaultCompany.NeonDrift.run.1782493753.82761/Unknown Persona:10:10:3:1:Application added
2026-07-11 13:57:57.714 Df SpringBoard[43220:3bee81] [com.apple.appinstallation:TransactionLog] com.DefaultCompany.NeonDrift.run.1782641020.54193/Unknown Persona:10:10:3:1:Application added
2026-07-11 13:57:57.717 Df SpringBoard[43220:3bee81] [com.apple.appinstallation:TransactionLog] com.DefaultCompany.NeonDrift.run.1782573263.85778/Unknown Persona:10:10:3:1:Application added
2026-07-11 13:57:57.723 Df SpringBoard[43220:3bee81] [com.apple.appinstallation:TransactionLog] com.DefaultCompany.NeonDrift.run.1782485248.76636/Unknown Persona:10:10:3:1:Application added
2026-07-11 13:57:57.723 Df SpringBoard[43220:3bee81] [com.apple.appinstallation:TransactionLog] com.DefaultCompany.NeonDrift.run.1782486232.95300/Unknown Persona:10:10:3:1:Application added
2026-07-11 13:57:57.723 Df SpringBoard[43220:3bee81] [com.apple.appinstallation:TransactionLog] com.DefaultCompany.NeonDrift.run.1782484282.54413/Unknown Persona:10:10:3:1:Application added
2026-07-11 13:57:57.725 Df SpringBoard[43220:3bee81] [com.apple.appinstallation:TransactionLog] com.DefaultCompany.NeonDrift.run.1782485533.82553/Unknown Persona:10:10:3:1:Application added
2026-07-11 13:57:57.740 Df SpringBoard[43220:3bee81] [com.apple.SpringBoard:Common] Installed apps did change.
Added: {(
    "com.apple.BarcodeScanner",
    "com.DefaultCompany.NeonDrift.run.1782484282.54413",
    "com.apple.Passwords",
    "com.apple.SleepLockScreen",
    "com.apple.MediaRemoteUIService",
    "com.apple.BrowserKitViewService",
    "com.apple.GameCenterRemoteAlert",
    "com.apple.FaceTimeLinkTrampoline",
    "com.apple.shortcuts",
    "com.apple.PeopleViewService",
    "com.apple.PASViewService",
    "com.apple.ActivityProgress.ActivityProgressUI",
    "com.apple.AppSSOUIService",
    "com.apple.BusinessChatViewService",
    "com.apple.systemactions",
    "com.apple.mobilesms.compose",
    "com.apple.AuthenticationServicesUI",
    "com.apple.NetworkEndpointPickerUI",
    "com.apple.AMSUIAuthenticationViewService",
    "com.apple.WorkoutRemoteViewService",
    "com.apple.HearingApp",
    "com.apple.shortcuts.runtime",
    "com.apple.PassbookUISceneService",
    "com.apple.AccessoryNotifications.SourceSelection",
    "com.apple.CredentialSharingService",
    "com.apple.FinanceStub",
    "com.DefaultC
Removed: <decode: missing data>
Replaced: <decode: missing data>
Updated: <decode: missing data>
2026-07-11 13:57:57.770 Df SpringBoard[43220:3bee81] [com.apple.SpringBoard:Icon] <<SBLeafIcon:0x10c36b0c0 [com.DefaultCompany.NeonDrift.run.1782484282.54413]>> Changing active data source: <SBApplicationIcon: 0x10c36b0c0; nodeID: com.DefaultCompany.NeonDrift.run.1782484282.54413; bundleID: com.DefaultCompany.NeonDrift.run.1782484282.54413>
2026-07-11 13:57:57.770 Df SpringBoard[43220:3bee81] [com.apple.SpringBoard:Icon] <<SBLeafIcon:0x10c36b0c0 [com.DefaultCompany.NeonDrift.run.1782484282.54413]>> Changing from data souce: (null) to data source:com.DefaultCompany.NeonDrift.run.1782484282.54413.
2026-07-11 13:57:57.772 Df SpringBoard[43220:3bee81] [com.apple.SpringBoard:Icon] <<SBLeafIcon:0x10c369f80 [com.DefaultCompany.NeonDrift.run.1782485533.82553]>> Changing active data source: <SBApplicationIcon: 0x10c369f80; nodeID: com.DefaultCompany.NeonDrift.run.1782485533.82553; bundleID: com.DefaultCompany.NeonDrift.run.1782485533.82553>
2026-07-11 13:57:57.772 Df SpringBoard[43220:3bee81] [com.apple.SpringBoard:Icon] <<SBLeafIcon:0x10c369f80 [com.DefaultCompany.NeonDrift.run.1782485533.82553]>> Changing from data souce: (null) to data source:com.DefaultCompany.NeonDrift.run.1782485533.82553.
2026-07-11 13:57:57.772 Df SpringBoard[43220:3bee81] [com.apple.SpringBoard:Icon] <<SBLeafIcon:0x10c369bc0 [com.DefaultCompany.NeonDrift.run.1782638094.21137]>> Changing active data source: <SBApplicationIcon: 0x10c369bc0; nodeID: com.DefaultCompany.NeonDrift.run.1782638094.21137; bundleID: com.DefaultCompany.NeonDrift.run.1782638094.21137>
2026-07-11 13:57:57.772 Df SpringBoard[43220:3bee81] [com.apple.SpringBoard:Icon] <<SBLeafI
```
