# iOS QA Delivery

## 繁體中文

- 專案: NeonDrift_MVP
- run_id: notion-NeonDrift_MVP-qa-qa-full-20260711062458
- 交付狀態: blocked
- QA 狀態: failed
- Release candidate: blocked
- checks_total: 151
- checks_failed: 10
- checks_blocked: 0
- bundle_id: com.DefaultCompany.NeonDrift

## iOS Simulator App

- app_path: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app`

## Install And Launch

```bash
xcrun simctl install booted /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.app
xcrun simctl launch booted com.DefaultCompany.NeonDrift
```

## 必交付檔案

- QA result: `/Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/qa_result.json`
- QA report: `/Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/full_qa_report.md`
- QA validation: `/Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/qa_full_validation.md`
- Evidence index: `/Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence_index.md`
- Delivery manifest: `/Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/delivery/qa_delivery_manifest.json`

## Evidence

- build_report: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/build_full_validation.md`
- runtime_probe: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/qa_runtime_probe_gameplay.json`
- screenshot: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_menu.png`
- runtime_log: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/logs/ios_simulator_runtime.log`
- raw_evidence: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/raw_evidence.json`
- evidence_summary: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/evidence_summary.md`

## Required Fixes

- qa_retry_visual_recovery_gate: retryProbePresent=False, screenState=None, isGameOver=None, gameOverPanelVisible=None, gameOverToRetry={'comparable': True, 'mean_abs_diff': 1.975, 'changed_ratio': 0.0085, 'sample_count': 12000, 'changed': True}, retryVisualMetrics={'exists': True, 'width': 1206, 'height': 2622, 'sample_count': 40000, 'min_luma': 0.0, 'max_luma': 255.0, 'mean_luma': 53.63, 'dark_ratio': 0.4042, 'bright_ratio': 0.2542, 'very_bright_ratio': 0.037, 'saturated_color_ratio': 0.4793, 'color_bucket_count': 140}, retryVisualStateVisible=False.
- qa_retry_live_motion_after_retry_gate: retryProbePresent=False, retryLiveProbePresent=False, retryScreenState=None, retryLiveScreenState=None, retryGameplayTime=None, retryLiveGameplayTime=None, retryScore=None, retryLiveScore=None, retryLiveFps=None, retryLiveIsGameOver=None, retryLiveIsPaused=None, retryLiveGameOverPanelVisible=None, retryToRetryLive={'comparable': True, 'mean_abs_diff': 0.05, 'changed_ratio': 0.0004, 'sample_count': 12000, 'changed': False}, retryLiveVisualMetrics={'exists': True, 'width': 1206, 'height': 2622, 'sample_count': 40000, 'min_luma': 0.0, 'max_luma': 255.0, 'mean_luma': 53.65, 'dark_ratio': 0.4041, 'bright_ratio': 0.2541, 'very_bright_ratio': 0.0372, 'saturated_color_ratio': 0.4793, 'color_bucket_count': 144}, retryLiveMotionVerified=False.
- playthrough_retry_to_retry_live_changed: {'comparable': True, 'mean_abs_diff': 0.05, 'changed_ratio': 0.0004, 'sample_count': 12000, 'changed': False}
- qa_visual_richness_quality_gate: gameplayVisualsVerified=True, gameplayInstructionReadableVerified=True, humanReadableGameplayContractVerified=True, videoExists=True, menuToGameplayChanged=True, gameplayToGameOverChanged=True, menuHumanReadable=True, gameplayNonPlaceholderVisuals=True, gameOverVisualStateVisible=True, retryVisualStateVisible=False, GameplayVisualsAreReadable=True.
- qa_retry_restarts_gameplay_gate: retryRestartsGameplayVerified=True, RetryRestartsGameplay=True, RawRetryRestartsMovingGameplay=False, gameOverToRetryChanged=True, retryVisualStateVisible=False.
- qa_retry_live_probe_leaves_failure_state: screenState=None, isGameOver=None, gameOverPanelVisible=None.
- qa_human_visual_judgement_gate: videoExists=True, menuScreenshot=True, gameplayScreenshot=True, gameOverScreenshot=True, retryScreenshot=True, retryLiveScreenshot=True, menuToGameplayChanged=True, gameplayToGameOverChanged=True, gameOverToRetryChanged=True, retryToRetryLiveChanged=False, menuHumanReadable=True, gameplayNonPlaceholderVisuals=True, gameOverVisualStateVisible=True, retryVisualStateVisible=False, retryLiveMotionVerified=False, gameplayInstructionReadableVerified=True, humanReadableGameplayContractVerified=True, firstRunClarityVerified=True, gameplayVisualsVerified=True.
- qa_product_experience_gate: menuLayoutVerified=True, menuElementsDoNotOverlap=True, gameplayHudHiddenInMenu=True, gameplayControlsHiddenInMenu=True, menuHumanReadable=True, hasObjectiveText=True, hasAvoidInstructionText=True, hasTrackMeaningText=True, hasControlMeaningText=True, hasPlayerLabel=True, hasHazardLabel=True, hasScoreText=True, hasPulseText=True, gameplayInstructionReadableVerified=True, trackPurposeReadableVerified=True, leftRightControlMeaningVerified=True, firstRunClarityVerified=True, humanReadableGameplayContractVerified=True, gameplayVisualsVerified=True, buttonLayoutVerified=True, menuButtonSizeVerified=True, pauseRetryButtonSizeVerified=True, controlZoneSizeVerified=True, controlsInsideSafeArea=True, controlsDoNotOverlap=True, failureRetrySystemVerified=True, retryRestartsGameplayVerified=True, retryProbePresent=False, retryIsGameOver=None, retryGameOverPanelVisible=None, retryLiveMotionVerified=False, videoExists=True, menuScreenshot=True, gameplayScreenshot=True, gameOverScreenshot=True, retryScreenshot=True, retryLiveScreenshot=True, menuToGameplayChanged=True, gameplayToGameOverChanged=True, gameOverToRetryChanged=True, retryToRetryLiveChanged=False, gameplayNonPlaceholderVisuals=True, gameOverVisualStateVisible=True, retryVisualStateVisible=False.
- qa_style_frame_implementation_gate: styleFrameReport=True, missingStyleFrameMarkers=[], video=True, menuScreenshot=True, gameplayScreenshot=True, gameOverScreenshot=True, retryScreenshot=True, menuToGameplayChanged=True, gameplayToGameOverChanged=True, gameOverToRetryChanged=True, menuHumanReadable=True, gameplayNonPlaceholderVisuals=True, gameOverVisualStateVisible=True, retryVisualStateVisible=False.
- qa_common_sense_veto_gate: commonSenseVetoFailures=qa_retry_visual_recovery_gate=FAIL, qa_retry_live_motion_after_retry_gate=FAIL, qa_visual_richness_quality_gate=FAIL, qa_retry_restarts_gameplay_gate=FAIL, qa_human_visual_judgement_gate=FAIL, qa_product_experience_gate=FAIL, qa_style_frame_implementation_gate=FAIL; dependencyStatuses={'qa_menu_human_readability_gate': 'PASS', 'qa_game_over_visual_state_gate': 'PASS', 'qa_retry_visual_recovery_gate': 'FAIL', 'qa_retry_live_motion_after_retry_gate': 'FAIL', 'qa_non_placeholder_visual_richness_gate': 'PASS', 'qa_gameplay_depth_quality_gate': 'PASS', 'qa_actual_gameplay_quality_gate': 'PASS', 'qa_human_interaction_quality_gate': 'PASS', 'qa_visual_richness_quality_gate': 'FAIL', 'qa_first_run_gameplay_comprehension_gate': 'PASS', 'qa_game_system_design_gate': 'PASS', 'qa_retry_restarts_gameplay_gate': 'FAIL', 'qa_audio_feedback_gate': 'PASS', 'qa_ui_state_isolation_gate': 'PASS', 'qa_human_visual_judgement_gate': 'FAIL', 'qa_product_experience_gate': 'FAIL', 'qa_style_frame_implementation_gate': 'FAIL'}.

## English Summary

Delivery status is blocked. QA status is failed; release candidate status is blocked.
