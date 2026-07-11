# iOS QA Delivery

## 繁體中文

- 專案: NeonDrift_MVP
- run_id: notion-NeonDrift_MVP-qa-qa-full-20260711070041
- 交付狀態: blocked
- QA 狀態: failed
- Release candidate: blocked
- checks_total: 151
- checks_failed: 2
- checks_blocked: 0
- bundle_id: com.DefaultCompany.NeonDrift.run.1783753118.17777

## iOS Simulator App

- app_path: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.run.1783753118.17777.app`

## Install And Launch

```bash
xcrun simctl install booted /Users/dragonkao/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/xcode_derived_data/Build/Products/Release-iphonesimulator/NeonDrift.run.1783753118.17777.app
xcrun simctl launch booted com.DefaultCompany.NeonDrift.run.1783753118.17777
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

- qa_retry_restarts_gameplay_gate: retryRestartsGameplayVerified=True, RetryRestartsGameplay=True, RawRetryRestartsMovingGameplay=False, gameOverToRetryChanged=True, retryVisualStateVisible=True.
- qa_common_sense_veto_gate: commonSenseVetoFailures=qa_retry_restarts_gameplay_gate=FAIL; dependencyStatuses={'qa_menu_human_readability_gate': 'PASS', 'qa_game_over_visual_state_gate': 'PASS', 'qa_retry_visual_recovery_gate': 'PASS', 'qa_retry_live_motion_after_retry_gate': 'PASS', 'qa_non_placeholder_visual_richness_gate': 'PASS', 'qa_gameplay_depth_quality_gate': 'PASS', 'qa_actual_gameplay_quality_gate': 'PASS', 'qa_human_interaction_quality_gate': 'PASS', 'qa_visual_richness_quality_gate': 'PASS', 'qa_first_run_gameplay_comprehension_gate': 'PASS', 'qa_game_system_design_gate': 'PASS', 'qa_retry_restarts_gameplay_gate': 'FAIL', 'qa_audio_feedback_gate': 'PASS', 'qa_ui_state_isolation_gate': 'PASS', 'qa_human_visual_judgement_gate': 'PASS', 'qa_product_experience_gate': 'PASS', 'qa_style_frame_implementation_gate': 'PASS'}.

## English Summary

Delivery status is blocked. QA status is failed; release candidate status is blocked.
