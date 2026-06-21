# Manual Local Unity Build

This build row is controlled by Notion. When Status is `processing`, the watcher may launch the local Unity build runner.

Runner command from `/Users/dragonkao/.openclaw`:

```bash
python3 scripts/run_game_build_pipeline.py --run-id notion-NeonDrift_MVP-build-build-ios-simulator-20260621171916 --project-name NeonDrift_MVP --channel-id 382b9e3384298039b171c9b2a60ae644 --stage-range build-ios-simulator --source-output-folder /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/ --source-handoff-path /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/handoffs/development/final_handoff.md --output-folder /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/
```

Optional: add `--unity-path /path/to/Unity` if auto-detection picks the wrong editor.

Expected report: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/validation/build_full_validation.md

The build watcher marks the Notion row finished after the runner creates this report with `- status: passed` or `- status: failed`.
