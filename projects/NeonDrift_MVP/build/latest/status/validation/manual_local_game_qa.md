# Manual Local Game QA

This QA row is controlled by Notion. When Status is `processing`, the watcher waits for the host local QA runner.

Runner command from `/Users/dragonkao/.openclaw`:

```bash
python3 scripts/run_game_qa_pipeline.py --run-id notion-NeonDrift_MVP-qa-qa-full-20260711062458 --project-name NeonDrift_MVP --channel-id 382b9e3384298039b171c9b2a60ae644 --stage-range qa-full --source-output-folder /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/ --source-handoff-path /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/build_full_validation.md --output-folder /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/ --pipeline-request 'Start Game QA only after Game Build has passed.
Game Build run id: notion-NeonDrift_MVP-build-build-ios-simulator-20260711062234
Source pipeline: build
Use the provided handoff as the source of truth.' --timeout 3600 --thinking off --skip-agent
```

Expected report: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/qa_full_validation.md

The QA watcher marks the Notion row finished after the host runner creates this report for the current run id.
