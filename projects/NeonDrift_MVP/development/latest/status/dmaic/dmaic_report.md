# DMAIC Pipeline Review

## Summary

- status: failed
- project_name: NeonDrift_MVP
- chain_id: qa:NeonDrift_MVP:38bb9e33-842
- run_id: notion-NeonDrift_MVP-dmaic-20260626093748
- source_pipeline: qa
- checks_total: 9
- checks_failed: 3

## Define

- Problem statement: pipeline output must be detailed, playable, visually rich, evidence-backed, and traceable from raw idea to QA.
- Customer requirement: Notion must show whether planning/spec/development/build/QA evidence is sufficient before advancing.

## Measure

- PASS raw_idea_defined: passed
- PASS define_contract_present: passed
- PASS planning_depth_present: passed
- PASS spec_review_actionable: passed
- PASS development_unity_project_present: passed
- FAIL development_runtime_probe_present: marker:screenshot
- PASS build_evidence_present: passed
- FAIL qa_evidence_present: marker:product experience
- FAIL qa_hard_gates_present: marker:recording

## Analyze

- development_runtime_probe_present: marker:screenshot
- qa_evidence_present: marker:product experience
- qa_hard_gates_present: marker:recording

## Improve

- Return to Development: generate Unity runtime probe, scene, scripts, and implementation evidence before Build can start.
- Return to QA/Development loop: require simulator video, screenshots, product experience, human visual judgement, and every core gameplay function evidence.

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
| qa_menu_human_readability_gate | Visual | FAIL | menuVisualMetrics={'exists': True, 'width': 1206, 'height': 2622, 'sample_count': 40000, 'min_luma': 0.0, 'max_luma': 68.072, 'mean_luma': 29.014, 'dark_ratio': 0.7405, 'bright_ratio': 0.0,
| qa_game_over_visual_state_gate | Visual | FAIL | gameOverProbePresent=True, screenState='game_over', isGameOver=True, gameOverPanelVisible=True, gameplayToGameOver={'comparable': True, 'mean_abs_diff': 1.494, 'changed_ratio': 0.0092, 'sam
| qa_non_placeholder_visual_richness_gate | Visual | FAIL | gameplayVisualMetrics={'exists': True, 'width': 1206, 'height': 2622, 'sample_count': 40000, 'min_luma': 0.0, 'max_luma': 255.0, 'mean_luma': 24.535, 'dark_ratio': 0.765, 'bright_r
| qa_actual_gameplay_quality_gate | Gameplay | FAIL | tenSecondPlayabilityVerified=True, enemyPatternPressureVerified=True, skillRewardLoopVerified=True, humanPlaytestChecklistVerified=True, TenSecondPlayabilityVerified=True, EnemyPatternPr
| qa_visual_richness_quality_gate | Visual | FAIL | gameplayVisualsVerified=True, gameplayInstructionReadableVerified=True, videoExists=False, menuToGameplayChanged=True, gameplayToGameOverChanged=True, menuHumanReadable=False, gameplayNonP
| qa_human_visual_judgement_gate | Visual | FAIL | videoExists=False, menuScreenshot=True, gameplayScreenshot=True, gameOverScreenshot=True, retryScreenshot=True, menuToGameplayChanged=True, gameplayToGameOverChanged=True, gameOverToRetryCh
| qa_product_experience_gate | Gameplay | FAIL | menuLayoutVerified=True, menuElementsDoNotOverlap=True, gameplayHudHiddenInMenu=True, gameplayControlsHiddenInMenu=True, menuHumanReadable=False, hasObjectiveText=True, hasAvoidInstructionTex
| qa_style_frame_implementation_gate | Visual | FAIL | styleFrameReport=True, missingStyleFrameMarkers=[], video=False, menuScreenshot=True, gameplayScreenshot=True, gameOverScreenshot=True, retryScreenshot=True, menuToGameplayChanged=True,
- qa_product_experience_gate: FAIL
- qa_human_visual_judgement_gate: FAIL
QA status is failed. 9 checks failed and 0 checks are blocked.
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
