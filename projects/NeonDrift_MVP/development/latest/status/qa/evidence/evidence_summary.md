# QA Evidence Summary

## Build
```text
# Game Build Validation Report

- project_name: NeonDrift_MVP
- run_id: notion-NeonDrift_MVP-build-build-ios-simulator-20260621171524
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
- PASS unity_project_exists: /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/unity/NeonDrift
- PASS unity_build_workspace_prepared: /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/unity_build_workspace/NeonDrift
- PASS unity_editor_detected: /Applications/Unity/Hub/Editor/6000.0.77f1/Unity.app/Contents/MacOS/Unity
- PASS unity_project_version_detected: 2022.3.0f1
- PASS unity_qa_evidence_tests: /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_runqaevidencetests.log; copied=/Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_editmode_test_results.xml, /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml, /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json
- PASS unity_platform_support_ValidateProject: no extra platform support required
- PASS unity_batchmode_ValidateProject: /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_validateproject.log
- PASS unity_platform_support_BuildIOSSimulator: /Applications/Unity/Hub/Editor/6000.0.77f1/PlaybackEngines/iOSSupport
- PASS unity_batchmode_BuildIOSSimulator: /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_bui
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
<test-run testcasecount="14" result="Passed" total="14" passed="14" failed="0">
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
  </test-suite>
</test-run>

```

## Runtime QA Probe
```json
{
    "screenState": "gameplay",
    "screenWidth": 640,
    "screenHeight": 480,
    "safeArea": "(x:0.00, y:0.00, width:640.00, height:480.00)",
    "hasCanvas": true,
    "hasScoreText": true,
    "hasPulseText": true,
    "hasControlHint": true,
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
    "startButtonRect": "name=Start Button; width=260.0; height=78.0; min=(190.0,301.0); max=(450.0,379.0)",
    "settingsButtonRect": "name=Settings Button; width=300.0; height=72.0; min=(170.0,197.0); max=(470.0,269.0)",
    "pauseButtonRect": "name=Pause Button; width=96.0; height=72.0; min=(506.0,296.0); max=(602.0,368.0)",
    "retryButtonRect": "name=Retry Button; width=260.0; height=72.0; min=(190.0,98.0); max=(450.0,170.0)",
    "leftControlZoneRect": "name=Left Control Zone; width=220.0; height=104.0; min=(246.0,314.0); max=(466.0,418.0)",
    "rightControlZoneRect": "name=Right Control Zone; width=220.0; height=104.0; min=(174.0,314.0); max=(394.0,418.0)",
    "buttonLayoutVerified": false,
    "menuButtonSizeVerified": true,
    "pauseRetryButtonSizeVerified": true,
    "controlZoneSizeVerified": false,
    "controlsInsideSafeArea": true,
    "controlsDoNotOverlap": false,
    "coreGameplayObjectsVerified": false,
    "scoringSystemVerified": false,
    "pauseSystemVerified": false,
    "failureRetrySystemVerified": true,
    "pauseControlVerified": true,
    "retryControlVerified": true,
    "leftRightSteeringVerified": true,
    "safeAreaApplied": true,
    "framePacingConfigured": true,
    "targetFrameRate": 60,
    "score": 0,
    "isGameOver": false,
    "isPaused": false,
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
    Bundle = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CCB1E793-CED4-4FCD-BF73-321AAEA77AB9/data/Containers/Bundle/Application/14906281-9004-48D2-8477-7B86F5564495/NeonDrift.app/";
    BundleContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CCB1E793-CED4-4FCD-BF73-321AAEA77AB9/data/Containers/Bundle/Application/14906281-9004-48D2-8477-7B86F5564495/";
    CFBundleDisplayName = NeonDrift;
    CFBundleExecutable = NeonDrift;
    CFBundleIdentifier = "com.DefaultCompany.NeonDrift";
    CFBundleName = NeonDrift;
    CFBundleVersion = 0;
    DataContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CCB1E793-CED4-4FCD-BF73-321AAEA77AB9/data/Containers/Data/Application/38808F12-214C-4F1C-A147-9D7B9E484AD4/";
    GroupContainers =     {
    };
    Path = "/Users/dragonkao/Library/Developer/CoreSimulator/Devices/CCB1E793-CED4-4FCD-BF73-321AAEA77AB9/data/Containers/Bundle/Application/14906281-9004-48D2-8477-7B86F5564495/NeonDrift.app";
    SBAppTags =     (
    );
}

```

