# DMAIC Pipeline Review

## Summary

- status: failed
- project_name: NeonDrift_MVP
- chain_id: spec-review:NeonDrift_MVP:38bb9e33-19189169
- run_id: notion-NeonDrift_MVP-dmaic-20260626142354
- source_pipeline: qa
- checks_total: 10
- checks_failed: 2

## Define

- Problem statement: pipeline output must be detailed, playable, visually rich, evidence-backed, and traceable from raw idea to QA.
- Customer requirement: Notion must show whether planning/spec/development/build/QA evidence is sufficient before advancing.

## Measure

- PASS raw_idea_defined: passed
- PASS define_contract_present: passed
- PASS planning_depth_present: passed
- PASS spec_review_actionable: passed
- PASS development_unity_project_present: passed
- PASS development_runtime_probe_present: passed
- PASS build_evidence_present: passed
- FAIL qa_evidence_present: marker:product experience
- FAIL qa_hard_gates_present: marker:recording
- PASS qa_runtime_evidence_artifacts_present: passed

## Analyze

- qa_evidence_present: marker:product experience
- qa_hard_gates_present: marker:recording

## Root Causes

- qa_recording_gap -> qa: QA did not produce required simulator playthrough recording evidence.
- product_experience_gap -> development: Runtime product experience is not human-readable enough; this requires implementation changes, not only QA rerun.
- visual_richness_gap -> development: Runtime visuals are still too placeholder/dark/static for release quality.
- gameplay_playability_gap -> development: Runtime gameplay fails human playability expectations and must be changed in implementation.
- qa_evidence_gap -> qa: QA evidence package is incomplete.

## Improve

- remediation_target: development
- Return to QA/Development loop: require simulator video, screenshots, product experience, human visual judgement, and every core gameplay function evidence.
- Create remediation Notion row targeting development; do not stop at reporting.

## Remediation Request

DMAIC remediation target: development

Root causes:
- qa_recording_gap: QA did not produce required simulator playthrough recording evidence.
- product_experience_gap: Runtime product experience is not human-readable enough; this requires implementation changes, not only QA rerun.
- visual_richness_gap: Runtime visuals are still too placeholder/dark/static for release quality.
- gameplay_playability_gap: Runtime gameplay fails human playability expectations and must be changed in implementation.
- qa_evidence_gap: QA evidence package is incomplete.

Required correction:
- Do not mark the remediation passed unless generated runtime/product evidence directly resolves the listed root causes.
- Preserve the Chain ID and source DMAIC report for traceability.
- If returning to Development, fix implementation, visual readability, gameplay playability, runtime QA probe/evidence, and retry/menu/gameplay states before Build.
- If returning to QA, rerun simulator QA and produce screenshots, video/recording evidence, raw evidence JSON, and human product-experience checks.

