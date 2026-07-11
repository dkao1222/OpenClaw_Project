# Manual Local Game QA

This QA row is controlled by Notion. When Status is `processing`, the watcher waits for the host local QA runner.

Runner command from `/Users/dragonkao/.openclaw`:

```bash
python3 scripts/run_game_qa_pipeline.py --run-id notion-NeonDrift_MVP-qa-qa-full-20260711071948 --project-name NeonDrift_MVP --channel-id 382b9e3384298039b171c9b2a60ae644 --stage-range qa-full --source-output-folder /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/ --source-handoff-path /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/build_full_validation.md --output-folder /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/ --pipeline-request 'DMAIC remediation target: qa

Root causes:
- qa_failure_requires_remediation: QA report contains failed checks; the pipeline must create a remediation loop instead of closing as control monitoring.

Required correction:
- Do not mark the remediation passed unless generated runtime/product evidence directly resolves the listed root causes.
- Preserve the Chain ID and source DMAIC report for traceability.
- If returning to Development, fix implementation, visual readability, gameplay playability, runtime QA probe/evidence, and retry/menu/gameplay states before Build.
- If returning to QA, rerun simulator QA and produce screenshots, video/recording evidence, raw evidence JSON, and human product-experience checks.

Observed QA failure signals:
- "expected": "QA must fail whenever the product feels unreasonable to a human: confusing gameplay, inert motion, unclear objective, unclear controls, weak visual feedback, overlapping states, placeholder visuals, missing audio/feedback evide

OPDCA + DMAIC source:
- dmaic_page_id: 39ab9e33-8429-811f-a12a-ed3419d3543f
- dmaic_run_id: notion-NeonDrift_MVP-dmaic-20260711071556
- dmaic_report_path: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/dmaic/notion-NeonDrift_MVP-dmaic-20260711071556/dmaic_report.md

OPDCA Act rule:
- The remediation row cannot pass unless OPDCA + DMAIC failed checks are resolved by concrete runtime/product evidence.' --timeout 3600 --thinking off --skip-agent
```

Expected report: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/qa_full_validation.md

The QA watcher marks the Notion row finished after the host runner creates this report for the current run id.
