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
    Bundle = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Bundle/Application/FD2F9082-800E-4631-A4B4-D850F1CA5230/NeonDrift.app/";
    BundleContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Bundle/Application/FD2F9082-800E-4631-A4B4-D850F1CA5230/";
    CFBundleDisplayName = NeonDrift;
    CFBundleExecutable = NeonDrift;
    CFBundleIdentifier = "com.DefaultCompany.NeonDrift";
    CFBundleName = NeonDrift;
    CFBundleVersion = 0;
    DataContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Data/Application/757D7BDD-0704-4331-8B82-0EAE0B804E90/";
    GroupContainers =     {
    };
    Path = "/Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Bundle/Application/FD2F9082-800E-4631-A4B4-D850F1CA5230/NeonDrift.app";
    SBAppTags =     (
    );
}

```

## Launch
```text
com.DefaultCompany.NeonDrift: 60732

```

## Screenshot
- path: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_menu.png
- exists: True
- bytes: 76105
- width: 1206
- height: 2622
- nonblank_estimate: nonblank

## Runtime Log Tail
```text
Timestamp               Ty Process[PID:TID]
2026-06-24 22:11:01.981 Df CoreSimulatorBridge[58181:fa677] Request received for installation of file:///Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app/ with options: {
    PackageType = Developer;
    SimulatorRootPath = "/Library/Developer/CoreSimulator/Volumes/iOS_23E254a/Library/Developer/CoreSimulator/Profiles/Runtimes/iOS 26.4.simruntime/Contents/Resources/RuntimeRoot";
    SimulatorUserPath = "/Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data";
}
2026-06-24 22:11:01.981 Df CoreSimulatorBridge[58181:fa677] [com.apple.installcoordination:framework] +[IXAppInstallCoordinator(IXSimpleInstaller) _beginInstallForURL:forPersonaUniqueString:consumeSource:options:progressBlock:completionWithIdentity:]: Beginning install for /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app consuming source:N options:{
    IsUserInitiated = 1;
    PackageType = Developer;
} installationRequestorAuditToken: NULL
2026-06-24 22:11:01.984 Df installcoordinationd[58312:faa8c] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager registerPromise:]: Registered promise <IXSPlaceholder(0x101924500) Name:App Placeholder: NeonDrift (com.DefaultCompany.NeonDrift) Creator:InstallCoordination Simple SPI UUID:FF83C9DD-A0AA-4EBB-80C9-E401EA38881E Location:[system-defined]> for UUID FF83C9DD-A0AA-4EBB-80C9-E401EA38881E
2026-06-24 22:11:01.985 Df installcoordinationd[58312:faa8c] [com.apple.installcoordination:daemon] -[IXSPlaceholder setAttributes:]: <IXSPlaceholder(0x101924500) Name:App Placeholder: NeonDrift (com.DefaultCompany.NeonDrift) Creator:InstallCoordination Simple SPI UUID:FF83C9DD-A0AA-4EBB-80C9-E401EA38881E Location:[system-defined]>: setting placeholder attributes to <IXPlaceholderAttributes<0x1018c9180> : {
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
2026-06-24 22:11:01.986 Df CoreSimulatorBridge[58181:fa675] [com.apple.installcoordination:framework] +[IXPlaceholder _setEntitlementsFromBundleExecutableURL:withBundleID:client:onPlaceholder:location:error:]: Executable for com.DefaultCompany.NeonDrift at NeonDrift -- file:///Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app/ had no entitlements
2026-06-24 22:11:01.986 Df CoreSimulatorBridge[58181:fa675] [com.apple.installcoordination:framework] +[IXPlaceholder _placeholderForBundle:client:withParent:installType:metadata:placeholderType:mayBeDeltaPackage:isFromSerializedPlaceholder:location:error:]: Using full fidelity icons for com.DefaultCompany.NeonDrift at /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app
2026-06-24 22:11:01.986 Df installcoordinationd[58312:faa8c] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager registerPromise:]: Registered promise <IXSPromisedTransferToPath(0x1018fa200) Name:Icon resources for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:0070EC32-BE50-4F41-80BF-866B7C0BA5D9 Location:[system-defined]> for UUID 0070EC32-BE50-4F41-80BF-866B7C0BA5D9
2026-06-24 22:11:01.989 Df CoreSimulatorBridge[58181:fa675] [com.apple.installcoordination:framework] -[IXPromisedTransferToPath setComplete:]: <IXPromisedTransferToPath<0x1043e8400> name:"Icon resources for com.DefaultCompany.NeonDrift" uuid:0070EC32-BE50-4F41-80BF-866B7C0BA5D9 creator:"InstallCoordination Simple SPI" location:[system-defined]> Move operation from /Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Shared/SystemGroup/systemgroup.com.apple.installcoordinationd/Library/InstallCoordination/PromiseStaging/0070EC32-BE50-4F41-80BF-866B7C0BA5D9/temp.D1X735 to /Users/dragonkao/Library/Developer/CoreSimulator/Devices/CC47DE7A-8196-4465-A5A5-BB852C9C6C82/data/Containers/Shared/SystemGroup/systemgroup.com.apple.installcoordinationd/Library/InstallCoordination/PromiseStaging/0070EC32-BE50-4F41-80BF-866B7C0BA5D9/temp.D1X735 took 0.000048 seconds
2026-06-24 22:11:01.990 Df installcoordinationd[58312:faa8c] [com.apple.installcoordination:daemon] -[IXSDataPromise _setPercentComplete:saveStateIfNeeded:]: Progress: <IXSPromisedTransferToPath(0x1018fa200) Name:Icon resources for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:0070EC32-BE50-4F41-80BF-866B7C0BA5D9 Location:[system-defined]>
2026-06-24 22:11:01.990 Df installcoordinationd[58312:103378] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promiseDidBegin:]: Unowned promise began: <IXSPromisedTransferToPath(0x1018fa200) Name:Icon resources for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:0070EC32-BE50-4F41-80BF-866B7C0BA5D9 Location:[system-defined]>
2026-06-24 22:11:01.990 Df installcoordinationd[58312:103378] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promise:didUpdateProgress:]: Unowned promise update progress to 1.000000 : <IXSPromisedTransferToPath(0x1018fa200) Name:Icon resources for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:0070EC32-BE50-4F41-80BF-866B7C0BA5D9 Location:[system-defined]>
2026-06-24 22:11:01.990 Df installcoordinationd[58312:faa8c] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promiseDidComplete:]: Unowned promise completed: <IXSPromisedTransferToPath(0x1018fa200) Name:Icon resources for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:0070EC32-BE50-4F41-80BF-866B7C0BA5D9 Location:[system-defined]>
2026-06-24 22:11:01.991 Df installcoordinationd[58312:103378] [com.apple.installcoordination:daemon] -[IXSDataPromise _setPercentComplete:saveStateIfNeeded:]: Progress: <IXSPromisedInMemoryDictionary(0x1018f9680) Name:Info.plist icon content for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:8D2EA15B-5D4F-41F8-95CF-E4F726E4055D Location:[system-defined]>
2026-06-24 22:11:01.991 Df installcoordinationd[58312:103378] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager registerPromise:]: Registered promise <IXSPromisedInMemoryDictionary(0x1018f9680) Name:Info.plist icon content for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:8D2EA15B-5D4F-41F8-95CF-E4F726E4055D Location:[system-defined]> for UUID 8D2EA15B-5D4F-41F8-95CF-E4F726E4055D
2026-06-24 22:11:01.992 Df installcoordinationd[58312:10337b] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promiseDidBegin:]: Unowned promise began: <IXSPromisedInMemoryDictionary(0x1018f9680) Name:Info.plist icon content for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:8D2EA15B-5D4F-41F8-95CF-E4F726E4055D Location:[system-defined]>
2026-06-24 22:11:01.992 Df installcoordinationd[58312:10337b] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promise:didUpdateProgress:]: Unowned promise update progress to 1.000000 : <IXSPromisedInMemoryDictionary(0x1018f9680) Name:Info.plist icon content for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:8D2EA15B-5D4F-41F8-95CF-E4F726E4055D Location:[system-defined]>
2026-06-24 22:11:01.992 Df installcoordinationd[58312:10337b] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promiseDidComplete:]: Unowned promise completed: <IXSPromisedI
```
