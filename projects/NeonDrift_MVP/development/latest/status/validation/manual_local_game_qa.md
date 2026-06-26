# Manual Local Game QA

This QA row is controlled by Notion. When Status is `processing`, the watcher waits for the host local QA runner.

Runner command from `/Users/dragonkao/.openclaw`:

```bash
python3 scripts/run_game_qa_pipeline.py --run-id notion-NeonDrift_MVP-qa-qa-full-20260626141348 --project-name NeonDrift_MVP --channel-id 382b9e3384298039b171c9b2a60ae644 --stage-range qa-full --source-output-folder /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/ --source-handoff-path /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/build_full_validation.md --output-folder /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/ --pipeline-request 'DMAIC remediation target: qa

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
- | runtime_probe_has_right_control_zone | Interaction | PASS | hasRightControlZone=True in missing runtime probe. | m' --timeout 3600 --thinking off --skip-agent
```

Expected report: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/qa_full_validation.md

The QA watcher marks the Notion row finished after the host runner creates this report for the current run id.
