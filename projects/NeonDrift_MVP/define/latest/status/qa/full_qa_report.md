# Full QA Report

- 專案: NeonDrift_MVP
- run_id: notion-NeonDrift_MVP-qa-qa-full-20260624160353
- QA 結果: failed
- Release candidate: blocked
- checks_total: 125
- checks_failed: 78
- checks_blocked: 0

## 檢查表
| ID | Area | Status | Actual | Evidence |
| --- | --- | --- | --- | --- |
| build_validation_passed | Build | PASS | build_full_validation.md contains status: passed. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/build_full_validation.md |
| xcodebuild_ios_simulator_passed | Build | PASS | Build report contains PASS xcodebuild_ios_simulator. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/build_full_validation.md |
| unity_editmode_tests_passed | Regression | PASS | 3 total, 0 failed. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_editmode_test_results.xml |
| unity_playmode_tests_passed | Regression | PASS | 33 total, 0 failed. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| simulator_live_gameplay_probe_present | Runtime | FAIL | runtime_probe=missing, build_runtime_probe=/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json |
| simulator_live_menu_probe_present | Runtime | FAIL | runtime_probe_menu=missing. | missing live simulator menu probe |
| runtime_probe_has_start_button | UI/UX | FAIL | hasStartButton=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_has_settings_button | UI/UX | FAIL | hasSettingsButton=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_has_best_score_text | UI/UX | FAIL | hasBestScoreText=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_has_pause_button | Interaction | FAIL | hasPauseButton=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_has_retry_button | Interaction | FAIL | hasRetryButton=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_has_left_control_zone | Interaction | FAIL | hasLeftControlZone=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_has_right_control_zone | Interaction | FAIL | hasRightControlZone=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_pause_control_verified | Interaction | FAIL | pauseControlVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_retry_control_verified | Interaction | FAIL | retryControlVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_left_right_steering_verified | Interaction | FAIL | leftRightSteeringVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_safe_area_applied | Compatibility | FAIL | safeAreaApplied=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_frame_pacing_configured | Performance | FAIL | framePacingConfigured=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_has_event_system | Interaction | FAIL | hasEventSystem=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_has_graphic_raycaster | Interaction | FAIL | hasGraphicRaycaster=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_has_ui_actions | Interaction | FAIL | hasUiActions=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_start_button_clickable | Interaction | FAIL | startButtonClickable=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_settings_button_clickable | Interaction | FAIL | settingsButtonClickable=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_pause_button_clickable | Interaction | FAIL | pauseButtonClickable=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_retry_button_clickable | Interaction | FAIL | retryButtonClickable=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_button_layout_verified | UI/UX | FAIL | buttonLayoutVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_menu_button_size_verified | UI/UX | FAIL | menuButtonSizeVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_pause_retry_button_size_verified | UI/UX | FAIL | pauseRetryButtonSizeVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_control_zone_size_verified | Interaction | FAIL | controlZoneSizeVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_controls_inside_safe_area | Compatibility | FAIL | controlsInsideSafeArea=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_controls_do_not_overlap | UI/UX | FAIL | controlsDoNotOverlap=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_core_gameplay_objects_verified | Runtime | FAIL | coreGameplayObjectsVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_scoring_system_verified | Runtime | FAIL | scoringSystemVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_pause_system_verified | Interaction | FAIL | pauseSystemVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_failure_retry_system_verified | Interaction | FAIL | failureRetrySystemVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_start_flow_verified | Interaction | FAIL | startFlowVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_start_button_starts_game_verified | Interaction | FAIL | startButtonStartsGameVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_initial_has_not_started | Interaction | FAIL | hasStarted=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_menu_layout_verified | UI/UX | FAIL | menuLayoutVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_menu_elements_do_not_overlap | UI/UX | FAIL | menuElementsDoNotOverlap=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_gameplay_hud_hidden_in_menu | UI/UX | FAIL | gameplayHudHiddenInMenu=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_gameplay_controls_hidden_in_menu | UI/UX | FAIL | gameplayControlsHiddenInMenu=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_gameplay_visuals_verified | Gameplay | FAIL | gameplayVisualsVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_gameplay_visuals_hidden_in_menu | Gameplay | FAIL | gameplayVisualsHiddenInMenu=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_has_objective_text | Gameplay | FAIL | hasObjectiveText=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_has_avoid_instruction_text | Gameplay | FAIL | hasAvoidInstructionText=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_has_player_label | Gameplay | FAIL | hasPlayerLabel=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_has_hazard_label | Gameplay | FAIL | hasHazardLabel=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_gameplay_instruction_readable_verified | Gameplay | FAIL | gameplayInstructionReadableVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_content_depth_verified | Gameplay | FAIL | contentDepthVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_gameplay_motion_verified | Gameplay | FAIL | gameplayMotionVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_hazard_approach_motion_verified | Gameplay | FAIL | hazardApproachMotionVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_player_steering_motion_verified | Gameplay | FAIL | playerSteeringMotionVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_human_agency_verified | Gameplay | FAIL | humanAgencyVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_player_input_changes_outcome_verified | Gameplay | FAIL | playerInputChangesOutcomeVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_early_game_over_protected | Gameplay | FAIL | earlyGameOverProtected=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_readable_hazard_pacing_verified | Gameplay | FAIL | readableHazardPacingVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_ten_second_playability_verified | Gameplay | FAIL | tenSecondPlayabilityVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_enemy_pattern_pressure_verified | Gameplay | FAIL | enemyPatternPressureVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_skill_reward_loop_verified | Gameplay | FAIL | skillRewardLoopVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_human_playtest_checklist_verified | Gameplay | FAIL | humanPlaytestChecklistVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_target_frame_rate | Performance | FAIL | targetFrameRate=0. | missing runtime_probe.json |
| runtime_probe_exception_count_zero | Runtime | FAIL | exceptionCount=None. | missing runtime_probe.json |
| runtime_probe_gameplay_claims_require_running_state | Gameplay | PASS | screenState=None, hasStarted=None, gameplayTime=None, score=None, claimed_flags=[]. | missing runtime_probe.json |
| runtime_probe_not_menu_when_actual_gameplay_claimed | Gameplay | PASS | screenState=None, hasStarted=None, claimed_flags=[]. | missing runtime_probe.json |
| playmode_main_menu_contract | UI/UX | PASS | MainMenuHasStartSettingsBestScore found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_pause_control_contract | UI/UX | PASS | PauseControlPresent found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_left_right_control_contract | UI/UX | PASS | LeftRightControlZonesPresent found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_retry_control_contract | UI/UX | PASS | RetryControlPresent found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_button_position_size_contract | UI/UX | PASS | ButtonPositionsAndSizesAreVerified found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_core_gameplay_function_contract | UI/UX | PASS | CoreGameplayFunctionsAreVerified found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_initial_state_waits_for_start_contract | UI/UX | PASS | InitialStateWaitsForStart found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_menu_layout_readable_contract | UI/UX | PASS | MenuLayoutIsReadable found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_gameplay_visuals_readable_contract | UI/UX | PASS | GameplayVisualsAreReadable found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_gameplay_instruction_readable_contract | UI/UX | PASS | GameplayInstructionReadable found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_content_depth_contract | UI/UX | PASS | ContentDepthIsVerified found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_gameplay_motion_contract | UI/UX | PASS | GameplayMotionIsVerified found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_hazard_approach_motion_contract | UI/UX | PASS | HazardApproachMotionIsVerified found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_player_steering_motion_contract | UI/UX | PASS | PlayerSteeringMotionIsVerified found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_human_agency_changes_outcome_contract | UI/UX | PASS | HumanAgencyChangesOutcome found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_ten_second_playability_contract | UI/UX | PASS | TenSecondPlayabilityVerified found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_enemy_pattern_pressure_contract | UI/UX | PASS | EnemyPatternPressureVerified found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_skill_reward_loop_contract | UI/UX | PASS | SkillRewardLoopVerified found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_human_playtest_checklist_contract | UI/UX | PASS | HumanPlaytestChecklistVerified found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_start_button_flow_contract | UI/UX | PASS | StartButtonFlowVerified found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_early_game_over_protection_contract | UI/UX | PASS | EarlyGameOverIsProtected found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_safe_area_frame_pacing_contract | UI/UX | PASS | SafeAreaAndFramePacingConfigured found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_ui_event_system_contract | UI/UX | PASS | UiEventSystemPresent found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_menu_buttons_clickable_contract | UI/UX | PASS | MenuButtonsClickable found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playmode_pause_retry_buttons_clickable_contract | UI/UX | PASS | PauseRetryButtonsClickable found in PlayMode XML. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| simulator_app_binary_arm64 | Build | PASS | /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app/NeonDrift: Mach-O 64-bit executable arm64 | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/app_binary_file.txt |
| simulator_appinfo_available | Install | PASS | appinfo contains CFBundleIdentifier. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/appinfo.txt |
| simulator_launch_attempted | Launch | PASS | com.DefaultCompany.NeonDrift: 8353 | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/launch.txt |
| screenshot_nonblank | UI/UX | PASS | {'exists': True, 'bytes': 80377, 'width': 1206, 'height': 2622, 'nonblank_estimate': 'nonblank', 'sample_unique_values': 33} | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_menu.png |
| playthrough_video_exists | Playthrough | PASS | {'exists': True, 'bytes': 3785841} | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/simulator_playthrough.mp4 |
| playthrough_interaction_script_log_exists | Playthrough | PASS | QA playthrough script:
1. write qa_playthrough.flag into simulator app data container
2. launch app with -qaPlaythrough fallback arg
3. app auto-starts after the menu has loaded
4. app steers left/right
5. app triggers game over after readable survival window
6. app retries to menu
qa_playthrough_flag_targets=['/Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data/Containers/Data/Application/8E6A44AA-6592-4DD9-853A-D48C431AA049/Documents/qa_playthrough.flag', '/Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data/Containers/Data/Application/8E6A44AA-6592-4DD9-853A-D48C431AA049/qa_playthrough.flag']
menu_screenshot: exit=0, path=/Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_menu.png
gameplay_screenshot: exit=0, path=/Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/s | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/interaction_script.log |
| playthrough_trigger_flag_written | Playthrough | PASS | QA playthrough flag targets:
/Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data/Containers/Data/Application/8E6A44AA-6592-4DD9-853A-D48C431AA049/Documents/qa_playthrough.flag
/Users/dragonkao/Library/Developer/CoreSimulator/Devices/115FDF0C-5A2F-4686-909B-7F43F1450A28/data/Containers/Data/Application/8E6A44AA-6592-4DD9-853A-D48C431AA049/qa_playthrough.flag
 | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/qa_playthrough_flag.txt |
