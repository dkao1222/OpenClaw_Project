# QA Evidence Summary

## Build
```text
# Game Build Validation Report

- project_name: NeonDrift_MVP
- run_id: notion-NeonDrift_MVP-build-build-ios-simulator-20260625093702
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
- PASS unity_batchmode_ValidateProject: covered by unity_qa_evidence_tests
- PASS unity_platform_support_BuildIOSSimulator: /Applications/Unity/Hub/Editor/6000.0.77f1/PlaybackEngines/iOSSupport
- PASS unity_batchmode_BuildIOSSimulator: /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_buildiossimulator.log
- PASS xcodebuild_ios_simulator: log=/Users/dragonkao/.ope
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
    Bundle = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data/Containers/Bundle/Application/F11BCA8F-C4A3-42D1-B8E9-58B584D34C8C/NeonDrift.app/";
    BundleContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data/Containers/Bundle/Application/F11BCA8F-C4A3-42D1-B8E9-58B584D34C8C/";
    CFBundleDisplayName = NeonDrift;
    CFBundleExecutable = NeonDrift;
    CFBundleIdentifier = "com.DefaultCompany.NeonDrift";
    CFBundleName = NeonDrift;
    CFBundleVersion = 0;
    DataContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data/Containers/Data/Application/302C62A4-C9FA-4130-AE3E-91C53BAE8800/";
    GroupContainers =     {
    };
    Path = "/Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data/Containers/Bundle/Application/F11BCA8F-C4A3-42D1-B8E9-58B584D34C8C/NeonDrift.app";
    SBAppTags =     (
    );
}

```

## Launch
```text
com.DefaultCompany.NeonDrift: 71299

```

## Screenshot
- path: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_menu.png
- exists: True
- bytes: 79431
- width: 1206
- height: 2622
- nonblank_estimate: nonblank

