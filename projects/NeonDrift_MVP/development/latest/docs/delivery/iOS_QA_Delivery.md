# iOS QA Delivery

## 繁體中文

- 專案: NeonDrift_MVP
- run_id: notion-NeonDrift_MVP-qa-qa-full-20260626142735
- 交付狀態: blocked
- QA 狀態: failed
- Release candidate: blocked
- checks_total: 136
- checks_failed: 11
- checks_blocked: 0
- bundle_id: com.DefaultCompany.NeonDrift.run.1782483975.50560

## iOS Simulator App

- app_path: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.run.1782483975.50560.app`

## Install And Launch

```bash
xcrun simctl install booted /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.run.1782483975.50560.app
xcrun simctl launch booted com.DefaultCompany.NeonDrift.run.1782483975.50560
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

- playthrough_video_exists: {'exists': False, 'bytes': 0}
- qa_menu_human_readability_gate: menuVisualMetrics={'exists': True, 'width': 1206, 'height': 2622, 'sample_count': 40000, 'min_luma': 0.0, 'max_luma': 58.072, 'mean_luma': 31.883, 'dark_ratio': 0.4052, 'bright_ratio': 0.0, 'very_bright_ratio': 0.0, 'saturated_color_ratio': 0.0, 'color_bucket_count': 14}, menuHumanReadable=False.
- qa_game_over_visual_state_gate: gameOverProbePresent=True, screenState='game_over', isGameOver=True, gameOverPanelVisible=True, gameplayToGameOver={'comparable': True, 'mean_abs_diff': 1.611, 'changed_ratio': 0.0092, 'sample_count': 12000, 'changed': True}, gameOverVisualMetrics={'exists': True, 'width': 1206, 'height': 2622, 'sample_count': 40000, 'min_luma': 0.0, 'max_luma': 255.0, 'mean_luma': 43.161, 'dark_ratio': 0.4379, 'bright_ratio': 0.1372, 'very_bright_ratio': 0.0144, 'saturated_color_ratio': 0.3256, 'color_bucket_count': 120}, gameOverVisualStateVisible=False.
- qa_retry_visual_recovery_gate: retryProbePresent=True, screenState='gameplay', isGameOver=False, gameOverPanelVisible=False, gameOverToRetry={'comparable': True, 'mean_abs_diff': 0.746, 'changed_ratio': 0.0041, 'sample_count': 12000, 'changed': True}, retryVisualMetrics={'exists': True, 'width': 1206, 'height': 2622, 'sample_count': 40000, 'min_luma': 0.0, 'max_luma': 255.0, 'mean_luma': 43.177, 'dark_ratio': 0.4374, 'bright_ratio': 0.1368, 'very_bright_ratio': 0.0146, 'saturated_color_ratio': 0.326, 'color_bucket_count': 121}, retryVisualStateVisible=False.
- qa_non_placeholder_visual_richness_gate: gameplayVisualMetrics={'exists': True, 'width': 1206, 'height': 2622, 'sample_count': 40000, 'min_luma': 0.0, 'max_luma': 255.0, 'mean_luma': 43.248, 'dark_ratio': 0.4374, 'bright_ratio': 0.1387, 'very_bright_ratio': 0.0144, 'saturated_color_ratio': 0.326, 'color_bucket_count': 123}, gameplayNonPlaceholderVisuals=False.
- qa_actual_gameplay_quality_gate: tenSecondPlayabilityVerified=True, enemyPatternPressureVerified=True, skillRewardLoopVerified=True, humanPlaytestChecklistVerified=True, TenSecondPlayabilityVerified=True, EnemyPatternPressureVerified=True, SkillRewardLoopVerified=True, HumanPlaytestChecklistVerified=True, video=False, gameplayScreenshot=True, menuToGameplayChanged=True.
- qa_visual_richness_quality_gate: gameplayVisualsVerified=True, gameplayInstructionReadableVerified=True, videoExists=False, menuToGameplayChanged=True, gameplayToGameOverChanged=True, menuHumanReadable=False, gameplayNonPlaceholderVisuals=False, gameOverVisualStateVisible=False, retryVisualStateVisible=False, GameplayVisualsAreReadable=True.
- qa_retry_restarts_gameplay_gate: retryRestartsGameplayVerified=True, RetryRestartsGameplay=True, gameOverToRetryChanged=True, retryVisualStateVisible=False.
- qa_human_visual_judgement_gate: videoExists=False, menuScreenshot=True, gameplayScreenshot=True, gameOverScreenshot=True, retryScreenshot=True, menuToGameplayChanged=True, gameplayToGameOverChanged=True, gameOverToRetryChanged=True, menuHumanReadable=False, gameplayNonPlaceholderVisuals=False, gameOverVisualStateVisible=False, retryVisualStateVisible=False, gameplayInstructionReadableVerified=True, gameplayVisualsVerified=True.
- qa_product_experience_gate: menuLayoutVerified=True, menuElementsDoNotOverlap=True, gameplayHudHiddenInMenu=True, gameplayControlsHiddenInMenu=True, menuHumanReadable=False, hasObjectiveText=True, hasAvoidInstructionText=True, hasPlayerLabel=True, hasHazardLabel=True, hasScoreText=True, hasPulseText=True, gameplayInstructionReadableVerified=True, gameplayVisualsVerified=True, buttonLayoutVerified=True, menuButtonSizeVerified=True, pauseRetryButtonSizeVerified=True, controlZoneSizeVerified=True, controlsInsideSafeArea=True, controlsDoNotOverlap=True, failureRetrySystemVerified=True, retryRestartsGameplayVerified=True, retryProbePresent=True, retryIsGameOver=False, retryGameOverPanelVisible=False, videoExists=False, menuScreenshot=True, gameplayScreenshot=True, gameOverScreenshot=True, retryScreenshot=True, menuToGameplayChanged=True, gameplayToGameOverChanged=True, gameOverToRetryChanged=True, gameplayNonPlaceholderVisuals=False, gameOverVisualStateVisible=False, retryVisualStateVisible=False.
- qa_style_frame_implementation_gate: styleFrameReport=True, missingStyleFrameMarkers=[], video=False, menuScreenshot=True, gameplayScreenshot=True, gameOverScreenshot=True, retryScreenshot=True, menuToGameplayChanged=True, gameplayToGameOverChanged=True, gameOverToRetryChanged=True, menuHumanReadable=False, gameplayNonPlaceholderVisuals=False, gameOverVisualStateVisible=False, retryVisualStateVisible=False.

## English Summary

Delivery status is blocked. QA status is failed; release candidate status is blocked.
