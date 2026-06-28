# QA Evidence Summary

## Build
```text
# Game Build Validation Report

- project_name: NeonDrift_MVP
- run_id: notion-NeonDrift_MVP-build-build-ios-simulator-20260628091429
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
- PASS unity_build_workspace_prepared: /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/unity_build_workspace/NeonDrift.run.1782638094.21137
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
/Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.run.1782638094.21137.app/NeonDrift.run.1782638094.21137: Mach-O 64-bit executable arm64

```

## App Info
```text
{
    ApplicationType = User;
    Bundle = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Bundle/Application/E94F1934-984A-4F70-890F-98DD22CB7F2D/NeonDrift.run.1782638094.21137.app/";
    BundleContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Bundle/Application/E94F1934-984A-4F70-890F-98DD22CB7F2D/";
    CFBundleDisplayName = "NeonDrift.run.1782638094.21137";
    CFBundleExecutable = "NeonDrift.run.1782638094.21137";
    CFBundleIdentifier = "com.DefaultCompany.NeonDrift.run.1782638094.21137";
    CFBundleName = "NeonDrift.run.1782638094.21137";
    CFBundleVersion = 0;
    DataContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Data/Application/CB101454-E329-4408-9809-D723A00F7730/";
    GroupContainers =     {
    };
    Path = "/Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Bundle/Application/E94F1934-984A-4F70-890F-98DD22CB7F2D/NeonDrift.run.1782638094.21137.app";
    SBAppTags =     (
    );
}

```

