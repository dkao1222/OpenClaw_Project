# QA Evidence Summary

## Build
```text
# Game Build Validation Report

- project_name: NeonDrift_MVP
- run_id: notion-NeonDrift_MVP-build-build-ios-simulator-20260622145134
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
<test-run testcasecount="23" result="Passed" total="23" passed="23" failed="0">
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
    <test-case name="GameplayMotionIsVerified" result="Passed" />
    <test-case name="PlayerSteeringMotionIsVerified" result="Passed" />
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
    "startButtonRect": "name=Start Button; width=300.0; height=82.0; min=(170.0,227.0); max=(470.0,309.0)",
    "settingsButtonRect": "name=Settings Button; width=300.0; height=72.0; min=(170.0,132.0); max=(470.0,204.0)",
    "pauseButtonRect": "name=Pause Button; width=96.0; height=72.0; min=(506.0,296.0); max=(602.0,368.0)",
    "retryButtonRect": "name=Retry Button; width=260.0; height=72.0; min=(190.0,98.0); max=(450.0,170.0)",
    "leftControlZoneRect": "name=Left Control Zone; width=220.0; height=140.0; min=(36.0,126.0); max=(256.0,266.0)",
    "rightControlZoneRect": "name=Right Control Zone; width=220.0; height=140.0; min=(384.0,126.0); max=(604.0,266.0)",
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
    "gameplayMotionVerified": true,
    "playerSteeringMotionVerified": true,
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
    Bundle = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CCB1E793-CED4-4FCD-BF73-321AAEA77AB9/data/Containers/Bundle/Application/9FC65977-EBE3-42E6-83EF-A572B993A642/NeonDrift.app/";
    BundleContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CCB1E793-CED4-4FCD-BF73-321AAEA77AB9/data/Containers/Bundle/Application/9FC65977-EBE3-42E6-83EF-A572B993A642/";
    CFBundleDisplayName = NeonDrift;
    CFBundleExecutable = NeonDrift;
    CFBundleIdentifier = "com.DefaultCompany.NeonDrift";
    CFBundleName = NeonDrift;
    CFBundleVersion = 0;
    DataContainer = "file:///Users/dragonkao/Library/Developer/CoreSimulator/Devices/CCB1E793-CED4-4FCD-BF73-321AAEA77AB9/data/Containers/Data/Application/C05B8D7C-34AA-4509-9008-919783AA0533/";
    GroupContainers =     {
    };
    Path = "/Users/dragonkao/Library/Developer/CoreSimulator/Devices/CCB1E793-CED4-4FCD-BF73-321AAEA77AB9/data/Containers/Bundle/Application/9FC65977-EBE3-42E6-83EF-A572B993A642/NeonDrift.app";
    SBAppTags =     (
    );
}

```

## Launch
```text
com.DefaultCompany.NeonDrift: 17319

```

## Screenshot
- path: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_initial_run.png
- exists: True
- bytes: 78510
- width: 1206
- height: 2622
- nonblank_estimate: nonblank