| playthrough_menu_screenshot_nonblank | Playthrough | PASS | {'exists': True, 'bytes': 80377, 'width': 1206, 'height': 2622, 'nonblank_estimate': 'nonblank', 'sample_unique_values': 33} | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_menu.png |
| playthrough_gameplay_screenshot_nonblank | Playthrough | PASS | {'exists': True, 'bytes': 133756, 'width': 1206, 'height': 2622, 'nonblank_estimate': 'nonblank', 'sample_unique_values': 218} | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_gameplay.png |
| playthrough_game_over_screenshot_nonblank | Playthrough | PASS | {'exists': True, 'bytes': 155106, 'width': 1206, 'height': 2622, 'nonblank_estimate': 'nonblank', 'sample_unique_values': 249} | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_game_over.png |
| playthrough_retry_screenshot_nonblank | Playthrough | PASS | {'exists': True, 'bytes': 134028, 'width': 1206, 'height': 2622, 'nonblank_estimate': 'nonblank', 'sample_unique_values': 219} | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_after_retry.png |
| playthrough_retry_screenshot_has_ui_variance | Playthrough | PASS | {'exists': True, 'bytes': 134028, 'width': 1206, 'height': 2622, 'nonblank_estimate': 'nonblank', 'sample_unique_values': 219} | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_after_retry.png |
| playthrough_menu_to_gameplay_changed | Playthrough | PASS | {'comparable': True, 'mean_abs_diff': 30.718, 'changed_ratio': 0.1852, 'sample_count': 12000, 'changed': True} | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_gameplay.png |
| playthrough_gameplay_to_game_over_changed | Playthrough | PASS | {'comparable': True, 'mean_abs_diff': 4.061, 'changed_ratio': 0.0181, 'sample_count': 12000, 'changed': True} | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_game_over.png |
| playthrough_game_over_to_retry_changed | Playthrough | PASS | {'comparable': True, 'mean_abs_diff': 3.823, 'changed_ratio': 0.0156, 'sample_count': 12000, 'changed': True} | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_after_retry.png |
| runtime_log_no_fatal_exception | Runtime | PASS | No fatal signature found. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/logs/ios_simulator_runtime.log |
| compact_iphone_safe_area_compatibility | Compatibility | FAIL | screen=NonexNone, safeAreaApplied=None. | missing runtime_probe.json |
| hud_score_contract_present | UI/UX | FAIL | hasScoreText=None, hasPulseText=None. | missing runtime_probe.json |
| failure_retry_state_contract_present | UI/UX | FAIL | hasGameOverPanel=None, hasRetryButton=None. | missing runtime_probe.json |
| runtime_probe_start_button_rect_present | UI/UX | FAIL | startButtonRect=None. | missing runtime_probe.json |
| runtime_probe_settings_button_rect_present | UI/UX | FAIL | settingsButtonRect=None. | missing runtime_probe.json |
| runtime_probe_pause_button_rect_present | UI/UX | FAIL | pauseButtonRect=None. | missing runtime_probe.json |
| runtime_probe_retry_button_rect_present | UI/UX | FAIL | retryButtonRect=None. | missing runtime_probe.json |
| runtime_probe_left_control_zone_rect_present | UI/UX | FAIL | leftControlZoneRect=None. | missing runtime_probe.json |
| runtime_probe_right_control_zone_rect_present | UI/UX | FAIL | rightControlZoneRect=None. | missing runtime_probe.json |
| qa_gameplay_depth_quality_gate | Gameplay | FAIL | contentDepthVerified=None, gameplayMotionVerified=None, hazardApproachMotionVerified=None, playerSteeringMotionVerified=None, humanAgencyVerified=None, playerInputChangesOutcomeVerified=None, readableHazardPacingVerified=None, ContentDepthIsVerified=True. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| qa_actual_gameplay_quality_gate | Gameplay | FAIL | tenSecondPlayabilityVerified=None, enemyPatternPressureVerified=None, skillRewardLoopVerified=None, humanPlaytestChecklistVerified=None, TenSecondPlayabilityVerified=True, EnemyPatternPressureVerified=True, SkillRewardLoopVerified=True, HumanPlaytestChecklistVerified=True, video=True, gameplayScreenshot=True, menuToGameplayChanged=True. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| qa_human_interaction_quality_gate | Gameplay | FAIL | humanAgencyVerified=None, playerInputChangesOutcomeVerified=None, HumanAgencyChangesOutcome=True. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| qa_visual_richness_quality_gate | Visual | FAIL | gameplayVisualsVerified=None, gameplayInstructionReadableVerified=None, videoExists=True, menuToGameplayChanged=True, gameplayToGameOverChanged=True, GameplayVisualsAreReadable=True. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/evidence_summary.json |
| qa_game_system_design_gate | Gameplay | FAIL | coreGameplayObjectsVerified=None, scoringSystemVerified=None, failureRetrySystemVerified=None, hasObjectiveText=None, hasAvoidInstructionText=None, CoreGameplayFunctionsAreVerified=True, StartButtonFlowVerified=True, EarlyGameOverIsProtected=True. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| qa_retry_restarts_gameplay_gate | Gameplay | FAIL | retryRestartsGameplayVerified=None, RetryRestartsGameplay=True, gameOverToRetryChanged=True. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| qa_retry_live_probe_leaves_failure_state | Gameplay | FAIL | screenState=None, isGameOver=None, gameOverPanelVisible=None. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_after_retry.png |
| qa_audio_feedback_gate | Runtime | FAIL | soundToggleAudioVerified=None, audioSourcePresent=None, SoundToggleAudioVerified=True. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| qa_ui_state_isolation_gate | UI/UX | FAIL | menuLayoutVerified=None, menuElementsDoNotOverlap=None, gameplayHudHiddenInMenu=None, gameplayControlsHiddenInMenu=None, gameOverPanelVisible=None, menuToGameplayChanged=True, gameplayToGameOverChanged=True. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/evidence_summary.json |
| qa_human_visual_judgement_gate | Visual | FAIL | videoExists=True, menuScreenshot=True, gameplayScreenshot=True, gameOverScreenshot=True, retryScreenshot=True, menuToGameplayChanged=True, gameplayToGameOverChanged=True, gameOverToRetryChanged=True, gameplayInstructionReadableVerified=None, gameplayVisualsVerified=None. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/evidence_summary.json |

