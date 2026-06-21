# QA Evidence Summary

## Build
```text
# Game Build Validation Report

- project_name: NeonDrift_MVP
- run_id: notion-NeonDrift_MVP-build-build-ios-simulator-20260621150245
- stage_range: build-ios-simulator
- source_output_folder: /home/node/.openclaw/workspace/386b9e33-8429-815b-b132-fb63e00fe3a9/NeonDrift_MVP__development__notion-NeonDrift_MVP-development-dev-full-20260621150132/project/
- source_handoff_path: /home/node/.openclaw/workspace/386b9e33-8429-815b-b132-fb63e00fe3a9/NeonDrift_MVP__development__notion-NeonDrift_MVP-development-dev-full-20260621150132/project/handoffs/development/final_handoff.md

## Source Development Delivery Gate
- PASS source_output_folder_exists: /home/node/.openclaw/workspace/386b9e33-8429-815b-b132-fb63e00fe3a9/NeonDrift_MVP__development__notion-NeonDrift_MVP-development-dev-full-20260621150132/project/
- PASS source_handoff_exists: /home/node/.openclaw/workspace/386b9e33-8429-815b-b132-fb63e00fe3a9/NeonDrift_MVP__development__notion-NeonDrift_MVP-development-dev-full-20260621150132/project/handoffs/development/final_handoff.md
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
- PASS unity_project_exists: /Users/dragonkao/.openclaw/workspace/386b9e33-8429-815b-b132-fb63e00fe3a9/NeonDrift_MVP__development__notion-NeonDrift_MVP-development-dev-full-20260621150132/project/unity/NeonDrift
- PASS unity_build_workspace_prepared: /Users/dragonkao/.openclaw/workspace/386b9e33-8429-817f-84c3-d7f2769adc34/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621150245/project/unity_build_workspace/NeonDrift
- PASS unity_editor_detected: /Applications/Unity/Hub/Editor/6000.0.77f1/Unity.app/Contents/MacOS/Unity
- PASS unity_project_version_detected: 2022.3.0f1
- PASS unity_qa_evidence_tests: /Users/dragonkao/.openclaw/workspace/386b9e33-8429-817f-84c3-d7f2769adc34/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621150245/project/status/validation/unity_runqaevidencetests.log; copied=/Users/dragonkao/.openclaw/workspace/386b9e33-8429-817f-84c3-d7f2769adc34/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621150245/project/status/validation/unity_editmode_test_results.xml, /Users/dragonkao/.openclaw/workspace/386b9e33-8429-817f-84c3-d7f2769adc34/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621150245/project/status/validation/unity_playmode_test_results.xml, /Users/dragonkao/.openclaw/workspace/386b9e33-8429-817f-84c3-d7f2769adc34/Ne
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
<test-run testcasecount="11" result="Passed" total="11" passed="11" failed="0">
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
/Users/dragonkao/.openclaw/workspace/386b9e33-8429-817f-84c3-d7f2769adc34/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621150245/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app/NeonDrift: Mach-O 64-bit executable arm64

```

## App Info
```text
{
    ApplicationType = User;
    Bundle = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CCB1E793-CED4-4FCD-BF73-321AAEA77AB9/data/Containers/Bundle/Application/489CF72F-5A83-4F30-8509-235F697AE14C/NeonDrift.app/";
    BundleContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CCB1E793-CED4-4FCD-BF73-321AAEA77AB9/data/Containers/Bundle/Application/489CF72F-5A83-4F30-8509-235F697AE14C/";
    CFBundleDisplayName = NeonDrift;
    CFBundleExecutable = NeonDrift;
    CFBundleIdentifier = "com.DefaultCompany.NeonDrift";
    CFBundleName = NeonDrift;
    CFBundleVersion = 0;
    DataContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CCB1E793-CED4-4FCD-BF73-321AAEA77AB9/data/Containers/Data/Application/61C90196-E177-49FF-91EF-29DC9D132349/";
    GroupContainers =     {
    };
    Path = "/Users/dragonkao/Library/Developer/CoreSimulator/Devices/CCB1E793-CED4-4FCD-BF73-321AAEA77AB9/data/Containers/Bundle/Application/489CF72F-5A83-4F30-8509-235F697AE14C/NeonDrift.app";
    SBAppTags =     (
    );
}

```