## Runtime Log Tail
```text
Timestamp               Ty Process[PID:TID]
2026-06-22 22:53:37.470 Df runningboardd[50195:642815] [com.apple.runningboard:process] Checking PreventLaunch: global:0 exPath:(null) predicates:{(
    <RBSProcessPredicate <RBSProcessBundleIdentifierPredicate "com.DefaultCompany.NeonDrift">>
)} allow:(null)
2026-06-22 22:53:37.480 Df runningboardd[50195:642da3] [com.apple.runningboard:process] Checking PreventLaunch: global:0 exPath:(null) predicates:{(
    <RBSProcessPredicate <RBSProcessBundleIdentifierPredicate "com.DefaultCompany.NeonDrift">>
)} allow:(null)
2026-06-22 22:54:26.483 Df runningboardd[16896:643cab] [com.apple.runningboard:process] Resolved pid 99815 to [anon<NeonDrift>:99815]
2026-06-22 22:54:26.483 Df runningboardd[16896:643cab] [com.apple.runningboard:general] Full encoding handle [anon<NeonDrift>:99815], with data 5723d111000185e7, and pid 99815
2026-06-22 22:54:26.483 Df runningboardd[16896:643cab] [com.apple.runningboard:process] [anon<NeonDrift>:99815] is not RunningBoard jetsam managed.
2026-06-22 22:54:26.483 Df runningboardd[16896:643cab] [com.apple.runningboard:process] [anon<NeonDrift>:99815] This process will not be managed.
2026-06-22 22:54:26.483 Df runningboardd[16896:643cab] [com.apple.runningboard:ttl] Now tracking process: [anon<NeonDrift>:99815]
2026-06-22 22:54:26.483 Df runningboardd[16896:643cab] [com.apple.runningboard:ttl] Acquiring assertion targeting [anon<NeonDrift>:99815] from originator [osservice<com.apple.SpringBoard>:16891] with description <RBSAssertionDescriptor| "com.apple.frontboard.workspace.reconnect" ID:16896-16891-25 target:99815 attributes:[
	<RBSDomainAttribute| domain:"com.apple.frontboard" name:"WorkspaceReconnect" sourceEnvironment:"(null)">
	]>
2026-06-22 22:54:26.483 Df runningboardd[16896:643cab] [com.apple.runningboard:ttl] Assertion 16896-16891-25 (target:[anon<NeonDrift>:99815]) will be created as active
2026-06-22 22:54:26.483 Df runningboardd[16896:643caa] [com.apple.runningboard:process] [anon<NeonDrift>:99815] Ignoring jetsam update because this process is not memory-managed
2026-06-22 22:54:26.483 Df runningboardd[16896:643caa] [com.apple.runningboard:process] [anon<NeonDrift>:99815] Ignoring suspend because this process is not lifecycle managed
2026-06-22 22:54:26.484 Df runningboardd[16896:643caa] [com.apple.runningboard:process] [anon<NeonDrift>:99815] Ignoring role changes because this process is not role managed
2026-06-22 22:54:26.484 Df runningboardd[16896:643caa] [com.apple.runningboard:process] [anon<NeonDrift>:99815] Ignoring GPU update because this process is not GPU managed
2026-06-22 22:54:26.484 Df runningboardd[16896:643caa] [com.apple.runningboard:process] [anon<NeonDrift>:99815] Ignoring memory limit update because this process is not memory-managed
2026-06-22 22:54:26.869 Sd runningboardd[16896:0] (8FCF1609-E151-3057-8E2C-8F6F0AE39DF8) RBSStateCaptureSet Segment 1
<RBConnectionClient| 16945 name:osservice<com.apple.liveactivitiesd> entitlements:<RBEntitlements| [
			com.apple.runningboard.sessionkitd,
			com.apple.runningboard.process-state,
			com.apple.assertiond.app-state-monitor
			]> inheritanceManager:<RBClientInheritanceManager| >><RBAssertion| identifier:16896-16891-5 target:[osservice<com.apple.SpringBoard>:16891] explanation:"FBSystemShell" active originator:[osservice<com.apple.SpringBoard>:16891] transientState:<RBAssertionTransientState| policies:[
	
	] tags:[
	SupportsBackgroundAudio> intransientState:<RBAssertionIntransientState| strt:Unspecified end:WarnOnly nvld:0.00 warn:0.00dreldom prevSus runningReason:10005 legRes:0 doms:com.apple.frontboard:SystemShell invOnConds:(null)> processState:<RBProcessState| role:UserInteractiveFocal> suspended: attributes:[
	<RBSDomainAttribute| domain:"com.apple.frontboard" name:"SystemShell" sourceEnvironment:"(null)">
	]><RBConnectionClient| 16917 name:osservice<com.apple.locationd> entitlements:<RBEntitlements| [
			com.apple.backboard.client,
			com.apple.private.applemediaservices,
			com.apple.assertiond.app-state-monitor,
			com.apple.runningboard.process-state,
			com.apple.multitasking.unlimitedassertions,
			com.apple.runningboard.assertions.locationd
			]> inheritanceManager:<RBClientInheritanceManager| >><RBAssertion| identifier:16896-16896-2 target:[osservice<com.apple.SpringBoard>:16891] explanation:"RB Underlying Assertion" active originator:[osservice<com.apple.SpringBoard>:16891] transientState:<RBAssertionTransientState| policies:[
	
	]> intransientState:<RBAssertionIntransientState| strt:Unspecified end:WarnOnly nvld:0.00 warn:0.00dom prevSus runningReason:20209 legRes:0 doms:com.apple.underlying:UnderlyingDarwinRoleUI invOnConds:(null)> processState:<RBProcessState| role:UserInteractiveNonFocal> suspended: attributes:[
	<RBSDomainAttribute| domain:"com.apple.underlying" name:"UnderlyingDarwinRoleUI" sourceEnvironment:"(null)">,
	<RBSAcquisitionCompletionAttribute| policy:AfterApplication>
	]><RBAssertion| identifier:16896-16891-25 target:[anon<NeonDrift>:99815] explanation:"com.apple.frontboard.workspace.reconnect" active originator:[osservice<com.apple.SpringBoard>:16891] transientState:<RBAssertionTransientState| policies:[
	
	] tags:[
	SupportsBackgroundAudio> intransientState:<RBAssertionIntransientState| strt:Fixed end:Invalidate nvld:600.00 warn:0.00dom prevSus runningReason:20216 legRes:0 doms:com.apple.frontboard:WorkspaceReconnect invOnConds:(null)> processState:<RBProcessState| role:Background> suspended: attributes:[
	<RBSDomainAttribute| domain:"com.apple.frontboard" name:"WorkspaceReconnect" sourceEnvironment:"(null)">
	]><RBAssertion| identifier:16896-16891-63 target:[osservice<com.apple.SpringBoard>:16891] explanation:"Shared Background Assertion 0 for com.apple.springboard" originator:[osservice<com.apple.SpringBoard>:16891] intransientState:<RBAssertionIntransientState| strt:Delayed-Relative end:InvalidateAndTerminateProcess nvld:30.00 warn:5.00 prevSus runningReason:0 legRes:4 doms:(null) invOnConds:{
    therm = 860;
}> suspended: attributes:[
	<RBSLegacyAttribute| requestedReason:FinishTask reason:FinishTask flags:( PreventTaskSuspend )>,
	<RBSAcquisitionCompletionAttribute| policy:AfterValidation>
	]><RBProcessMonitorObserver| qos:25 qos:<RBSProcessStateDescriptor| values:3> configs:{
		3="M16891-3"
		2="M16891-2"
		1="M16891-1"
		4="M16891-4"
	}><RBConnectionClient| 16908 name:osservice<com.apple.mobiletimerd> entitlements:<RBEntitlements| [
			com.apple.assertiond.app-state-monitor,
			com.apple.runningboard.attributes.bannerrequest,
			com.apple.runningboard.launchprocess
			]> inheritanceManager:<RBClientInheritanceManager| >><RBConnectionClient| 16914 name:osservice<com.apple.backboardd> entitlements:<RBEntitlements| [
			com.apple.backboard.client,
			com.apple.runningboard.terminateprocess,
			com.apple.runningboard.primitiveattribute,
			com.apple.private.xpc.launchd.app-server,
			com.apple.assertiond.app-state-monitor,
			com.apple.runningboard.terminatemanagedprocesses
			]> inheritanceManager:<RBClientInheritanceManager| >><RBConnectionClient| 16939 name:osservice<com.apple.pasteboard.pasted> entitlements:<RBEntitlements| [
			com.apple.runningboard.assertions.pasteboard,
			com.apple.assertiond.app-state-monitor,
			com.apple.frontboard.disable-watchdog
			]> inheritanceManager:<RBClientInheritanceManager| >><RBAssertion| identifier:16896-16891-65 target:[osservice<com.apple.SpringBoard>:16891] explanation:"app_launch_measurement: pageins recording enabled" active originator:[osservice<com.apple.SpringBoard>:16891] intransientState:<RBAssertionIntransientState| strt:Unspecified end:WarnOnly nvld:0.00 warn:0.00dom runningReason:20838 legRes:0 doms:com.apple.pagein-prefetching:LaunchPrefetch invOnConds:(null)> suspended: attributes:[
	<RBSDomainAttribute| domain:"com.apple.pagein-prefetching" name:"LaunchPrefetch" sourceEnvironment:"(null)">
	]><RBConnectionClient| 16951 name:osservice<com.apple.chronod> entitlements:<RBEntitlements| [
			com.apple.runningboard.a
```
