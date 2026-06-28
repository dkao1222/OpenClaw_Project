# QA Evidence Summary

## Build
```text
# Game Build Validation Report

- project_name: NeonDrift_MVP
- run_id: notion-NeonDrift_MVP-build-build-ios-simulator-20260627151421
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
- PASS unity_build_workspace_prepared: /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/unity_build_workspace/NeonDrift.run.1782573263.85778
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
/Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.run.1782573263.85778.app/NeonDrift.run.1782573263.85778: Mach-O 64-bit executable arm64

```

## App Info
```text
{
    ApplicationType = User;
    Bundle = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Bundle/Application/DF33DF21-5A51-4651-B4B5-F0C0DDC499D1/NeonDrift.run.1782573263.85778.app/";
    BundleContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Bundle/Application/DF33DF21-5A51-4651-B4B5-F0C0DDC499D1/";
    CFBundleDisplayName = "NeonDrift.run.1782573263.85778";
    CFBundleExecutable = "NeonDrift.run.1782573263.85778";
    CFBundleIdentifier = "com.DefaultCompany.NeonDrift.run.1782573263.85778";
    CFBundleName = "NeonDrift.run.1782573263.85778";
    CFBundleVersion = 0;
    DataContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Data/Application/DDAB4FDA-59AD-4E0E-B5FE-65F0074594B1/";
    GroupContainers =     {
    };
    Path = "/Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Bundle/Application/DF33DF21-5A51-4651-B4B5-F0C0DDC499D1/NeonDrift.run.1782573263.85778.app";
    SBAppTags =     (
    );
}

```

