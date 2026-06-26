# DMAIC Pipeline Review

## Summary

- status: failed
- project_name: NeonDrift_MVP
- chain_id: spec-review:NeonDrift_MVP:38bb9e33-19189169
- run_id: notion-NeonDrift_MVP-dmaic-20260626141332
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

- qa_evidence_gap -> qa: QA evidence package is incomplete.

## Improve

- remediation_target: qa
- Return to QA/Development loop: require simulator video, screenshots, product experience, human visual judgement, and every core gameplay function evidence.
- Create remediation Notion row targeting qa; do not stop at reporting.

## Remediation Request

DMAIC remediation target: qa

Root causes:
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
- | simulator_live_gameplay_probe_present | Runtime | FAIL | runtime_probe=missing, build_runtime_probe=/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json. | /home/node/
- | runtime_probe_has_pause_button | Interaction | PASS | hasPauseButton=True in missing runtime probe. | missing runtime_probe.json |
- | runtime_probe_has_retry_button | Interaction | PASS | hasRetryButton=True in missing runtime probe. | missing runtime_probe.json |
- | runtime_probe_has_left_control_zone | Interaction | PASS | hasLeftControlZone=True in missing runtime probe. | missing runtime_probe.json |
- | runtime_probe_has_right_control_zone | Interaction | PASS | hasRightControlZone=True in missing runtime probe. | missing runtime_probe.json |
- | runtime_probe_pause_control_verified | Interaction | PASS | pauseControlVerified=True in missing runtime probe. | missing runtime_probe.json |
- | runtime_probe_retry_control_verified | Interaction | PASS | retryControlVerified=True in missing runtime probe. | missing runtime_probe.json |
- | runtime_probe_left_right_steering_verified | Interaction | PASS | leftRightSteeringVerified=True in missing runtime probe. | missing runtime_probe.json |
- | runtime_probe_safe_area_applied | Compatibility | PASS | safeAreaApplied=True in missing runtime probe. | missing runtime_probe.json |
- | runtime_probe_frame_pacing_configured | Performance | PASS | framePacingConfigured=True in missing runtime probe. | missing runtime_probe.json |
- | runtime_probe_has_event_system | Interaction | PASS | hasEventSystem=True in missing runtime probe. | missing runtime_probe.json |
- | runtime_probe_has_graphic_raycaster | Interaction | PASS | hasGraphicRaycaster=True in missing runtime probe. | missing runtime_probe.json |

## Control

- Keep this DMAIC row linked by Chain ID and source page.
- Any future QA pass without product experience, human visual judgement, function playability, and recording evidence must remain failed.
- Any Development pass without runtime implementation evidence must be blocked before Build.

## QA Failure Signals

- QA 結果: failed
- Release candidate: blocked
| unity_editmode_tests_passed | Regression | PASS | 3 total, 0 failed. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_editmode_test_results.xml |
| unity_playmode_tests_passed | Regression | PASS | 33 total, 0 failed. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/unity_playmode_test_results.xml |
| simulator_live_gameplay_probe_present | Runtime | FAIL | runtime_probe=missing, build_runtime_probe=/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json. | /home/node/
| runtime_probe_has_pause_button | Interaction | PASS | hasPauseButton=True in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_has_retry_button | Interaction | PASS | hasRetryButton=True in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_has_left_control_zone | Interaction | PASS | hasLeftControlZone=True in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_has_right_control_zone | Interaction | PASS | hasRightControlZone=True in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_pause_control_verified | Interaction | PASS | pauseControlVerified=True in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_retry_control_verified | Interaction | PASS | retryControlVerified=True in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_left_right_steering_verified | Interaction | PASS | leftRightSteeringVerified=True in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_safe_area_applied | Compatibility | PASS | safeAreaApplied=True in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_frame_pacing_configured | Performance | PASS | framePacingConfigured=True in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_has_event_system | Interaction | PASS | hasEventSystem=True in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_has_graphic_raycaster | Interaction | PASS | hasGraphicRaycaster=True in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_has_ui_actions | Interaction | PASS | hasUiActions=True in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_pause_button_clickable | Interaction | PASS | pauseButtonClickable=True in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_retry_button_clickable | Interaction | PASS | retryButtonClickable=True in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_pause_retry_button_size_verified | UI/UX | PASS | pauseRetryButtonSizeVerified=True in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_control_zone_size_verified | Interaction | PASS | controlZoneSizeVerified=True in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_core_gameplay_objects_verified | Runtime | PASS | coreGameplayObjectsVerified=True in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_scoring_system_verified | Runtime | PASS | scoringSystemVerified=True in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_pause_system_verified | Interaction | PASS | pauseSystemVerified=True in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_failure_retry_system_verified | Interaction | PASS | failureRetrySystemVerified=True in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_gameplay_visuals_verified | Gameplay | FAIL | gameplayVisualsVerified=None in missing runtime probe. | missing runtime_probe.json |
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
| runtime_probe_readable_hazard_pacing_verified | Gameplay | FAIL | readableHazardPacingVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_ten_second_playability_verified | Gameplay | FAIL | tenSecondPlayabilityVerified=None in missing runtime probe. | missing runtime_probe.json |
| runtime_probe_enemy_pattern_pressure_verified | Gameplay | FAIL | enemyPatternPressureVerified=None in missing runtime probe. | missing runtime_probe.json |