## Launch
```text
com.DefaultCompany.NeonDrift: 91188

```

## Screenshot
- path: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_initial_run.png
- exists: True
- bytes: 155822
- width: 1206
- height: 2622
- nonblank_estimate: nonblank

## Runtime Log Tail
```text
Timestamp               Ty Process[PID:TID]
2026-06-22 01:16:20.081 Df CoreSimulatorBridge[50222:4afb9f] Request received for installation of file:///Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app/ with options: {
    PackageType = Developer;
    SimulatorRootPath = "/Library/Developer/CoreSimulator/Volumes/iOS_23F77/Library/Developer/CoreSimulator/Profiles/Runtimes/iOS 26.5.simruntime/Contents/Resources/RuntimeRoot";
    SimulatorUserPath = "/Users/dragonkao/Library/Developer/CoreSimulator/Devices/CCB1E793-CED4-4FCD-BF73-321AAEA77AB9/data";
}
2026-06-22 01:16:20.081 Df CoreSimulatorBridge[50222:4afb9f] [com.apple.installcoordination:framework] +[IXAppInstallCoordinator(IXSimpleInstaller) _beginInstallForURL:forPersonaUniqueString:consumeSource:options:progressBlock:completionWithIdentity:]: Beginning install for /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app consuming source:N options:{
    IsUserInitiated = 1;
    PackageType = Developer;
} installationRequestorAuditToken: NULL
2026-06-22 01:16:20.083 Df installcoordinationd[73024:4b64b0] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager registerPromise:]: Registered promise <IXSPlaceholder(0x10190c500) Name:App Placeholder: NeonDrift (com.DefaultCompany.NeonDrift) Creator:InstallCoordination Simple SPI UUID:F96F8D7D-25E8-4974-83F3-8C6FC60567FC Location:[system-defined]> for UUID F96F8D7D-25E8-4974-83F3-8C6FC60567FC
2026-06-22 01:16:20.084 Df installcoordinationd[73024:4b64b0] [com.apple.installcoordination:daemon] -[IXSPlaceholder setAttributes:]: <IXSPlaceholder(0x10190c500) Name:App Placeholder: NeonDrift (com.DefaultCompany.NeonDrift) Creator:InstallCoordination Simple SPI UUID:F96F8D7D-25E8-4974-83F3-8C6FC60567FC Location:[system-defined]>: setting placeholder attributes to <IXPlaceholderAttributes<0x1018a5180> : {
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
2026-06-22 01:16:20.085 Df CoreSimulatorBridge[50222:4b64aa] [com.apple.installcoordination:framework] +[IXPlaceholder _setEntitlementsFromBundleExecutableURL:withBundleID:client:onPlaceholder:location:error:]: Executable for com.DefaultCompany.NeonDrift at NeonDrift -- file:///Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app/ had no entitlements
2026-06-22 01:16:20.085 Df CoreSimulatorBridge[50222:4b64aa] [com.apple.installcoordination:framework] +[IXPlaceholder _placeholderForBundle:client:withParent:installType:metadata:placeholderType:mayBeDeltaPackage:isFromSerializedPlaceholder:location:error:]: Using full fidelity icons for com.DefaultCompany.NeonDrift at /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app
2026-06-22 01:16:20.085 Df installcoordinationd[73024:4b64b0] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager registerPromise:]: Registered promise <IXSPromisedTransferToPath(0x1018e5400) Name:Icon resources for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:9176612A-4685-4D84-AF70-874C079D6B3D Location:[system-defined]> for UUID 9176612A-4685-4D84-AF70-874C079D6B3D
2026-06-22 01:16:20.088 Df CoreSimulatorBridge[50222:4b64aa] [com.apple.installcoordination:framework] -[IXPromisedTransferToPath setComplete:]: <IXPromisedTransferToPath<0x101476bc0> name:"Icon resources for com.DefaultCompany.NeonDrift" uuid:9176612A-4685-4D84-AF70-874C079D6B3D creator:"InstallCoordination Simple SPI" location:[system-defined]> Move operation from /Users/dragonkao/Library/Developer/CoreSimulator/Devices/CCB1E793-CED4-4FCD-BF73-321AAEA77AB9/data/Containers/Shared/SystemGroup/systemgroup.com.apple.installcoordinationd/Library/InstallCoordination/PromiseStaging/9176612A-4685-4D84-AF70-874C079D6B3D/temp.0qGBKl to /Users/dragonkao/Library/Developer/CoreSimulator/Devices/CCB1E793-CED4-4FCD-BF73-321AAEA77AB9/data/Containers/Shared/SystemGroup/systemgroup.com.apple.installcoordinationd/Library/InstallCoordination/PromiseStaging/9176612A-4685-4D84-AF70-874C079D6B3D/temp.0qGBKl took 0.000039 seconds
2026-06-22 01:16:20.088 Df installcoordinationd[73024:4bc1a2] [com.apple.installcoordination:daemon] -[IXSDataPromise _setPercentComplete:saveStateIfNeeded:]: Progress: <IXSPromisedTransferToPath(0x1018e5400) Name:Icon resources for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:9176612A-4685-4D84-AF70-874C079D6B3D Location:[system-defined]>
2026-06-22 01:16:20.089 Df installcoordinationd[73024:4b64b0] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promiseDidBegin:]: Unowned promise began: <IXSPromisedTransferToPath(0x1018e5400) Name:Icon resources for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:9176612A-4685-4D84-AF70-874C079D6B3D Location:[system-defined]>
2026-06-22 01:16:20.089 Df installcoordinationd[73024:4b64b0] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promise:didUpdateProgress:]: Unowned promise update progress to 1.000000 : <IXSPromisedTransferToPath(0x1018e5400) Name:Icon resources for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:9176612A-4685-4D84-AF70-874C079D6B3D Location:[system-defined]>
2026-06-22 01:16:20.089 Df installcoordinationd[73024:4bc1a2] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promiseDidComplete:]: Unowned promise completed: <IXSPromisedTransferToPath(0x1018e5400) Name:Icon resources for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:9176612A-4685-4D84-AF70-874C079D6B3D Location:[system-defined]>
2026-06-22 01:16:20.089 Df installcoordinationd[73024:4b64b0] [com.apple.installcoordination:daemon] -[IXSDataPromise _setPercentComplete:saveStateIfNeeded:]: Progress: <IXSPromisedInMemoryDictionary(0x1018e5200) Name:Info.plist icon content for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:85946290-6A72-4F8E-9254-8D209FD78A41 Location:[system-defined]>
2026-06-22 01:16:20.090 Df installcoordinationd[73024:4b64b0] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager registerPromise:]: Registered promise <IXSPromisedInMemoryDictionary(0x1018e5200) Name:Info.plist icon content for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:85946290-6A72-4F8E-9254-8D209FD78A41 Location:[system-defined]> for UUID 85946290-6A72-4F8E-9254-8D209FD78A41
2026-06-22 01:16:20.090 Df installcoordinationd[73024:4bc1a2] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promiseDidBegin:]: Unowned promise began: <IXSPromisedInMemoryDictionary(0x1018e5200) Name:Info.plist icon content for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:85946290-6A72-4F8E-9254-8D209FD78A41 Location:[system-defined]>
2026-06-22 01:16:20.090 Df installcoordinationd[73024:4bc1a2] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promise:didUpdateProgress:]: Unowned promise update progress to 1.000000 : <IXSPromisedInMemoryDictionary(0x1018e5200) Name:Info.plist icon content for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:85946290-6A72-4F8E-9254-8D209FD78A41 Location:[system-defined]>
2026-06-22 01:16:20.090 Df installcoordinationd[73024:4bc1a2] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promiseDidComplete:]: Unowned promise completed: <IXSP
```