## Launch
```text
com.DefaultCompany.NeonDrift: 75705

```

## Screenshot
- path: /home/node/.openclaw/workspace/386b9e33-8429-8163-b2aa-c87831e36c20/NeonDrift_MVP__qa__notion-NeonDrift_MVP-qa-qa-full-20260621150418/project/status/qa/screenshots/ios_simulator_initial_run.png
- exists: True
- bytes: 155719
- width: 1206
- height: 2622
- nonblank_estimate: nonblank

## Runtime Log Tail
```text
Timestamp               Ty Process[PID:TID]
2026-06-21 23:04:19.256 Df CoreSimulatorBridge[50222:440c5c] Request received for installation of file:///Users/dragonkao/.openclaw/workspace/386b9e33-8429-817f-84c3-d7f2769adc34/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621150245/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app/ with options: {
    PackageType = Developer;
    SimulatorRootPath = "/Library/Developer/CoreSimulator/Volumes/iOS_23F77/Library/Developer/CoreSimulator/Profiles/Runtimes/iOS 26.5.simruntime/Contents/Resources/RuntimeRoot";
    SimulatorUserPath = "/Users/dragonkao/Library/Developer/CoreSimulator/Devices/CCB1E793-CED4-4FCD-BF73-321AAEA77AB9/data";
}
2026-06-21 23:04:19.256 Df CoreSimulatorBridge[50222:440c5c] [com.apple.installcoordination:framework] +[IXAppInstallCoordinator(IXSimpleInstaller) _beginInstallForURL:forPersonaUniqueString:consumeSource:options:progressBlock:completionWithIdentity:]: Beginning install for /Users/dragonkao/.openclaw/workspace/386b9e33-8429-817f-84c3-d7f2769adc34/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621150245/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app consuming source:N options:{
    IsUserInitiated = 1;
    PackageType = Developer;
} installationRequestorAuditToken: NULL
2026-06-21 23:04:19.257 Df installcoordinationd[73024:44ea64] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager registerPromise:]: Registered promise <IXSPlaceholder(0x10190c500) Name:App Placeholder: NeonDrift (com.DefaultCompany.NeonDrift) Creator:InstallCoordination Simple SPI UUID:401E0147-7B06-44ED-887B-5980F37B9D6B Location:[system-defined]> for UUID 401E0147-7B06-44ED-887B-5980F37B9D6B
2026-06-21 23:04:19.258 Df installcoordinationd[73024:44ea64] [com.apple.installcoordination:daemon] -[IXSPlaceholder setAttributes:]: <IXSPlaceholder(0x10190c500) Name:App Placeholder: NeonDrift (com.DefaultCompany.NeonDrift) Creator:InstallCoordination Simple SPI UUID:401E0147-7B06-44ED-887B-5980F37B9D6B Location:[system-defined]>: setting placeholder attributes to <IXPlaceholderAttributes<0x1018a4d20> : {
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
2026-06-21 23:04:19.259 Df CoreSimulatorBridge[50222:4364ed] [com.apple.installcoordination:framework] +[IXPlaceholder _setEntitlementsFromBundleExecutableURL:withBundleID:client:onPlaceholder:location:error:]: Executable for com.DefaultCompany.NeonDrift at NeonDrift -- file:///Users/dragonkao/.openclaw/workspace/386b9e33-8429-817f-84c3-d7f2769adc34/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621150245/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app/ had no entitlements
2026-06-21 23:04:19.259 Df CoreSimulatorBridge[50222:4364ed] [com.apple.installcoordination:framework] +[IXPlaceholder _placeholderForBundle:client:withParent:installType:metadata:placeholderType:mayBeDeltaPackage:isFromSerializedPlaceholder:location:error:]: Using full fidelity icons for com.DefaultCompany.NeonDrift at /Users/dragonkao/.openclaw/workspace/386b9e33-8429-817f-84c3-d7f2769adc34/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621150245/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app
2026-06-21 23:04:19.260 Df installcoordinationd[73024:44ea64] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager registerPromise:]: Registered promise <IXSPromisedTransferToPath(0x1018e5700) Name:Icon resources for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:561FCE52-7D5B-4898-9BB6-F666146CD095 Location:[system-defined]> for UUID 561FCE52-7D5B-4898-9BB6-F666146CD095
2026-06-21 23:04:19.262 Df CoreSimulatorBridge[50222:4364ed] [com.apple.installcoordination:framework] -[IXPromisedTransferToPath setComplete:]: <IXPromisedTransferToPath<0x1014746c0> name:"Icon resources for com.DefaultCompany.NeonDrift" uuid:561FCE52-7D5B-4898-9BB6-F666146CD095 creator:"InstallCoordination Simple SPI" location:[system-defined]> Move operation from /Users/dragonkao/Library/Developer/CoreSimulator/Devices/CCB1E793-CED4-4FCD-BF73-321AAEA77AB9/data/Containers/Shared/SystemGroup/systemgroup.com.apple.installcoordinationd/Library/InstallCoordination/PromiseStaging/561FCE52-7D5B-4898-9BB6-F666146CD095/temp.p4JQTw to /Users/dragonkao/Library/Developer/CoreSimulator/Devices/CCB1E793-CED4-4FCD-BF73-321AAEA77AB9/data/Containers/Shared/SystemGroup/systemgroup.com.apple.installcoordinationd/Library/InstallCoordination/PromiseStaging/561FCE52-7D5B-4898-9BB6-F666146CD095/temp.p4JQTw took 0.000041 seconds
2026-06-21 23:04:19.263 Df installcoordinationd[73024:44ea69] [com.apple.installcoordination:daemon] -[IXSDataPromise _setPercentComplete:saveStateIfNeeded:]: Progress: <IXSPromisedTransferToPath(0x1018e5700) Name:Icon resources for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:561FCE52-7D5B-4898-9BB6-F666146CD095 Location:[system-defined]>
2026-06-21 23:04:19.263 Df installcoordinationd[73024:44ea64] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promiseDidBegin:]: Unowned promise began: <IXSPromisedTransferToPath(0x1018e5700) Name:Icon resources for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:561FCE52-7D5B-4898-9BB6-F666146CD095 Location:[system-defined]>
2026-06-21 23:04:19.263 Df installcoordinationd[73024:44ea64] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promise:didUpdateProgress:]: Unowned promise update progress to 1.000000 : <IXSPromisedTransferToPath(0x1018e5700) Name:Icon resources for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:561FCE52-7D5B-4898-9BB6-F666146CD095 Location:[system-defined]>
2026-06-21 23:04:19.263 Df installcoordinationd[73024:44ea69] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promiseDidComplete:]: Unowned promise completed: <IXSPromisedTransferToPath(0x1018e5700) Name:Icon resources for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:561FCE52-7D5B-4898-9BB6-F666146CD095 Location:[system-defined]>
2026-06-21 23:04:19.264 Df installcoordinationd[73024:44ea64] [com.apple.installcoordination:daemon] -[IXSDataPromise _setPercentComplete:saveStateIfNeeded:]: Progress: <IXSPromisedInMemoryDictionary(0x1018e4f80) Name:Info.plist icon content for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:A7986F12-ACF2-49B7-B80A-4D3EC154D184 Location:[system-defined]>
2026-06-21 23:04:19.264 Df installcoordinationd[73024:44ea64] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager registerPromise:]: Registered promise <IXSPromisedInMemoryDictionary(0x1018e4f80) Name:Info.plist icon content for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:A7986F12-ACF2-49B7-B80A-4D3EC154D184 Location:[system-defined]> for UUID A7986F12-ACF2-49B7-B80A-4D3EC154D184
2026-06-21 23:04:19.264 Df installcoordinationd[73024:44ea69] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promiseDidBegin:]: Unowned promise began: <IXSPromisedInMemoryDictionary(0x1018e4f80) Name:Info.plist icon content for com.DefaultCompany.NeonDrift Creator:InstallCoordination Simple SPI UUID:A7986F12-ACF2-49B7-B80A-4D3EC154D184 Location:[system-defined]>
2026-06-21 23:04:19.264 Df installcoordinationd[73024:44ea69] [com.apple.installcoordination:daemon] -[IXSDataPromiseManager promise:didUpdateProgress:]: Unowned promise update progress to 1.000000 : <IXSPromisedInMemoryDictionary(0x1018e4f80) Name:Info.plist icon content for com.DefaultCompany.N
```