## Launch
```text
com.DefaultCompany.NeonDrift.run.1782573263.85778: 88467

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
2026-06-27 23:15:24.527 E  SpringBoard[84835:bb3004] [com.apple.UIKit:KeyboardArbiter] [<_UIKeyboardArbiterClientHandle: 0x12b78f3a0; [app<com.DefaultCompany.NeonDrift.run.1782573263.85778((null))>:87381] <<UIKBArbiterClientFocusContext: 0x10cd58d80; contextID = ae03e1b8; sceneIdentity = com.apple.frontboard.systemappservices/FBSceneManager:sceneID%3Acom.DefaultCompany.NeonDrift.run.1782573263.85778-default >>; hosting PIDs {(
)}; level 0.000000; active NO [wants NO]; suppression 0; iav 0.000000; on screen NO; isAcquiringFocus: YES>] Acquiring focus timer elapsed, clearing acquiring focus state
2026-06-27 23:17:05.640 Df NeonDrift.run.1782573263.85778[87381:bb3048] [com.apple.xpc:connection] [0x116d78280] Re-initialization successful; calling out to event handler with XPC_ERROR_CONNECTION_INTERRUPTED
2026-06-27 23:17:08.313 Df SpringBoard[88124:bb4429] [com.apple.frontboard.ApplicationLibrary:default] Added application: <SBApplicationInfo: 0x10a236400; com.DefaultCompany.NeonDrift.run.1782573263.85778 (NeonDrift.run.1782573263.85778)>
2026-06-27 23:17:08.321 Df SpringBoard[88124:bb4429] [com.apple.appinstallation:TransactionLog] com.DefaultCompany.NeonDrift.run.1782573263.85778/Unknown Persona:10:10:3:1:Application added
2026-06-27 23:17:08.385 Df SpringBoard[88124:bb4429] [com.apple.SpringBoard:Icon] <<SBLeafIcon:0x10a15c900 [com.DefaultCompany.NeonDrift.run.1782573263.85778]>> Changing active data source: <SBApplicationIcon: 0x10a15c900; nodeID: com.DefaultCompany.NeonDrift.run.1782573263.85778; bundleID: com.DefaultCompany.NeonDrift.run.1782573263.85778>
2026-06-27 23:17:08.385 Df SpringBoard[88124:bb4429] [com.apple.SpringBoard:Icon] <<SBLeafIcon:0x10a15c900 [com.DefaultCompany.NeonDrift.run.1782573263.85778]>> Changing from data souce: (null) to data source:com.DefaultCompany.NeonDrift.run.1782573263.85778.
2026-06-27 23:17:08.390 Df SpringBoard[88124:bb4429] [com.apple.SplashBoard:FileManifest] com.DefaultCompany.NeonDrift.run.1782573263.85778 Manifest is empty; purging everything at /Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Data/Application/B3AC0C4E-1EBC-46B5-B67F-51ADB258B254/Library/SplashBoard/Snapshots
2026-06-27 23:17:09.173 Df SpringBoard[88124:bb45de] [com.apple.UserNotifications:DataStore] Creating library mapping from com.DefaultCompany.NeonDrift.run.1782573263.85778 to BEA89DF4-07A2-4F63-BBE7-D7DB1A1DF13C
2026-06-27 23:17:09.390 Df SpringBoard[88124:bb4429] [com.apple.SpringBoard:ProactiveAppLibrary] Initialized app library w/ persisted library category map: <SBHLibraryMutableCategoryMap: 0x12214b3c0; generatedDate: 2026-06-27 15:15:18 +0000; uniqueIdentifier: E90B712D-D1B2-4E65-ACB1-092155F21C4C; loadedFromDisk: YES; _localizedCategoryNameByCategoryIdentifier: (empty)> categoryIdentifiers = {
    3000;
    3001;
}
sortedApplicationIdentifiersByCategoryIdentifier = {
    <SBHLibraryCategoryIdentifier: 0x1223e0c00; localizedDisplayName: Other> = {
        com.DefaultCompany.NeonDrift;
        com.DefaultCompany.NeonDrift.run.1782484282.54413;
        com.DefaultCompany.NeonDrift.run.1782484537.59589;
        com.DefaultCompany.NeonDrift.run.1782484808.68182;
        com.DefaultCompany.NeonDrift.run.1782485248.76636;
        com.DefaultCompany.NeonDrift.run.1782485533.82553;
        com.DefaultCompany.NeonDrift.run.1782486232.95300;
        com.DefaultCompany.NeonDrift.run.1782493753.82761;
        com.DefaultCompany.NeonDrift.run.1782573263.85778;
    }
    <SBHLibraryCategoryIdentifier: 0x1223e0690; localizedDisplayName: " System"> = {
        com.app
2026-06-27 23:17:09.435 Df SpringBoard[88124:bb4429] [com.apple.SpringBoard:Library] Installing category map <SBHLibraryMutableCategoryMap: 0x12214b3c0; generatedDate: 2026-06-27 15:15:18 +0000; uniqueIdentifier: E90B712D-D1B2-4E65-ACB1-092155F21C4C; loadedFromDisk: YES; _localizedCategoryNameByCategoryIdentifier: (empty)> categoryIdentifiers = {
    3000;
    3001;
}
sortedApplicationIdentifiersByCategoryIdentifier = {
    <SBHLibraryCategoryIdentifier: 0x1223e0c00; localizedDisplayName: Other> = {
        com.DefaultCompany.NeonDrift;
        com.DefaultCompany.NeonDrift.run.1782484282.54413;
        com.DefaultCompany.NeonDrift.run.1782484537.59589;
        com.DefaultCompany.NeonDrift.run.1782484808.68182;
        com.DefaultCompany.NeonDrift.run.1782485248.76636;
        com.DefaultCompany.NeonDrift.run.1782485533.82553;
        com.DefaultCompany.NeonDrift.run.1782486232.95300;
        com.DefaultCompany.NeonDrift.run.1782493753.82761;
        com.DefaultCompany.NeonDrift.run.1782573263.85778;
    }
    <SBHLibraryCategoryIdentifier: 0x1223e0690; localizedDisplayName: " System"> = {
        com.app - animated <decode: missing data>
2026-06-27 23:17:09.439 Df SpringBoard[88124:bb4627] [com.apple.SplashBoard:FileManifest] <XBApplicationSnapshotManifestImpl: 0x10a393280> [com.DefaultCompany.NeonDrift.run.1782573263.85778] We don't have any snapshots, so we're clearing our manifest data.
2026-06-27 23:17:09.765 Df SpringBoard[88124:bb45de] [com.apple.UserNotifications:DataProviderFactory] [com.DefaultCompany.NeonDrift.run.1782573263.85778] Application installed using default data provider
2026-06-27 23:17:11.092 Df CoreSimulatorBridge[88162:bb4469] Request received for installation of file:///Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.run.1782573263.85778.app/ with options: {
    PackageType = Developer;
    SimulatorRootPath = "/Library/Developer/CoreSimulator/Volumes/iOS_23E254a/Library/Developer/CoreSimulator/Profiles/Runtimes/iOS 26.4.simruntime/Contents/Resources/RuntimeRoot";
    SimulatorUserPath = "/Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data";
}
2026-06-27 23:17:11.092 Df CoreSimulatorBridge[88162:bb4469] [com.apple.installcoordination:framework] +[IXAppInstallCoordinator(IXSimpleInstaller) _beginInstallForURL:forPersonaUniqueString:consumeSource:options:progressBlock:completionWithIdentity:]: Beginning install for /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.run.1782573263.85778.app consuming source:N options:{
    IsUserInitiated = 1;
    PackageType = Developer;
} installationRequestorAuditToken: NULL
2026-06-27 23:17:12.539 Df SpringBoard[88124:bb4772] [com.apple.PosterLegibilityKit:Caching] -[PLKCachedImageGenerator(SpringBoardHome Label Content Generator0x124a50300) removeImagesForCacheKeys:NeonDrift.run.1782573263.85778@@zh_TW_1368232380023648501_0__sz101.0x26.0B23CV11@@]
2026-06-27 23:17:12.655 Df installcoordinationd[88297:bb49dd] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager registerPromise:]: Registered promise <IXSPlaceholder(0x1019243c0) Name:App Placeholder: NeonDrift.run.1782573263.85778 (com.DefaultCompany.NeonDrift.run.1782573263.85778) Creator:InstallCoordination Simple SPI UUID:ADBC72DB-DE62-4DDE-8320-A9D5D7255B68 Location:[system-defined]> for UUID ADBC72DB-DE62-4DDE-8320-A9D5D7255B68
2026-06-27 23:17:12.658 Df installcoordinationd[88297:bb49dd] [com.apple.installcoordination:daemon] -[IXSPlaceholder setAttributes:]: <IXSPlaceholder(0x1019243c0) Name:App Placeholder: NeonDrift.run.1782573263.85778 (com.DefaultCompany.NeonDrift.run.1782573263.85778) Creator:InstallCoordination Simple SPI UUID:ADBC72DB-DE62-4DDE-8320-A9D5D7255B68 Location:[system-defined]>: setting placeholder attributes to <IXPlaceholderAttributes<0x1018c8b40> : {
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
    UIRequiredDeviceCapabilities = 
```
