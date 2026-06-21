# Full QA Report

- 專案: NeonDrift_MVP
- run_id: qa-new-gate-smoke
- QA 結果: failed
- Release candidate: blocked
- checks_total: 59
- checks_failed: 18
- checks_blocked: 0

## 檢查表
| ID | Area | Status | Actual | Evidence |
| --- | --- | --- | --- | --- |
| build_validation_passed | Build | PASS | build_full_validation.md contains status: passed. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/build_full_validation.md |
| xcodebuild_ios_simulator_passed | Build | PASS | Build report contains PASS xcodebuild_ios_simulator. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/build_full_validation.md |
| unity_editmode_tests_passed | Regression | PASS | 3 total, 0 failed. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_editmode_test_results.xml |
| unity_playmode_tests_passed | Regression | PASS | 14 total, 0 failed. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| runtime_probe_has_start_button | UI/UX | PASS | hasStartButton=True in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_has_settings_button | UI/UX | PASS | hasSettingsButton=True in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_has_best_score_text | UI/UX | PASS | hasBestScoreText=True in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_has_pause_button | Interaction | PASS | hasPauseButton=True in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_has_retry_button | Interaction | PASS | hasRetryButton=True in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_has_left_control_zone | Interaction | PASS | hasLeftControlZone=True in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_has_right_control_zone | Interaction | PASS | hasRightControlZone=True in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_pause_control_verified | Interaction | PASS | pauseControlVerified=True in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_retry_control_verified | Interaction | PASS | retryControlVerified=True in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_left_right_steering_verified | Interaction | PASS | leftRightSteeringVerified=True in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_safe_area_applied | Compatibility | PASS | safeAreaApplied=True in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_frame_pacing_configured | Performance | PASS | framePacingConfigured=True in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_has_event_system | Interaction | PASS | hasEventSystem=True in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_has_graphic_raycaster | Interaction | PASS | hasGraphicRaycaster=True in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_has_ui_actions | Interaction | PASS | hasUiActions=True in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_start_button_clickable | Interaction | PASS | startButtonClickable=True in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_settings_button_clickable | Interaction | PASS | settingsButtonClickable=True in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_pause_button_clickable | Interaction | PASS | pauseButtonClickable=True in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_retry_button_clickable | Interaction | PASS | retryButtonClickable=True in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_button_layout_verified | UI/UX | FAIL | buttonLayoutVerified=None in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_menu_button_size_verified | UI/UX | FAIL | menuButtonSizeVerified=None in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_pause_retry_button_size_verified | UI/UX | FAIL | pauseRetryButtonSizeVerified=None in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_control_zone_size_verified | Interaction | FAIL | controlZoneSizeVerified=None in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_controls_inside_safe_area | Compatibility | FAIL | controlsInsideSafeArea=None in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_controls_do_not_overlap | UI/UX | FAIL | controlsDoNotOverlap=None in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_core_gameplay_objects_verified | Runtime | FAIL | coreGameplayObjectsVerified=None in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_scoring_system_verified | Runtime | FAIL | scoringSystemVerified=None in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_pause_system_verified | Interaction | FAIL | pauseSystemVerified=None in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_failure_retry_system_verified | Interaction | FAIL | failureRetrySystemVerified=None in runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_target_frame_rate | Performance | PASS | targetFrameRate=60. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_exception_count_zero | Runtime | PASS | exceptionCount=0. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| playmode_main_menu_contract | UI/UX | PASS | MainMenuHasStartSettingsBestScore found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_pause_control_contract | UI/UX | PASS | PauseControlPresent found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_left_right_control_contract | UI/UX | PASS | LeftRightControlZonesPresent found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_retry_control_contract | UI/UX | PASS | RetryControlPresent found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_button_position_size_contract | UI/UX | FAIL | ButtonPositionsAndSizesAreVerified not found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_core_gameplay_function_contract | UI/UX | FAIL | CoreGameplayFunctionsAreVerified not found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_safe_area_frame_pacing_contract | UI/UX | PASS | SafeAreaAndFramePacingConfigured found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_ui_event_system_contract | UI/UX | PASS | UiEventSystemPresent found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_menu_buttons_clickable_contract | UI/UX | PASS | MenuButtonsClickable found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_pause_retry_buttons_clickable_contract | UI/UX | PASS | PauseRetryButtonsClickable found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| simulator_app_binary_arm64 | Build | PASS | /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app/NeonDrift: Mach-O 64-bit executable arm64 | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/app_binary_file.txt |
| simulator_appinfo_available | Install | PASS | appinfo contains CFBundleIdentifier. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/appinfo.txt |
| simulator_launch_attempted | Launch | PASS | com.DefaultCompany.NeonDrift: 89313 | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/launch.txt |
| screenshot_nonblank | UI/UX | PASS | {'exists': True, 'bytes': 155385, 'width': 1206, 'height': 2622, 'nonblank_estimate': 'nonblank', 'sample_unique_values': 222} | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_initial_run.png |
| runtime_log_no_fatal_exception | Runtime | PASS | No fatal signature found. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/logs/ios_simulator_runtime.log |
| compact_iphone_safe_area_compatibility | Compatibility | PASS | screen=640x480, safeAreaApplied=True. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| hud_score_contract_present | UI/UX | PASS | hasScoreText=True, hasPulseText=True. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| failure_retry_state_contract_present | UI/UX | PASS | hasGameOverPanel=True, hasRetryButton=True. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_start_button_rect_present | UI/UX | FAIL | startButtonRect=None. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_settings_button_rect_present | UI/UX | FAIL | settingsButtonRect=None. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_pause_button_rect_present | UI/UX | FAIL | pauseButtonRect=None. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_retry_button_rect_present | UI/UX | FAIL | retryButtonRect=None. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_left_control_zone_rect_present | UI/UX | FAIL | leftControlZoneRect=None. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| runtime_probe_right_control_zone_rect_present | UI/UX | FAIL | rightControlZoneRect=None. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |

