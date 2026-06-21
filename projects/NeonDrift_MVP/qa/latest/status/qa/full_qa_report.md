# Full QA Report

- 專案: NeonDrift_MVP
- run_id: notion-NeonDrift_MVP-qa-qa-full-20260621144918
- QA 結果: passed
- Release candidate: ready
- checks_total: 31
- checks_failed: 0
- checks_blocked: 0

## 檢查表
| ID | Area | Status | Actual | Evidence |
| --- | --- | --- | --- | --- |
| build_validation_passed | Build | PASS | build_full_validation.md contains status: passed. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/validation/build_full_validation.md |
| xcodebuild_ios_simulator_passed | Build | PASS | Build report contains PASS xcodebuild_ios_simulator. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/validation/build_full_validation.md |
| unity_editmode_tests_passed | Regression | PASS | 3 total, 0 failed. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/validation/unity_editmode_test_results.xml |
| unity_playmode_tests_passed | Regression | PASS | 11 total, 0 failed. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/validation/unity_playmode_test_results.xml |
| runtime_probe_has_start_button | UI/UX | PASS | hasStartButton=True in runtime_probe.json. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_has_settings_button | UI/UX | PASS | hasSettingsButton=True in runtime_probe.json. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_has_best_score_text | UI/UX | PASS | hasBestScoreText=True in runtime_probe.json. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_has_pause_button | Interaction | PASS | hasPauseButton=True in runtime_probe.json. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_has_retry_button | Interaction | PASS | hasRetryButton=True in runtime_probe.json. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_has_left_control_zone | Interaction | PASS | hasLeftControlZone=True in runtime_probe.json. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_has_right_control_zone | Interaction | PASS | hasRightControlZone=True in runtime_probe.json. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_pause_control_verified | Interaction | PASS | pauseControlVerified=True in runtime_probe.json. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_retry_control_verified | Interaction | PASS | retryControlVerified=True in runtime_probe.json. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_left_right_steering_verified | Interaction | PASS | leftRightSteeringVerified=True in runtime_probe.json. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_safe_area_applied | Compatibility | PASS | safeAreaApplied=True in runtime_probe.json. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_frame_pacing_configured | Performance | PASS | framePacingConfigured=True in runtime_probe.json. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_target_frame_rate | Performance | PASS | targetFrameRate=60. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_exception_count_zero | Runtime | PASS | exceptionCount=0. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/qa/evidence/runtime_probe.json |
| playmode_main_menu_contract | UI/UX | PASS | MainMenuHasStartSettingsBestScore found in PlayMode XML. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/validation/unity_playmode_test_results.xml |
| playmode_pause_control_contract | UI/UX | PASS | PauseControlPresent found in PlayMode XML. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/validation/unity_playmode_test_results.xml |
| playmode_left_right_control_contract | UI/UX | PASS | LeftRightControlZonesPresent found in PlayMode XML. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/validation/unity_playmode_test_results.xml |
| playmode_retry_control_contract | UI/UX | PASS | RetryControlPresent found in PlayMode XML. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/validation/unity_playmode_test_results.xml |
| playmode_safe_area_frame_pacing_contract | UI/UX | PASS | SafeAreaAndFramePacingConfigured found in PlayMode XML. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/validation/unity_playmode_test_results.xml |
| simulator_app_binary_arm64 | Build | PASS | /Users/dragonkao/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app/NeonDrift: Mach-O 64-bit executable arm64 | /home/node/.openclaw/workspace/386b9e33-8429-812e-aea5-c0a0cde76485/NeonDrift_MVP__qa__notion-NeonDrift_MVP-qa-qa-full-20260621144918/project/status/qa/evidence/app_binary_file.txt |
| simulator_appinfo_available | Install | PASS | appinfo contains CFBundleIdentifier. | /home/node/.openclaw/workspace/386b9e33-8429-812e-aea5-c0a0cde76485/NeonDrift_MVP__qa__notion-NeonDrift_MVP-qa-qa-full-20260621144918/project/status/qa/evidence/appinfo.txt |
| simulator_launch_attempted | Launch | PASS | com.DefaultCompany.NeonDrift: 73054 | /home/node/.openclaw/workspace/386b9e33-8429-812e-aea5-c0a0cde76485/NeonDrift_MVP__qa__notion-NeonDrift_MVP-qa-qa-full-20260621144918/project/status/qa/evidence/launch.txt |
| screenshot_nonblank | UI/UX | PASS | {'exists': True, 'bytes': 155034, 'width': 1206, 'height': 2622, 'nonblank_estimate': 'nonblank', 'sample_unique_values': 222} | /home/node/.openclaw/workspace/386b9e33-8429-812e-aea5-c0a0cde76485/NeonDrift_MVP__qa__notion-NeonDrift_MVP-qa-qa-full-20260621144918/project/status/qa/screenshots/ios_simulator_initial_run.png |
| runtime_log_no_fatal_exception | Runtime | PASS | No fatal signature found. | /home/node/.openclaw/workspace/386b9e33-8429-812e-aea5-c0a0cde76485/NeonDrift_MVP__qa__notion-NeonDrift_MVP-qa-qa-full-20260621144918/project/status/qa/logs/ios_simulator_runtime.log |
| compact_iphone_safe_area_compatibility | Compatibility | PASS | screen=640x480, safeAreaApplied=True. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/qa/evidence/runtime_probe.json |
| hud_score_contract_present | UI/UX | PASS | hasScoreText=True, hasPulseText=True. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/qa/evidence/runtime_probe.json |
| failure_retry_state_contract_present | UI/UX | PASS | hasGameOverPanel=True, hasRetryButton=True. | /home/node/.openclaw/workspace/386b9e33-8429-81e8-822b-f6239d850088/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621144554/project/status/qa/evidence/runtime_probe.json |

## 必須修正
- 無

## English Summary
QA status is passed. 0 checks failed and 0 checks are blocked.