## 必須修正
- simulator_live_gameplay_probe_present: runtime_probe=missing, build_runtime_probe=/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json.
- simulator_live_menu_probe_present: runtime_probe_menu=missing.
- runtime_probe_has_start_button: hasStartButton=None in missing runtime probe.
- runtime_probe_has_settings_button: hasSettingsButton=None in missing runtime probe.
- runtime_probe_has_best_score_text: hasBestScoreText=None in missing runtime probe.
- runtime_probe_has_pause_button: hasPauseButton=None in missing runtime probe.
- runtime_probe_has_retry_button: hasRetryButton=None in missing runtime probe.
- runtime_probe_has_left_control_zone: hasLeftControlZone=None in missing runtime probe.
- runtime_probe_has_right_control_zone: hasRightControlZone=None in missing runtime probe.
- runtime_probe_pause_control_verified: pauseControlVerified=None in missing runtime probe.
- runtime_probe_retry_control_verified: retryControlVerified=None in missing runtime probe.
- runtime_probe_left_right_steering_verified: leftRightSteeringVerified=None in missing runtime probe.
- runtime_probe_safe_area_applied: safeAreaApplied=None in missing runtime probe.
- runtime_probe_frame_pacing_configured: framePacingConfigured=None in missing runtime probe.
- runtime_probe_has_event_system: hasEventSystem=None in missing runtime probe.
- runtime_probe_has_graphic_raycaster: hasGraphicRaycaster=None in missing runtime probe.
- runtime_probe_has_ui_actions: hasUiActions=None in missing runtime probe.
- runtime_probe_start_button_clickable: startButtonClickable=None in missing runtime probe.
- runtime_probe_settings_button_clickable: settingsButtonClickable=None in missing runtime probe.
- runtime_probe_pause_button_clickable: pauseButtonClickable=None in missing runtime probe.
- runtime_probe_retry_button_clickable: retryButtonClickable=None in missing runtime probe.
- runtime_probe_button_layout_verified: buttonLayoutVerified=None in missing runtime probe.
- runtime_probe_menu_button_size_verified: menuButtonSizeVerified=None in missing runtime probe.
- runtime_probe_pause_retry_button_size_verified: pauseRetryButtonSizeVerified=None in missing runtime probe.
- runtime_probe_control_zone_size_verified: controlZoneSizeVerified=None in missing runtime probe.
- runtime_probe_controls_inside_safe_area: controlsInsideSafeArea=None in missing runtime probe.
- runtime_probe_controls_do_not_overlap: controlsDoNotOverlap=None in missing runtime probe.
- runtime_probe_core_gameplay_objects_verified: coreGameplayObjectsVerified=None in missing runtime probe.
- runtime_probe_scoring_system_verified: scoringSystemVerified=None in missing runtime probe.
- runtime_probe_pause_system_verified: pauseSystemVerified=None in missing runtime probe.
- runtime_probe_failure_retry_system_verified: failureRetrySystemVerified=None in missing runtime probe.
- runtime_probe_start_flow_verified: startFlowVerified=None in missing runtime probe.
- runtime_probe_start_button_starts_game_verified: startButtonStartsGameVerified=None in missing runtime probe.
- runtime_probe_initial_has_not_started: hasStarted=None in missing runtime probe.
- runtime_probe_menu_layout_verified: menuLayoutVerified=None in missing runtime probe.
- runtime_probe_menu_elements_do_not_overlap: menuElementsDoNotOverlap=None in missing runtime probe.
- runtime_probe_gameplay_hud_hidden_in_menu: gameplayHudHiddenInMenu=None in missing runtime probe.
- runtime_probe_gameplay_controls_hidden_in_menu: gameplayControlsHiddenInMenu=None in missing runtime probe.
- runtime_probe_gameplay_visuals_verified: gameplayVisualsVerified=None in missing runtime probe.
- runtime_probe_gameplay_visuals_hidden_in_menu: gameplayVisualsHiddenInMenu=None in missing runtime probe.
- runtime_probe_has_objective_text: hasObjectiveText=None in missing runtime probe.
- runtime_probe_has_avoid_instruction_text: hasAvoidInstructionText=None in missing runtime probe.
- runtime_probe_has_player_label: hasPlayerLabel=None in missing runtime probe.
- runtime_probe_has_hazard_label: hasHazardLabel=None in missing runtime probe.
- runtime_probe_gameplay_instruction_readable_verified: gameplayInstructionReadableVerified=None in missing runtime probe.
- runtime_probe_content_depth_verified: contentDepthVerified=None in missing runtime probe.
- runtime_probe_gameplay_motion_verified: gameplayMotionVerified=None in missing runtime probe.
- runtime_probe_hazard_approach_motion_verified: hazardApproachMotionVerified=None in missing runtime probe.
- runtime_probe_player_steering_motion_verified: playerSteeringMotionVerified=None in missing runtime probe.
- runtime_probe_human_agency_verified: humanAgencyVerified=None in missing runtime probe.
- runtime_probe_player_input_changes_outcome_verified: playerInputChangesOutcomeVerified=None in missing runtime probe.
- runtime_probe_early_game_over_protected: earlyGameOverProtected=None in missing runtime probe.
- runtime_probe_readable_hazard_pacing_verified: readableHazardPacingVerified=None in missing runtime probe.
- runtime_probe_ten_second_playability_verified: tenSecondPlayabilityVerified=None in missing runtime probe.
- runtime_probe_enemy_pattern_pressure_verified: enemyPatternPressureVerified=None in missing runtime probe.
- runtime_probe_skill_reward_loop_verified: skillRewardLoopVerified=None in missing runtime probe.
- runtime_probe_human_playtest_checklist_verified: humanPlaytestChecklistVerified=None in missing runtime probe.
- runtime_probe_target_frame_rate: targetFrameRate=0.
- runtime_probe_exception_count_zero: exceptionCount=None.
- compact_iphone_safe_area_compatibility: screen=NonexNone, safeAreaApplied=None.
- hud_score_contract_present: hasScoreText=None, hasPulseText=None.
- failure_retry_state_contract_present: hasGameOverPanel=None, hasRetryButton=None.
- runtime_probe_start_button_rect_present: startButtonRect=None.
- runtime_probe_settings_button_rect_present: settingsButtonRect=None.
- runtime_probe_pause_button_rect_present: pauseButtonRect=None.
- runtime_probe_retry_button_rect_present: retryButtonRect=None.
- runtime_probe_left_control_zone_rect_present: leftControlZoneRect=None.
- runtime_probe_right_control_zone_rect_present: rightControlZoneRect=None.
- qa_gameplay_depth_quality_gate: contentDepthVerified=None, gameplayMotionVerified=None, hazardApproachMotionVerified=None, playerSteeringMotionVerified=None, humanAgencyVerified=None, playerInputChangesOutcomeVerified=None, readableHazardPacingVerified=None, ContentDepthIsVerified=True.
- qa_actual_gameplay_quality_gate: tenSecondPlayabilityVerified=None, enemyPatternPressureVerified=None, skillRewardLoopVerified=None, humanPlaytestChecklistVerified=None, TenSecondPlayabilityVerified=True, EnemyPatternPressureVerified=True, SkillRewardLoopVerified=True, HumanPlaytestChecklistVerified=True, video=True, gameplayScreenshot=True, menuToGameplayChanged=True.
- qa_human_interaction_quality_gate: humanAgencyVerified=None, playerInputChangesOutcomeVerified=None, HumanAgencyChangesOutcome=True.
- qa_visual_richness_quality_gate: gameplayVisualsVerified=None, gameplayInstructionReadableVerified=None, videoExists=True, menuToGameplayChanged=True, gameplayToGameOverChanged=True, GameplayVisualsAreReadable=True.
- qa_game_system_design_gate: coreGameplayObjectsVerified=None, scoringSystemVerified=None, failureRetrySystemVerified=None, hasObjectiveText=None, hasAvoidInstructionText=None, CoreGameplayFunctionsAreVerified=True, StartButtonFlowVerified=True, EarlyGameOverIsProtected=True.
- qa_retry_restarts_gameplay_gate: retryRestartsGameplayVerified=None, RetryRestartsGameplay=True, gameOverToRetryChanged=True.
- qa_retry_live_probe_leaves_failure_state: screenState=None, isGameOver=None, gameOverPanelVisible=None.
- qa_audio_feedback_gate: soundToggleAudioVerified=None, audioSourcePresent=None, SoundToggleAudioVerified=True.
- qa_ui_state_isolation_gate: menuLayoutVerified=None, menuElementsDoNotOverlap=None, gameplayHudHiddenInMenu=None, gameplayControlsHiddenInMenu=None, gameOverPanelVisible=None, menuToGameplayChanged=True, gameplayToGameOverChanged=True.
- qa_human_visual_judgement_gate: videoExists=True, menuScreenshot=True, gameplayScreenshot=True, gameOverScreenshot=True, retryScreenshot=True, menuToGameplayChanged=True, gameplayToGameOverChanged=True, gameOverToRetryChanged=True, gameplayInstructionReadableVerified=None, gameplayVisualsVerified=None.

## English Summary
QA status is failed. 78 checks failed and 0 checks are blocked.