## Runtime Log Tail
```text
Timestamp               Ty Process[PID:TID]
2026-06-25 17:39:10.968 Df SpringBoard[37555:4068d3] [com.apple.SplashBoard:SnapshotReaper] <XBApplicationSnapshotManifestImpl: 0x128634200> [com.DefaultCompany.NeonDrift] Reaping invalid snapshot <XBApplicationSnapshot: 0x12c468c40; …263C0BA61665> [com.DefaultCompany.NeonDrift]
 invalidReason: expired. expirationDate: 0001-01-01 00:00:00 +0000; how long ago (seconds): 63918149950.969315
2026-06-25 17:39:10.969 Df SpringBoard[37555:4068d3] [com.apple.SplashBoard:FileManifest] <XBApplicationSnapshotManifestImpl: 0x128634200> [com.DefaultCompany.NeonDrift] Deleting snapshot <XBApplicationSnapshot: 0x12c468c40; …263C0BA61665> [com.DefaultCompany.NeonDrift] for reason: _contentType: GeneratedDefault(1)
2026-06-25 17:39:10.969 Df SpringBoard[37555:4068d3] [com.apple.SplashBoard:FileManifest] <XBApplicationSnapshotManifestImpl: 0x128634200> [com.DefaultCompany.NeonDrift] We don't have any snapshots, so we're clearing our manifest data.
2026-06-25 17:39:12.069 Df SpringBoard[37555:4062b2] [com.apple.SplashBoard:FileManifest] <XBApplicationSnapshotManifestImpl: 0x128634200> [com.DefaultCompany.NeonDrift] We don't have any snapshots, so we're clearing our manifest data.
2026-06-25 17:39:18.719 Df log[70241:0] [com.apple.log:] log run noninteractively, parent: 37552 (launchd_sim), args: 'log' 'show' '--last' '3m' '--predicate' 'process == "NeonDrift" OR process == "NeonDrift" OR eventMessage CONTAINS "com.DefaultCompany.NeonDrift" OR eventMessage CONTAINS "NeonDrift"' '--style'
2026-06-25 17:40:20.373 Df CoreSimulatorBridge[37585:3b7add] Request received for installation of file:///Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app/ with options: {
    PackageType = Developer;
    SimulatorRootPath = "/Library/Developer/CoreSimulator/Volumes/iOS_23F77/Library/Developer/CoreSimulator/Profiles/Runtimes/iOS 26.5.simruntime/Contents/Resources/RuntimeRoot";
    SimulatorUserPath = "/Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data";
}
2026-06-25 17:40:20.373 Df CoreSimulatorBridge[37585:3b7add] [com.apple.installcoordination:framework] +[IXAppInstallCoordinator(IXSimpleInstaller) _beginInstallForURL:forPersonaUniqueString:consumeSource:options:progressBlock:completionWithIdentity:]: Beginning install for /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app consuming source:N options:{
    IsUserInitiated = 1;
    PackageType = Developer;
} installationRequestorAuditToken: NULL
2026-06-25 17:40:20.374 Df installcoordinationd[37614:40630f] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager registerPromise:]: Registered promise <IXSPlaceholder(0x105910140) Name:App Placeholder: NeonDrift (com.DefaultCompany.NeonDrift) Creator:InstallCoordination Simple SPI UUID:F16A481F-4A4E-455F-8E41-392804265EDD Location:[system-defined]> for UUID F16A481F-4A4E-455F-8E41-392804265EDD
2026-06-25 17:40:20.375 Df installcoordinationd[37614:40630f] [com.apple.installcoordination:daemon] -[IXSPlaceholder setAttributes:]: <IXSPlaceholder(0x105910140) Name:App Placeholder: NeonDrift (com.DefaultCompany.NeonDrift) Creator:InstallCoordination Simple SPI UUID:F16A481F-4A4E-455F-8E41-392804265EDD Location:[system-defined]>: setting placeholder attributes to <IXPlaceholderAttributes<0x1058a14a0> : {
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
2026-06-25 17:40:20.376 Df CoreSimulatorBridge[37585:40624a] [com.apple.installcoordination:framework] +[IXPlaceholder _setEntitlementsFromBundleExecutableURL:withBundleID:client:onPlaceholder:location:error:]: Executable for com.DefaultCompany.NeonDrift at NeonDrift -- file:///Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app/ had no entitlements
2026-06-25 17:40:20.376 Df CoreSimulatorBridge[37585:40624a] [com.apple.installcoordination:framework] +[IXPlaceholder _placeholderForBundle:client:withParent:installType:metadata:placeholderType:mayBeDeltaPackage:isFromSerializedPlaceholder:location:error:]: Using full fidelity icons for com.DefaultCompany.NeonDrift at /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app
2026-06-25 17:40:20.376 Df installcoordinationd[37614:40630f] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager registerPromise:]: Registered promise <IXSPromisedTransferToPath(0x1058de680) Name:Icon resources for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:B0D8F779-874F-4484-9EE4-34BEC0F6DD9E Location:[system-defined]> for UUID B0D8F779-874F-4484-9EE4-34BEC0F6DD9E
2026-06-25 17:40:20.378 Df CoreSimulatorBridge[37585:40624a] [com.apple.installcoordination:framework] -[IXPromisedTransferToPath setComplete:]: <IXPromisedTransferToPath<0x101872cc0> name:"Icon resources for com.DefaultCompany.NeonDrift" uuid:B0D8F779-874F-4484-9EE4-34BEC0F6DD9E creator:"InstallCoordination Simple SPI" location:[system-defined]> Move operation from /Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data/Containers/Shared/SystemGroup/systemgroup.com.apple.installcoordinationd/Library/InstallCoordination/PromiseStaging/B0D8F779-874F-4484-9EE4-34BEC0F6DD9E/temp.wK7Muh to /Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data/Containers/Shared/SystemGroup/systemgroup.com.apple.installcoordinationd/Library/InstallCoordination/PromiseStaging/B0D8F779-874F-4484-9EE4-34BEC0F6DD9E/temp.wK7Muh took 0.000041 seconds
2026-06-25 17:40:20.379 Df installcoordinationd[37614:40692a] [com.apple.installcoordination:daemon] -[IXSDataPromise _setPercentComplete:saveStateIfNeeded:]: Progress: <IXSPromisedTransferToPath(0x1058de680) Name:Icon resources for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:B0D8F779-874F-4484-9EE4-34BEC0F6DD9E Location:[system-defined]>
2026-06-25 17:40:20.379 Df installcoordinationd[37614:40630f] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promiseDidBegin:]: Unowned promise began: <IXSPromisedTransferToPath(0x1058de680) Name:Icon resources for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:B0D8F779-874F-4484-9EE4-34BEC0F6DD9E Location:[system-defined]>
2026-06-25 17:40:20.379 Df installcoordinationd[37614:40630f] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promise:didUpdateProgress:]: Unowned promise update progress to 1.000000 : <IXSPromisedTransferToPath(0x1058de680) Name:Icon resources for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:B0D8F779-874F-4484-9EE4-34BEC0F6DD9E Location:[system-defined]>
2026-06-25 17:40:20.379 Df installcoordinationd[37614:40630f] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promiseDidComplete:]: Unowned promise completed: <IXSPromisedTransferToPath(0x1058de680) Name:Icon resources for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:B0D8F779-874F-4484-9EE4-34BEC0F6DD9E Location:[system-defined]>
2026-06-25 17:40:20.380 Df installcoordinationd[37614:40692a] [com.apple.installcoordination:daemon] -[IXSDataPromise _setPercentComplete:saveStateIfNeeded:]: Progress: <IXSPromisedInMemoryDictionary(0x1058dd080) Name:Info.plist icon content for com.DefaultCompany.NeonDrift Creator:Inst
```
