# QA Evidence Summary

## Build
```text
# Game Build Validation Report

- project_name: NeonDrift_MVP
- run_id: notion-NeonDrift_MVP-build-build-ios-simulator-20260624135735-retry2
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
- PASS unity_build_workspace_prepared: /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/unity_build_workspace/NeonDrift
- PASS unity_editor_detected: /Applications/Unity/Hub/Editor/6000.0.77f1/Unity.app/Contents/MacOS/Unity
- PASS unity_project_version_detected: 6000.0.77f1
- PASS unity_qa_evidence_tests: /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_runqaevidencetests.log; copied=/Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_editmode_test_results.xml, /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml, /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json
- PASS unity_platform_support_ValidateProject: no extra platform support required
- PASS unity_batchmode_ValidateProject: /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_validateproject.log
- PASS unity_platform_support_BuildIOSSimulator: /Applications/Unity/Hub/Editor/6000.0.77f1/PlaybackEngines/iOSSupport
- PASS unity_batchmode_BuildIOSSimulator: /Users
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
<test-run testcasecount="26" result="Passed" total="26" passed="26" failed="0">
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
    <test-case name="PlayerSteeringMotionIsVerified" result="Passed" />
    <test-case name="HumanAgencyChangesOutcome" result="Passed" />
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
    "pauseButtonRect": "name=Pause Button; width=96.0; height=72.0; min=(506.0,296.0); max=(602.0,368.0)",
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
    "pauseControlVerified": true,
    "retryControlVerified": true,
    "leftRightSteeringVerified": true,
    "safeAreaApplied": true,
    "framePacingConfigured": true,
    "targetFrameRate": 60,
    "score": 0,
    "wave": 1,
    "combo": 0,
    "multiplier": 1,
    "boostCharge": 0.0,
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
    Bundle = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Bundle/Application/4F916CA9-7F2F-4088-927A-257461A96584/NeonDrift.app/";
    BundleContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Bundle/Application/4F916CA9-7F2F-4088-927A-257461A96584/";
    CFBundleDisplayName = NeonDrift;
    CFBundleExecutable = NeonDrift;
    CFBundleIdentifier = "com.DefaultCompany.NeonDrift";
    CFBundleName = NeonDrift;
    CFBundleVersion = 0;
    DataContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Data/Application/A9059650-2723-43F3-BE14-06AB2EF3A135/";
    GroupContainers =     {
    };
    Path = "/Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Bundle/Application/4F916CA9-7F2F-4088-927A-257461A96584/NeonDrift.app";
    SBAppTags =     (
    );
}

```

## Launch
```text
com.DefaultCompany.NeonDrift: 58497

```

## Screenshot
- path: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_menu.png
- exists: True
- bytes: 75951
- width: 1206
- height: 2622
- nonblank_estimate: nonblank