## 必須修正
- runtime_probe_button_layout_verified: buttonLayoutVerified=None in runtime_probe.json.
- runtime_probe_menu_button_size_verified: menuButtonSizeVerified=None in runtime_probe.json.
- runtime_probe_pause_retry_button_size_verified: pauseRetryButtonSizeVerified=None in runtime_probe.json.
- runtime_probe_control_zone_size_verified: controlZoneSizeVerified=None in runtime_probe.json.
- runtime_probe_controls_inside_safe_area: controlsInsideSafeArea=None in runtime_probe.json.
- runtime_probe_controls_do_not_overlap: controlsDoNotOverlap=None in runtime_probe.json.
- runtime_probe_core_gameplay_objects_verified: coreGameplayObjectsVerified=None in runtime_probe.json.
- runtime_probe_scoring_system_verified: scoringSystemVerified=None in runtime_probe.json.
- runtime_probe_pause_system_verified: pauseSystemVerified=None in runtime_probe.json.
- runtime_probe_failure_retry_system_verified: failureRetrySystemVerified=None in runtime_probe.json.
- playmode_button_position_size_contract: ButtonPositionsAndSizesAreVerified not found in PlayMode XML.
- playmode_core_gameplay_function_contract: CoreGameplayFunctionsAreVerified not found in PlayMode XML.
- runtime_probe_start_button_rect_present: startButtonRect=None.
- runtime_probe_settings_button_rect_present: settingsButtonRect=None.
- runtime_probe_pause_button_rect_present: pauseButtonRect=None.
- runtime_probe_retry_button_rect_present: retryButtonRect=None.
- runtime_probe_left_control_zone_rect_present: leftControlZoneRect=None.
- runtime_probe_right_control_zone_rect_present: rightControlZoneRect=None.

## English Summary
QA status is failed. 18 checks failed and 0 checks are blocked.
