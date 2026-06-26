# iOS QA Delivery

## 繁體中文

- 專案: NeonDrift_MVP
- run_id: notion-NeonDrift_MVP-qa-qa-full-20260626133148
- 交付狀態: blocked
- QA 狀態: failed
- Release candidate: blocked
- checks_total: 136
- checks_failed: 8
- checks_blocked: 0
- bundle_id: com.DefaultCompany.NeonDrift.run.1782480634.15608

## iOS Simulator App

- app_path: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.run.1782480634.15608.app`

## Install And Launch

```bash
xcrun simctl install booted /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.run.1782480634.15608.app
xcrun simctl launch booted com.DefaultCompany.NeonDrift.run.1782480634.15608
```

## 必交付檔案

- QA result: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/qa_result.json`
- QA report: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/full_qa_report.md`
- QA validation: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/qa_full_validation.md`
- Evidence index: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence_index.md`
- Delivery manifest: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/delivery/qa_delivery_manifest.json`

## Evidence

- build_report: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/build_full_validation.md`
- runtime_probe: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/qa_runtime_probe_gameplay.json`
- screenshot: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_menu.png`
- runtime_log: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/logs/ios_simulator_runtime.log`
- raw_evidence: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/raw_evidence.json`
- evidence_summary: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/evidence_summary.md`

## Required Fixes

- playthrough_video_exists: {'exists': False, 'bytes': 0}
- qa_menu_human_readability_gate: menuVisualMetrics={'exists': True, 'width': 1206, 'height': 2622, 'sample_count': 40000, 'min_luma': 0.0, 'max_luma': 86.072, 'mean_luma': 28.425, 'dark_ratio': 0.7537, 'bright_ratio': 0.0002, 'very_bright_ratio': 0.0, 'saturated_color_ratio': 0.0175, 'color_bucket_count': 23}, menuHumanReadable=False.
- qa_non_placeholder_visual_richness_gate: gameplayVisualMetrics={'exists': True, 'width': 1206, 'height': 2622, 'sample_count': 40000, 'min_luma': 0.0, 'max_luma': 255.0, 'mean_luma': 24.561, 'dark_ratio': 0.7648, 'bright_ratio': 0.0271, 'very_bright_ratio': 0.0134, 'saturated_color_ratio': 0.0914, 'color_bucket_count': 104}, gameplayNonPlaceholderVisuals=False.
- qa_actual_gameplay_quality_gate: tenSecondPlayabilityVerified=True, enemyPatternPressureVerified=True, skillRewardLoopVerified=True, humanPlaytestChecklistVerified=True, TenSecondPlayabilityVerified=True, EnemyPatternPressureVerified=True, SkillRewardLoopVerified=True, HumanPlaytestChecklistVerified=True, video=False, gameplayScreenshot=True, menuToGameplayChanged=True.
- qa_visual_richness_quality_gate: gameplayVisualsVerified=True, gameplayInstructionReadableVerified=True, videoExists=False, menuToGameplayChanged=True, gameplayToGameOverChanged=True, menuHumanReadable=False, gameplayNonPlaceholderVisuals=False, gameOverVisualStateVisible=True, retryVisualStateVisible=True, GameplayVisualsAreReadable=True.
- qa_human_visual_judgement_gate: videoExists=False, menuScreenshot=True, gameplayScreenshot=True, gameOverScreenshot=True, retryScreenshot=True, menuToGameplayChanged=True, gameplayToGameOverChanged=True, gameOverToRetryChanged=True, menuHumanReadable=False, gameplayNonPlaceholderVisuals=False, gameOverVisualStateVisible=True, retryVisualStateVisible=True, gameplayInstructionReadableVerified=True, gameplayVisualsVerified=True.
- qa_product_experience_gate: menuLayoutVerified=True, menuElementsDoNotOverlap=True, gameplayHudHiddenInMenu=True, gameplayControlsHiddenInMenu=True, menuHumanReadable=False, hasObjectiveText=True, hasAvoidInstructionText=True, hasPlayerLabel=True, hasHazardLabel=True, hasScoreText=True, hasPulseText=True, gameplayInstructionReadableVerified=True, gameplayVisualsVerified=True, buttonLayoutVerified=True, menuButtonSizeVerified=True, pauseRetryButtonSizeVerified=True, controlZoneSizeVerified=True, controlsInsideSafeArea=True, controlsDoNotOverlap=True, failureRetrySystemVerified=True, retryRestartsGameplayVerified=True, retryProbePresent=True, retryIsGameOver=False, retryGameOverPanelVisible=False, videoExists=False, menuScreenshot=True, gameplayScreenshot=True, gameOverScreenshot=True, retryScreenshot=True, menuToGameplayChanged=True, gameplayToGameOverChanged=True, gameOverToRetryChanged=True, gameplayNonPlaceholderVisuals=False, gameOverVisualStateVisible=True, retryVisualStateVisible=True.
- qa_style_frame_implementation_gate: styleFrameReport=True, missingStyleFrameMarkers=[], video=False, menuScreenshot=True, gameplayScreenshot=True, gameOverScreenshot=True, retryScreenshot=True, menuToGameplayChanged=True, gameplayToGameOverChanged=True, gameOverToRetryChanged=True, menuHumanReadable=False, gameplayNonPlaceholderVisuals=False, gameOverVisualStateVisible=True, retryVisualStateVisible=True.

## English Summary

Delivery status is blocked. QA status is failed; release candidate status is blocked.
