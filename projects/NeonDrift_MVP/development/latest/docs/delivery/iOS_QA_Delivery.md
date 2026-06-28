# iOS QA Delivery

## 繁體中文

- 專案: NeonDrift_MVP
- run_id: notion-NeonDrift_MVP-qa-qa-full-20260628093053
- 交付狀態: blocked
- QA 狀態: failed
- Release candidate: blocked
- checks_total: 147
- checks_failed: 5
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

- runtime_probe_ten_second_playability_verified: tenSecondPlayabilityVerified=False in qa_runtime_probe_gameplay.json.
- runtime_probe_enemy_pattern_pressure_verified: enemyPatternPressureVerified=False in qa_runtime_probe_gameplay.json.
- runtime_probe_human_playtest_checklist_verified: humanPlaytestChecklistVerified=False in qa_runtime_probe_gameplay.json.
- runtime_probe_gameplay_claims_require_running_state: screenState='game_over', hasStarted=True, gameplayTime=6.550021171569824, score=266, claimed_flags=['contentDepthVerified', 'gameplayMotionVerified', 'hazardApproachMotionVerified', 'playerSteeringMotionVerified', 'humanAgencyVerified', 'playerInputChangesOutcomeVerified', 'skillRewardLoopVerified'].
- qa_actual_gameplay_quality_gate: tenSecondPlayabilityVerified=False, enemyPatternPressureVerified=False, skillRewardLoopVerified=True, humanPlaytestChecklistVerified=False, TenSecondPlayabilityVerified=True, EnemyPatternPressureVerified=True, SkillRewardLoopVerified=True, HumanPlaytestChecklistVerified=True, video=True, gameplayScreenshot=True, menuToGameplayChanged=True.

## English Summary

Delivery status is blocked. QA status is failed; release candidate status is blocked.
