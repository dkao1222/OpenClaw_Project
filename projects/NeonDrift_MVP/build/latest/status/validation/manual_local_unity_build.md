# Manual Local Unity Build

This build row is controlled by Notion. In host mode the watcher may launch the local Unity build runner from `not start` or `processing` when Unity Editor is licensed and available.

Runner command from `/Users/dragonkao/.openclaw`:

```bash
python3 scripts/run_game_build_pipeline.py --run-id notion-NeonDrift_MVP-build-build-ios-simulator-20260711071025 --project-name NeonDrift_MVP --channel-id 382b9e3384298039b171c9b2a60ae644 --stage-range build-ios-simulator --source-output-folder /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/ --source-handoff-path /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/handoffs/development/final_handoff.md --output-folder /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/
```

Default host build Unity is `/Applications/Unity/Hub/Editor/6000.0.77f1/Unity.app/Contents/MacOS/Unity`. Optional: add `--unity-path /path/to/Unity` only when intentionally overriding it.

Expected report: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/build_full_validation.md

The build watcher marks the Notion row finished after the runner creates this report with `- status: passed` or `- status: failed`.