Observed QA failure signals:
- - QA 結果: failed
- - Release candidate: blocked
- | unity_editmode_tests_passed | Regression | PASS | 3 total, 0 failed. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_editmode_test_results.xml |
- | unity_playmode_tests_passed | Regression | PASS | 33 total, 0 failed. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
- | playthrough_video_exists | Playthrough | FAIL | {'exists': False, 'bytes': 0} | missing playthrough video evidence |
- | qa_menu_human_readability_gate | Visual | FAIL | menuVisualMetrics={'exists': True, 'width': 1206, 'height': 2622, 'sample_count': 40000, 'min_luma': 0.0, 'max_luma': 58.072, 'mean_luma': 31.919, 'dark_ratio': 0.4052, 'bright_ratio': 0.0,
- | qa_game_over_visual_state_gate | Visual | FAIL | gameOverProbePresent=True, screenState='game_over', isGameOver=True, gameOverPanelVisible=True, gameplayToGameOver={'comparable': True, 'mean_abs_diff': 1.614, 'changed_ratio': 0.0092, 'sam
- | qa_retry_visual_recovery_gate | Visual | FAIL | retryProbePresent=True, screenState='gameplay', isGameOver=False, gameOverPanelVisible=False, gameOverToRetry={'comparable': True, 'mean_abs_diff': 0.695, 'changed_ratio': 0.0038, 'sample_co
- | qa_non_placeholder_visual_richness_gate | Visual | FAIL | gameplayVisualMetrics={'exists': True, 'width': 1206, 'height': 2622, 'sample_count': 40000, 'min_luma': 0.0, 'max_luma': 255.0, 'mean_luma': 43.224, 'dark_ratio': 0.4379, 'bright_
- | qa_actual_gameplay_quality_gate | Gameplay | FAIL | tenSecondPlayabilityVerified=True, enemyPatternPressureVerified=True, skillRewardLoopVerified=True, humanPlaytestChecklistVerified=True, TenSecondPlayabilityVerified=True, EnemyPatternPr
- | qa_visual_richness_quality_gate | Visual | FAIL | gameplayVisualsVerified=True, gameplayInstructionReadableVerified=True, videoExists=False, menuToGameplayChanged=True, gameplayToGameOverChanged=True, menuHumanReadable=False, gameplayNonP
- | qa_retry_restarts_gameplay_gate | Gameplay | FAIL | retryRestartsGameplayVerified=True, RetryRestartsGameplay=True, gameOverToRetryChanged=True, retryVisualStateVisible=False. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae
- | qa_human_visual_judgement_gate | Visual | FAIL | videoExists=False, menuScreenshot=True, gameplayScreenshot=True, gameOverScreenshot=True, retryScreenshot=True, menuToGameplayChanged=True, gameplayToGameOverChanged=True, gameOverToRetryCh
- | qa_product_experience_gate | Gameplay | FAIL | menuLayoutVerified=True, menuElementsDoNotOverlap=True, gameplayHudHiddenInMenu=True, gameplayControlsHiddenInMenu=True, menuHumanReadable=False, hasObjectiveText=True, hasAvoidInstructionTex
- | qa_style_frame_implementation_gate | Visual | FAIL | styleFrameReport=True, missingStyleFrameMarkers=[], video=False, menuScreenshot=True, gameplayScreenshot=True, gameOverScreenshot=True, retryScreenshot=True, menuToGameplayChanged=True,
- - qa_product_experience_gate: FAIL

## Control

- Keep this DMAIC row linked by Chain ID and source page.
- Any future QA pass without product experience, human visual judgement, function playability, and recording evidence must remain failed.
- Any Development pass without runtime implementation evidence must be blocked before Build.

## QA Failure Signals

- QA 結果: failed
- Release candidate: blocked
| unity_editmode_tests_passed | Regression | PASS | 3 total, 0 failed. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_editmode_test_results.xml |
| unity_playmode_tests_passed | Regression | PASS | 33 total, 0 failed. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| playthrough_video_exists | Playthrough | FAIL | {'exists': False, 'bytes': 0} | missing playthrough video evidence |
| qa_menu_human_readability_gate | Visual | FAIL | menuVisualMetrics={'exists': True, 'width': 1206, 'height': 2622, 'sample_count': 40000, 'min_luma': 0.0, 'max_luma': 58.072, 'mean_luma': 31.919, 'dark_ratio': 0.4052, 'bright_ratio': 0.0,
| qa_game_over_visual_state_gate | Visual | FAIL | gameOverProbePresent=True, screenState='game_over', isGameOver=True, gameOverPanelVisible=True, gameplayToGameOver={'comparable': True, 'mean_abs_diff': 1.614, 'changed_ratio': 0.0092, 'sam
| qa_retry_visual_recovery_gate | Visual | FAIL | retryProbePresent=True, screenState='gameplay', isGameOver=False, gameOverPanelVisible=False, gameOverToRetry={'comparable': True, 'mean_abs_diff': 0.695, 'changed_ratio': 0.0038, 'sample_co
| qa_non_placeholder_visual_richness_gate | Visual | FAIL | gameplayVisualMetrics={'exists': True, 'width': 1206, 'height': 2622, 'sample_count': 40000, 'min_luma': 0.0, 'max_luma': 255.0, 'mean_luma': 43.224, 'dark_ratio': 0.4379, 'bright_
| qa_actual_gameplay_quality_gate | Gameplay | FAIL | tenSecondPlayabilityVerified=True, enemyPatternPressureVerified=True, skillRewardLoopVerified=True, humanPlaytestChecklistVerified=True, TenSecondPlayabilityVerified=True, EnemyPatternPr
| qa_visual_richness_quality_gate | Visual | FAIL | gameplayVisualsVerified=True, gameplayInstructionReadableVerified=True, videoExists=False, menuToGameplayChanged=True, gameplayToGameOverChanged=True, menuHumanReadable=False, gameplayNonP
| qa_retry_restarts_gameplay_gate | Gameplay | FAIL | retryRestartsGameplayVerified=True, RetryRestartsGameplay=True, gameOverToRetryChanged=True, retryVisualStateVisible=False. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae
| qa_human_visual_judgement_gate | Visual | FAIL | videoExists=False, menuScreenshot=True, gameplayScreenshot=True, gameOverScreenshot=True, retryScreenshot=True, menuToGameplayChanged=True, gameplayToGameOverChanged=True, gameOverToRetryCh
| qa_product_experience_gate | Gameplay | FAIL | menuLayoutVerified=True, menuElementsDoNotOverlap=True, gameplayHudHiddenInMenu=True, gameplayControlsHiddenInMenu=True, menuHumanReadable=False, hasObjectiveText=True, hasAvoidInstructionTex
| qa_style_frame_implementation_gate | Visual | FAIL | styleFrameReport=True, missingStyleFrameMarkers=[], video=False, menuScreenshot=True, gameplayScreenshot=True, gameOverScreenshot=True, retryScreenshot=True, menuToGameplayChanged=True,
- qa_product_experience_gate: FAIL
- qa_human_visual_judgement_gate: FAIL
QA status is failed. 11 checks failed and 0 checks are blocked.
- status: failed
- qa_overall_status: failed
"overall_status": "failed",
"release_candidate_status": "blocked",
"expected": "Build validation report status is passed with zero failed checks.",
"actual": "3 total, 0 failed.",
"actual": "33 total, 0 failed.",
"expected": "Early gameplay cannot immediately fail before readable player response time.",
"expected": "Early gameplay cannot immediately fail after Start.",
"status": "FAIL",
"evidence": "missing playthrough video evidence",
"status": "FAIL",
"status": "FAIL",
"status": "FAIL",
"status": "FAIL",
"status": "FAIL",
"status": "FAIL",
"status": "FAIL",
"status": "FAIL",
"status": "FAIL",
"status": "FAIL",
