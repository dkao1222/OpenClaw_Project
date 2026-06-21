# iOS QA Delivery

## 繁體中文

- 專案: NeonDrift_MVP
- run_id: notion-NeonDrift_MVP-qa-qa-full-20260621171618
- 交付狀態: blocked
- QA 狀態: failed
- Release candidate: blocked
- checks_total: 59
- checks_failed: 8
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

- QA result: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/qa_result.json`
- QA report: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/full_qa_report.md`
- QA validation: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/qa_full_validation.md`
- Evidence index: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence_index.md`
- Delivery manifest: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/delivery/qa_delivery_manifest.json`

## Evidence

- build_report: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/build_full_validation.md`
- runtime_probe: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/runtime_probe.json`
- screenshot: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_simulator_initial_run.png`
- runtime_log: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/logs/ios_simulator_runtime.log`
- raw_evidence: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/raw_evidence.json`
- evidence_summary: `/home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/evidence/evidence_summary.md`

## Required Fixes

- runtime_probe_button_layout_verified: buttonLayoutVerified=False in runtime_probe.json.
- runtime_probe_control_zone_size_verified: controlZoneSizeVerified=False in runtime_probe.json.
- runtime_probe_controls_do_not_overlap: controlsDoNotOverlap=False in runtime_probe.json.
- runtime_probe_core_gameplay_objects_verified: coreGameplayObjectsVerified=False in runtime_probe.json.
- runtime_probe_scoring_system_verified: scoringSystemVerified=False in runtime_probe.json.
- runtime_probe_pause_system_verified: pauseSystemVerified=False in runtime_probe.json.
- playmode_button_position_size_contract: ButtonPositionsAndSizesAreVerified not found in PlayMode XML.
- playmode_core_gameplay_function_contract: CoreGameplayFunctionsAreVerified not found in PlayMode XML.

## English Summary

Delivery status is blocked. QA status is failed; release candidate status is blocked.