## Launch
```text
com.DefaultCompany.NeonDrift.run.1782638094.21137: 29116

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
2026-06-28 17:18:07.491 Df SpringBoard[24827:d87b53] [com.apple.SplashBoard:FileManifest] <XBApplicationSnapshotManifestImpl: 0x107ba3280> [com.DefaultCompany.NeonDrift.run.1782638094.21137] We don't have any snapshots, so we're clearing our manifest data.
2026-06-28 17:19:49.856 Df backboardd[24850:d89555] [com.apple.iohid:default] Connection removed: IOHIDEventSystemConnection uuid:2E424BE3-7A10-4D6D-B939-261BFFF4ED4C pid:25460 process:NeonDrift.run.1782638094.21137 type:Passive entitlements:0x0 caller:BackBoardServices: ___getHIDEventSystemClient_block_invoke + 296 attributes:{
    HighFrequency = 0;
    bundleID = "com.DefaultCompany.NeonDrift.run.1782638094.21137";
    pid = 25460;
} state:0x1 events:0 mask:0x0 dropped:0 dropStatus:0 droppedMask:0x0 lastDroppedTime:NONE
2026-06-28 17:19:49.856 Df backboardd[24850:d89555] [com.apple.BackBoard:HID] Removing client connection <BKHIDClientConnection: 0x10bcc8180; IOHIDEventSystemConnectionRef: 0x10a51f400; vpid: 25460(v44A84C); taskPort: 0x23BC3; bundleID: com.DefaultCompany.NeonDrift.run.1782638094.21137> for client: IOHIDEventSystemConnection uuid:2E424BE3-7A10-4D6D-B939-261BFFF4ED4C pid:25460 process:NeonDrift.run.1782638094.21137 type:Passive entitlements:0x0 caller:BackBoardServices: ___getHIDEventSystemClient_block_invoke + 296 attributes:{
    HighFrequency = 0;
    bundleID = "com.DefaultCompany.NeonDrift.run.1782638094.21137";
    pid = 25460;
} state:0x1 events:0 mask:0x0 dropped:0 dropStatus:0 droppedMask:0x0 lastDroppedTime:NONE source:HID
2026-06-28 17:19:57.397 Df SpringBoard[28855:d89db6] [com.apple.frontboard.ApplicationLibrary:default] Added application: <SBApplicationInfo: 0x106faea00; com.DefaultCompany.NeonDrift.run.1782638094.21137 (NeonDrift.run.1782638094.21137)>
2026-06-28 17:19:57.424 Df SpringBoard[28855:d89db6] [com.apple.appinstallation:TransactionLog] com.DefaultCompany.NeonDrift.run.1782638094.21137/Unknown Persona:10:10:3:1:Application added
2026-06-28 17:19:57.434 Df SpringBoard[28855:d89db6] [com.apple.SpringBoard:Icon] <<SBLeafIcon:0x10cf4a640 [com.DefaultCompany.NeonDrift.run.1782638094.21137]>> Changing active data source: <SBApplicationIcon: 0x10cf4a640; nodeID: com.DefaultCompany.NeonDrift.run.1782638094.21137; bundleID: com.DefaultCompany.NeonDrift.run.1782638094.21137>
2026-06-28 17:19:57.434 Df SpringBoard[28855:d89db6] [com.apple.SpringBoard:Icon] <<SBLeafIcon:0x10cf4a640 [com.DefaultCompany.NeonDrift.run.1782638094.21137]>> Changing from data souce: (null) to data source:com.DefaultCompany.NeonDrift.run.1782638094.21137.
2026-06-28 17:19:57.449 Df SpringBoard[28855:d89db6] [com.apple.SplashBoard:FileManifest] com.DefaultCompany.NeonDrift.run.1782638094.21137 Manifest is empty; purging everything at /Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Data/Application/71E27FEF-6B42-4CCD-A0AB-0C88BB7DB946/Library/SplashBoard/Snapshots
2026-06-28 17:19:58.192 Df SpringBoard[28855:d89db6] [com.apple.SpringBoard:ProactiveAppLibrary] Initialized app library w/ persisted library category map: <SBHLibraryMutableCategoryMap: 0x1247c2b00; generatedDate: 2026-06-28 09:15:49 +0000; uniqueIdentifier: A206E932-D111-46C5-9CCD-DD1B6818B340; loadedFromDisk: YES; _localizedCategoryNameByCategoryIdentifier: (empty)> categoryIdentifiers = {
    3000;
    3001;
}
sortedApplicationIdentifiersByCategoryIdentifier = {
    <SBHLibraryCategoryIdentifier: 0x1246eb0f0; localizedDisplayName: Other> = {
        com.DefaultCompany.NeonDrift;
        com.DefaultCompany.NeonDrift.run.1782484282.54413;
        com.DefaultCompany.NeonDrift.run.1782484537.59589;
        com.DefaultCompany.NeonDrift.run.1782484808.68182;
        com.DefaultCompany.NeonDrift.run.1782485248.76636;
        com.DefaultCompany.NeonDrift.run.1782485533.82553;
        com.DefaultCompany.NeonDrift.run.1782486232.95300;
        com.DefaultCompany.NeonDrift.run.1782493753.82761;
        com.DefaultCompany.NeonDrift.run.1782573263.85778;
        com.DefaultCompany.NeonDrift.run.1782638094.21137;
    }
    <SBHLibraryCategoryIdentifier: 0x1246eb9
2026-06-28 17:19:58.221 Df SpringBoard[28855:d89db6] [com.apple.SpringBoard:Library] Installing category map <SBHLibraryMutableCategoryMap: 0x1247c2b00; generatedDate: 2026-06-28 09:15:49 +0000; uniqueIdentifier: A206E932-D111-46C5-9CCD-DD1B6818B340; loadedFromDisk: YES; _localizedCategoryNameByCategoryIdentifier: (empty)> categoryIdentifiers = {
    3000;
    3001;
}
sortedApplicationIdentifiersByCategoryIdentifier = {
    <SBHLibraryCategoryIdentifier: 0x1246eb0f0; localizedDisplayName: Other> = {
        com.DefaultCompany.NeonDrift;
        com.DefaultCompany.NeonDrift.run.1782484282.54413;
        com.DefaultCompany.NeonDrift.run.1782484537.59589;
        com.DefaultCompany.NeonDrift.run.1782484808.68182;
        com.DefaultCompany.NeonDrift.run.1782485248.76636;
        com.DefaultCompany.NeonDrift.run.1782485533.82553;
        com.DefaultCompany.NeonDrift.run.1782486232.95300;
        com.DefaultCompany.NeonDrift.run.1782493753.82761;
        com.DefaultCompany.NeonDrift.run.1782573263.85778;
        com.DefaultCompany.NeonDrift.run.1782638094.21137;
    }
    <SBHLibraryCategoryIdentifier: 0x1246eb9 - animated <decode: missing data>
2026-06-28 17:19:58.454 Df SpringBoard[28855:d89ebf] [com.apple.SplashBoard:FileManifest] <XBApplicationSnapshotManifestImpl: 0x10cfcf680> [com.DefaultCompany.NeonDrift.run.1782638094.21137] We don't have any snapshots, so we're clearing our manifest data.
2026-06-28 17:19:58.560 Df SpringBoard[28855:d89df8] [com.apple.UserNotifications:DataProviderFactory] [com.DefaultCompany.NeonDrift.run.1782638094.21137] Application installed using default data provider
2026-06-28 17:19:58.582 Df SpringBoard[28855:d89ecc] [com.apple.PosterLegibilityKit:Caching] -[PLKCachedImageGenerator(SpringBoardHome Legibility Label Content Generator0x12724a280) removeImagesForCacheKeys:NeonDrift.run.1782638094.21137@@zh_TW_1368232380023648501_12014554394295850968__sz119.0x46.0B23CV11@@]
2026-06-28 17:19:58.582 Df SpringBoard[28855:d89ecc] [com.apple.PosterLegibilityKit:Caching] -[PLKCachedImageGenerator(SpringBoardHome Legibility Label Content Generator0x12724a280) removeImagesForCacheKeys:NeonDrift.run.1782638094.21137@@zh_TW_17196877703575764525_12014554394295850968__sz97.3x39.7B23CV11@@]
2026-06-28 17:19:58.690 Df SpringBoard[28855:d89f12] [com.apple.PosterLegibilityKit:Caching] -[PLKCachedImageGenerator(SpringBoardHome Label Content Generator0x12724a100) removeImagesForCacheKeys:NeonDrift.run.1782638094.21137@@zh_TW_1368232380023648501_0__sz101.0x26.0B23CV11@@]
2026-06-28 17:19:59.468 Df SpringBoard[28855:d89f0d] [com.apple.PosterLegibilityKit:Caching] -[PLKCachedImageGenerator(SpringBoardHome Label Content Generator0x12724a100) removeImagesForCacheKeys:NeonDrift.run.1782638094.21137@@zh_TW_17196877703575764525_0__sz79.3x19.7B23CV11@@]
2026-06-28 17:19:59.825 Df searchd[28641:d89b24] [com.apple.spotlight:default] Apps changed: (
    "com.apple.Passbook",
    "com.DefaultCompany.NeonDrift.run.1782486232.95300",
    "com.DefaultCompany.NeonDrift.run.1782493753.82761",
    "com.DefaultCompany.NeonDrift.run.1782485248.76636",
    "com.apple.DocumentsApp",
    "com.apple.MobileAddressBook",
    "com.apple.Fitness",
    "com.DefaultCompany.NeonDrift.run.1782638094.21137",
    "com.apple.MobileSMS",
    "com.DefaultCompany.NeonDrift.run.1782485533.82553",
    "com.apple.Maps",
    "com.apple.Passwords",
    "com.apple.mobilecal",
    "com.apple.Bridge",
    "com.apple.BarcodeScanner",
    "com.apple.Preferences",
    "com.DefaultCompany.NeonDrift.run.1782573263.85778",
    "com.apple.reminders",
    "com.DefaultCompany.NeonDrift.run.1782484808.68182",
    "com.apple.Health",
    "com.apple.news",
    "com.apple.mobileslideshow",
    "com.DefaultCompany.NeonDrift",
    "com.apple.mobilesafari",
    "com.DefaultCompany.NeonDrift.run.1782484537.59589",
    "com.apple.TVRemo
```