## Runtime Log Tail
```text
Timestamp               Ty Process[PID:TID]
2026-06-24 22:02:24.481 Df SpringBoard[58151:fa3c1] [com.apple.frontboard.ApplicationLibrary:default] Added application: <SBApplicationInfo: 0x10bdbea00; com.DefaultCompany.NeonDrift (NeonDrift)>
2026-06-24 22:02:24.522 Df SpringBoard[58151:fa3c1] [com.apple.appinstallation:TransactionLog] com.DefaultCompany.NeonDrift/Unknown Persona:10:10:3:1:Application added
2026-06-24 22:02:24.592 Df SpringBoard[58151:fa3c1] [com.apple.SpringBoard:Icon] <<SBLeafIcon:0x10bd20240 [com.DefaultCompany.NeonDrift]>> Changing active data source: <SBApplicationIcon: 0x10bd20240; nodeID: com.DefaultCompany.NeonDrift; bundleID: com.DefaultCompany.NeonDrift>
2026-06-24 22:02:24.592 Df SpringBoard[58151:fa3c1] [com.apple.SpringBoard:Icon] <<SBLeafIcon:0x10bd20240 [com.DefaultCompany.NeonDrift]>> Changing from data souce: (null) to data source:com.DefaultCompany.NeonDrift.
2026-06-24 22:02:24.604 Df SpringBoard[58151:fa3c1] [com.apple.SplashBoard:FileManifest] com.DefaultCompany.NeonDrift Manifest is empty; purging everything at /Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Data/Application/4DC8A693-A77B-4013-846A-E12BD31BB3AA/Library/SplashBoard/Snapshots
2026-06-24 22:02:25.652 Df SpringBoard[58151:fa657] [com.apple.SplashBoard:FileManifest] <XBApplicationSnapshotManifestImpl: 0x10bf7b200> [com.DefaultCompany.NeonDrift] We don't have any snapshots, so we're clearing our manifest data.
2026-06-24 22:02:25.942 Df SpringBoard[58151:fa61e] [com.apple.UserNotifications:DataStore] Creating library mapping from com.DefaultCompany.NeonDrift to C201444E-B942-4546-B451-6172AEC22E87
2026-06-24 22:02:26.290 Df SpringBoard[58151:fa665] [com.apple.SpringBoard:ProactiveAppLibrary] (1) Library category map was freshly generated: <SBHLibraryMutableCategoryMap: 0x125d7ea00; generatedDate: 2026-06-24 14:02:26 +0000; uniqueIdentifier: 35227298-A976-4FA5-B16E-5F27394F717E; loadedFromDisk: NO; _localizedCategoryNameByCategoryIdentifier: (empty)> categoryIdentifiers = {
    3000;
    3001;
}
sortedApplicationIdentifiersByCategoryIdentifier = {
    <SBHLibraryCategoryIdentifier: 0x123575650; localizedDisplayName: Other> = {
        com.DefaultCompany.NeonDrift;
    }
    <SBHLibraryCategoryIdentifier: 0x123574b70; localizedDisplayName: " System"> = {
        com.apple.Bridge;
        com.apple.DocumentsApp;
        com.apple.Fitness;
        com.apple.Health;
        com.apple.Maps;
        com.apple.MobileAddressBook;
        com.apple.MobileSMS;
        com.apple.Passbook;
        com.apple.Passwords;
        com.apple.Preferences;
        com.apple.Preview;
        com.apple.mobilecal;
        com.apple.mobilesafari;
        com.apple.mobileslideshow;
        com.apple.news;
        com.apple.reminders;
        com.a
2026-06-24 22:02:26.307 Df SpringBoard[58151:fa3c1] [com.apple.SpringBoard:Library] Installing category map <SBHLibraryMutableCategoryMap: 0x125d7ea00; generatedDate: 2026-06-24 14:02:26 +0000; uniqueIdentifier: 35227298-A976-4FA5-B16E-5F27394F717E; loadedFromDisk: NO; _localizedCategoryNameByCategoryIdentifier: (empty)> categoryIdentifiers = {
    3000;
    3001;
}
sortedApplicationIdentifiersByCategoryIdentifier = {
    <SBHLibraryCategoryIdentifier: 0x123575650; localizedDisplayName: Other> = {
        com.DefaultCompany.NeonDrift;
    }
    <SBHLibraryCategoryIdentifier: 0x123574b70; localizedDisplayName: " System"> = {
        com.apple.Bridge;
        com.apple.DocumentsApp;
        com.apple.Fitness;
        com.apple.Health;
        com.apple.Maps;
        com.apple.MobileAddressBook;
        com.apple.MobileSMS;
        com.apple.Passbook;
        com.apple.Passwords;
        com.apple.Preferences;
        com.apple.Preview;
        com.apple.mobilecal;
        com.apple.mobilesafari;
        com.apple.mobileslideshow;
        com.apple.news;
        com.apple.reminders;
        com.apple.short - animated <decode: missing data>
2026-06-24 22:02:26.585 Df SpringBoard[58151:fa61e] [com.apple.UserNotifications:DataProviderFactory] [com.DefaultCompany.NeonDrift] Application installed using default data provider
2026-06-24 22:02:26.687 Df SpringBoard[58151:fa61e] [com.apple.UserNotifications:Settings] Getting sectionInfos for section identifiers: {(
    "com.apple.Sharing.WatchRemoteNotifications",
    "com.apple.ScreenTimeDowntimeNotifications",
    "com.apple.Passbook",
    "com.apple.SoundDetectionNotifications",
    "com.apple.mobileslideshow",
    "com.apple.SystemIntents",
    "com.apple.Home",
    "com.apple.EscrowSecurityAlert",
    "com.apple.CarPlayApp",
    "com.apple.MusicKit.UI",
    "com.apple.Maps",
    "com.apple.musicrecognition",
    "com.apple.voicebanking.usernotifications",
    "com.apple.VoiceOverNotifications",
    "com.apple.LiveListenNotifications",
    "com.apple.CarPlayTemplateUIHost",
    "com.apple.NanoUniverse.AegirProxyApp",
    "com.apple.VoiceOverTouch",
    "com.apple.Health",
    "com.apple.Fitness",
    "com.apple.UIKit.OverlayUI",
    "com.DefaultCompany.NeonDrift",
    "com.apple.ScreenTimeEnabledNotifications",
    "com.apple.ctnotifytool",
    "com.apple.livetranscriptionui",
    "com.apple.ScreenTimeNotifications",
    "com.apple.Passwords",
    "com.apple.Sharing.TVRemoteNotifications",
    "com.apple
2026-06-24 22:02:26.687 Df SpringBoard[58151:fa87e] [com.apple.UserNotifications:Settings] [{(
    "com.apple.Sharing.WatchRemoteNotifications",
    "com.apple.ScreenTimeDowntimeNotifications",
    "com.apple.Passbook",
    "com.apple.SoundDetectionNotifications",
    "com.apple.mobileslideshow",
    "com.apple.SystemIntents",
    "com.apple.Home",
    "com.apple.EscrowSecurityAlert",
    "com.apple.CarPlayApp",
    "com.apple.MusicKit.UI",
    "com.apple.Maps",
    "com.apple.musicrecognition",
    "com.apple.voicebanking.usernotifications",
    "com.apple.VoiceOverNotifications",
    "com.apple.LiveListenNotifications",
    "com.apple.CarPlayTemplateUIHost",
    "com.apple.NanoUniverse.AegirProxyApp",
    "com.apple.VoiceOverTouch",
    "com.apple.Health",
    "com.apple.Fitness",
    "com.apple.UIKit.OverlayUI",
    "com.DefaultCompany.NeonDrift",
    "com.apple.ScreenTimeEnabledNotifications",
    "com.apple.ctnotifytool",
    "com.apple.livetranscriptionui",
    "com.apple.ScreenTimeNotifications",
    "com.apple.Passwords",
    "com.apple.Sharing.TVRemoteNotifications",
    "com.apple] Got section infos [ hasResult: <decode: missing data> ]
2026-06-24 22:02:27.086 Df SpringBoard[58151:fa3c1] [com.apple.SpringBoard:Library] library category map update received: <SBHLibraryMutableCategoryMap: 0x125d7ea00; generatedDate: 2026-06-24 14:02:26 +0000; uniqueIdentifier: 35227298-A976-4FA5-B16E-5F27394F717E; loadedFromDisk: NO; _localizedCategoryNameByCategoryIdentifier: (empty)> categoryIdentifiers = {
    3000;
    3001;
}
sortedApplicationIdentifiersByCategoryIdentifier = {
    <SBHLibraryCategoryIdentifier: 0x123575650; localizedDisplayName: Other> = {
        com.DefaultCompany.NeonDrift;
    }
    <SBHLibraryCategoryIdentifier: 0x123574b70; localizedDisplayName: " System"> = {
        com.apple.Bridge;
        com.apple.DocumentsApp;
        com.apple.Fitness;
        com.apple.Health;
        com.apple.Maps;
        com.apple.MobileAddressBook;
        com.apple.MobileSMS;
        com.apple.Passbook;
        com.apple.Passwords;
        com.apple.Preferences;
        com.apple.Preview;
        com.apple.mobilecal;
        com.apple.mobilesafari;
        com.apple.mobileslideshow;
        com.apple.news;
        com.apple.reminders;
        com.apple.short
2026-06-24 22:02:27.087 Df SpringBoard[58151:fa3c1] [com.apple.SpringBoard:Library] Installing category map <SBHLibraryMutableCategoryMap: 0x125d7ea00; generatedDate: 2026-06-24 14:02:26 +0000; uniqueIdentifier: 35227298-A976-4FA5-B16E-5F27394F717E; loadedFromDisk: NO; _localizedCategoryNameByCategoryIdentifier: (empty)> categoryIdentifiers = {
    3000;
    3001;
}
sortedA
```
